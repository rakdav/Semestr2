using ChatClient.Commands;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Threading;

namespace ChatClient.ViewModel
{
    public class MainViewModel : INotifyPropertyChanged
    {
        private MainWindow window;
        private string? address;
        public string? Address
        {
            get { return address; }
            set
            {
                address = value;
                OnPropertyChanged(nameof(Address));
            }
        }
        private int port;
        public int Port
        {
            get { return port; }
            set
            {
                port = value;
                OnPropertyChanged(nameof(Port));
            }
        }
        private string? userName;
        public string? UserName
        {
            get { return userName; }
            set
            {
                userName = value;
                OnPropertyChanged(nameof(UserName));
            }
        }
        private string? message;
        public string? Message
        {
            get { return message; }
            set
            {
                message = value;
                OnPropertyChanged(nameof(Message));
            }
        }
        public ObservableCollection<string> Messages { get; set; }
        private StreamReader? Reader = null;
        private StreamWriter? Writer = null;
        private TcpClient tcpClient;
        public MainViewModel(MainWindow _window)
        {
            Messages = new ObservableCollection<string>();
            tcpClient = new TcpClient();
            this.window = _window;
        }
        private RelayCommand connectCommand;
        public RelayCommand ConnectCommand
        {
            get
            {
                return connectCommand ??
                  (connectCommand = new RelayCommand(obj =>
                  {
                      try
                      {
                          tcpClient.Connect(Address!, Port);
                          Reader = new StreamReader(tcpClient.GetStream());
                          Writer = new StreamWriter(tcpClient.GetStream());
                          if (Writer is null || Reader is null) return;
                          Task.Run(() => ReceiveMessageAsync(Reader));
                          
                      }
                      catch (Exception ex)
                      {
                          MessageBox.Show(ex.Message);
                      }
                  }));
            }
        }
        async Task ReceiveMessageAsync(StreamReader reader)
        {
            while (true)
            {
                try
                {
                    string? message = await reader.ReadLineAsync();
                    if (string.IsNullOrEmpty(message)) continue;
                    window!.Dispatcher?.Invoke(() => { Messages.Add(message); });
                }
                catch
                {
                    break;
                }
            }
        }
        private RelayCommand closeCommand;
        public RelayCommand CloseCommand
        {
            get
            {
                return closeCommand ??
                  (closeCommand = new RelayCommand(obj =>
                  {
                      Writer?.Close();
                      Reader?.Close();
                  }));
            }
        }
        private RelayCommand sendCommand;
        public RelayCommand SendCommand
        {
            get
            {
                return sendCommand ??
                  (sendCommand = new RelayCommand(async obj =>
                  {
                      await SendMessageAsync(Writer!);
                  }));
            }
        }
        async Task SendMessageAsync(StreamWriter writer)
        {
            await writer.WriteLineAsync(UserName);
            await writer.FlushAsync();
            await writer.WriteLineAsync(Message);
            await writer.FlushAsync();
        }
        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName] string prop = "")
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
        }
        
    }
}
