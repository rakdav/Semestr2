using System.Net.Sockets;

var port = 80;
var url = "www.google.com";
using var socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
try
{
    await socket.ConnectAsync(url,port);
    //Console.WriteLine($"Подключение к {port} установлено");
    //Console.WriteLine($"Подключение к {url} установлено");
    //Console.WriteLine($"Адрес подключения {socket.RemoteEndPoint}");
    //Console.WriteLine($"Адрес приложения {socket.LocalEndPoint}");
    //await socket.DisconnectAsync(true);
    var message = $"GET / HTTP/1.1\r\nHost: {url}\r\nConnection: close\r\n\r\n";
}
catch(SocketException ex)
{
    Console.WriteLine(ex.Message);
}

