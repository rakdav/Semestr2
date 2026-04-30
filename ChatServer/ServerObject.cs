using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace ChatServer
{
    public class ServerObject
    {
        private string? ipAddress;
        private TcpListener? tcpListener;
        private List<ClientObject>? clients;
        public ServerObject(string _ipAddress)
        {
            ipAddress = _ipAddress;
            clients = new List<ClientObject>();
            tcpListener = new TcpListener(IPAddress.Parse(ipAddress), 8888);
        }
        protected internal async Task ListenAsync()
        {
            try
            {
                tcpListener!.Start();
                while (true)
                {
                    TcpClient tcpClient = await tcpListener.AcceptTcpClientAsync();
                    ClientObject clientObject = new ClientObject(tcpClient, this);
                    clients!.Add(clientObject);
                    Task.Run(clientObject.ProcessAsync);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Disconnect();
            }
        }
        protected internal async Task BroadcastMessageAsync(string message, string id)
        {
            foreach (var client in clients!)
            {
                if (client.Id != id)
                {
                    await client.Writer.WriteLineAsync(message);
                    await client.Writer.FlushAsync();
                }
            }
        }
        protected internal void Disconnect()
        {
            foreach(var client in clients)
            {
                client.Close();
            }
            tcpListener!.Stop();
        }
        protected internal void RemoveConnection(string id)
        {
            ClientObject? client = clients!.FirstOrDefault(c => c.Id == id);
            if (client != null) clients.Remove(client);
            client?.Close();
        }
    }
}
