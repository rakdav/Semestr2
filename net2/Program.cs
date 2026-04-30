using System.Net;
using System.Net.Sockets;
using System.Text;

#region Socket

//клиент socket
//var port = 80;
//var url = "www.google.com";
//using var socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
//try
//{
//    await socket.ConnectAsync(url,port);
//    //Информация о подключении

//    //Console.WriteLine($"Подключение к {port} установлено");
//    //Console.WriteLine($"Подключение к {url} установлено");
//    //Console.WriteLine($"Адрес подключения {socket.RemoteEndPoint}");
//    //Console.WriteLine($"Адрес приложения {socket.LocalEndPoint}");
//    //await socket.DisconnectAsync(true);

//    //Отправка данных

//    var message = $"GET / HTTP/1.1\r\nHost: {url}\r\nConnection: close\r\n\r\n";
//    var messageBytes=Encoding.UTF8.GetBytes(message);
//    int bytesSend = socket.Send(messageBytes);
//    Console.WriteLine($"на адрес {url} отправлено {bytesSend} байт(а)");
//    int bytes;

//        //Получение данных от хоста
//        var responseBytes = new byte[512];
//        var builder = new StringBuilder();
//    do
//    {
//        bytes = await socket.ReceiveAsync(responseBytes);
//        string response = Encoding.UTF8.GetString(responseBytes, 0, bytes);
//        builder.Append(response);
//    }
//    while (socket.Available > 0);
//    Console.WriteLine(builder);
//}
//catch (SocketException ex)
//{
//    Console.WriteLine(ex.Message);
//}

//socket server
//IPEndPoint ipPoint = new IPEndPoint(IPAddress.Parse("192.168.122.139"), 8888);
//using Socket socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
//socket.Bind(ipPoint);
//while (true)
//{
//    socket.Listen(1000);
//    using Socket client = await socket.AcceptAsync();
//    Console.WriteLine($"Адрес подключенного клиента: {client.RemoteEndPoint}");
//}
//Console.WriteLine(socket.LocalEndPoint);

//socket client
//using var socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
//try
//{
//    await socket.ConnectAsync("192.168.122.139", 8888);
//    Console.WriteLine($"Подключение к {socket.RemoteEndPoint} установлено");
//}
//catch(SocketException ex)
//{
//    Console.WriteLine(ex.Message);
//}

#endregion

#region NetworkStream
//using var mySocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
//var server = "www.google.com";
//mySocket.Connect(server, 80);

//using var stream = new NetworkStream(mySocket);
////// получаем локальный адрес
////Console.WriteLine($"Локальный адрес: {stream.Socket.LocalEndPoint}");
////// получаем адрес сервера
////Console.WriteLine($"Адрес сервера: {stream.Socket.RemoteEndPoint}");
////stream.Close();

//// отправляем сообщение для отправки
//var message = $"GET / HTTP/1.1\r\nHost: {server}\r\nConnection: Close\r\n\r\n";
//// кодируем его в массив байт
//var data = Encoding.UTF8.GetBytes(message);
//// отправляем массив байт на сервер 
//await stream.WriteAsync(data);
//Console.WriteLine($"Данные отправлены на сервер {server}");
//// буфер ддя получения данных
//var responseData = new byte[512];
// StringBuilder для склеивания полученных данных в одну строку
//var response = new StringBuilder();
//int bytes;  // количество полученных байтов
//do
//{
//    // получаем данные
//    bytes = await stream.ReadAsync(responseData);
//    // преобразуем в строку и добавляем ее в StringBuilder
//    response.Append(Encoding.UTF8.GetString(responseData, 0, bytes));
//}
//while (bytes > 0); // пока данные есть в потоке 
// получаем данные
//await stream.ReadExactlyAsync(responseData);
//// преобразуем в строку
//var response = Encoding.UTF8.GetString(responseData);
//// выводим данные на консоль
//Console.WriteLine(response);
#endregion

#region TCPClient
//using TcpClient tcpClient=new TcpClient();
//try
//{
//    await tcpClient.ConnectAsync("www.google.com", 80);
//    Console.WriteLine("Подключено");
//    NetworkStream stream = tcpClient.GetStream();
//    var requestMessage = $"GET / HTTP/1.1\r\nHost:www.google.com\r\nConnection: Close\r\n\r\n";
//    // конвертируем данные в массив байтов
//    var requestData = Encoding.UTF8.GetBytes(requestMessage);
//    // отправляем данные серверу
//    await stream.WriteAsync(requestData);

//    // буфер для получения данных
//    var responseData = new byte[512];
//    // StringBuilder для склеивания полученных данных в одну строку
//    var response = new StringBuilder();
//    int bytes;  // количество полученных байтов
//    do
//    {
//        // получаем данные
//        bytes = await stream.ReadAsync(responseData);
//        // преобразуем в строку и добавляем ее в StringBuilder
//        response.Append(Encoding.UTF8.GetString(responseData, 0, bytes));
//    }
//    while (tcpClient.Available > 0); // пока данные есть в потоке 
//    Console.WriteLine(response);
//}
//catch(SocketException ex)
//{
//    Console.WriteLine(ex.Message);
//}
//finally
//{
//    tcpClient.Close();
//}

//using var tcpClient = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
//try
//{
//    await tcpClient.ConnectAsync(IPAddress.Parse("192.168.122.139"), 8888);
//    string mes=Console.ReadLine()!;
//    byte[] data=Encoding.UTF8.GetBytes(mes);
//    await tcpClient.SendAsync(data);
//}
//catch (Exception ex)
//{
//    Console.WriteLine(ex.Message);
//}

//using TcpClient tcpClient=new TcpClient();
//Console.WriteLine("Клиент запущен");
//await tcpClient.ConnectAsync("192.168.122.139", 8888);
//if(tcpClient.Connected)
//    Console.WriteLine($"Подключение с {tcpClient.Client.RemoteEndPoint} установлено");
//else
//    Console.WriteLine("Не удалось подключиться");

//while (true)
//{
//    Console.Clear();
//    using var tcpClient = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
//    try
//    {
//        await tcpClient.ConnectAsync("192.168.122.139", 8888);
//        byte[] data = new byte[512];
//        int bytes = await tcpClient.ReceiveAsync(data);
//        string time = Encoding.UTF8.GetString(data, 0, bytes);
//        Console.WriteLine($"Текущее время: {time}");
//        Thread.Sleep(1000);
//    }
//    catch (Exception ex)
//    {
//        Console.WriteLine(ex.Message);
//    }
//}
//while (true)
//{
//    var message = Console.ReadLine();
//    using var tcpClient = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
//    try
//    {
//        await tcpClient.ConnectAsync("192.168.122.139", 8888);

//        byte[] requestData = Encoding.UTF8.GetBytes(message!);
//        await tcpClient.SendAsync(requestData);
//    }
//    catch (Exception ex)
//    {
//        Console.WriteLine(ex.Message);
//    }
//}

#endregion

#region TCPServer
//var tcpListener = new TcpListener(IPAddress.Parse("192.168.122.139"), 8888);
//try
//{
//    tcpListener.Start();    // запускаем сервер
//    Console.WriteLine("Сервер запущен. Ожидание подключений... ");
//    while (true)
//    {
//        using var tcpClient = await tcpListener.AcceptTcpClientAsync();
//        Console.WriteLine($"Входящее подключение: {tcpClient.Client.RemoteEndPoint}");
//    }
//}
//finally
//{
//    tcpListener.Stop();
//}

//сервер отправки
//IPEndPoint ipPoint = new IPEndPoint(IPAddress.Parse("192.168.122.139"), 8888);
//using Socket tcpListener = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
//try
//{
//    tcpListener.Bind(ipPoint);
//    tcpListener.Listen();
//    Console.WriteLine("Сервер запущен.Ожидание подключений... ");
//    while (true)
//    {
//            using var tcpClient = await tcpListener.AcceptAsync();
//            byte[] data = Encoding.UTF8.GetBytes(DateTime.Now.ToLongTimeString());
//            await tcpClient.SendAsync(data);
//            Console.WriteLine($"Клиенту {tcpClient.RemoteEndPoint} отправлены данные");
//    }
//}
//catch (Exception ex)
//{
//    Console.WriteLine(ex.Message);
//}



//сервер получения
IPEndPoint ipPoint = new IPEndPoint(IPAddress.Parse("192.168.122.139"), 8888);
using Socket tcpListener = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
try
{
    tcpListener.Bind(ipPoint);
    tcpListener.Listen();
    while (true)
    {
        using var tcpClient = await tcpListener.AcceptAsync();
        List<byte> response = [];
        byte[] buffer = new byte[512];
        int bytes = 0;
        do
        {
            bytes = await tcpClient.ReceiveAsync(buffer);
            response.AddRange(buffer.Take(bytes));
        }
        while (bytes > 0);
        var responseText = Encoding.UTF8.GetString(response.ToArray());
        Console.WriteLine(responseText);
    }
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}
#endregion