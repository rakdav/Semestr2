using System.Net;
using System.Net.NetworkInformation;

//IPAddress localIp = new IPAddress(new byte[] {127,0,0,1});
//Console.WriteLine(localIp);
//IPAddress someIp = new IPAddress(0x0100007F);
//Console.WriteLine(someIp);
//IPAddress ip=IPAddress.Parse("127.0.0.1");
//Console.WriteLine(ip);
//IPAddress anyIp = IPAddress.Any;
//Console.WriteLine(anyIp);
//IPAddress localhost = IPAddress.Loopback;
//Console.WriteLine(localhost);
//IPAddress broadcastIp=IPAddress.Broadcast;

//Console.WriteLine(localIp.AddressFamily);

//IPAddress myAdd = IPAddress.Parse("192.168.122.139");
//IPEndPoint endPoint = new IPEndPoint(myAdd, 8080);
//Console.WriteLine(endPoint.Address);
//Console.WriteLine(endPoint.Port);

//string uriString = "https://mail.ru/";
//Uri myURI= new Uri(uriString);
//Console.WriteLine(myURI.AbsoluteUri);
//Console.WriteLine(myURI.Host);
//Console.WriteLine(myURI.Port);
//Console.WriteLine(myURI.Authority);
//Console.WriteLine(myURI.IsAbsoluteUri);
//Console.WriteLine(myURI.IsFile);
//Console.WriteLine(myURI.Scheme);
//Console.WriteLine(myURI.IsLoopback);
//Console.WriteLine(myURI.Query);
//Console.WriteLine(myURI.Fragment);
//Console.WriteLine(myURI.UserInfo);
//Console.WriteLine(myURI.OriginalString);
//Console.WriteLine(myURI.IsDefaultPort);
//Console.WriteLine(myURI.PathAndQuery);

//Uri uri1 = new Uri("https://mail.ru/", UriKind.Absolute);
//Uri uri2 = new Uri("inbox", UriKind.Relative);
//Uri uri3 = new Uri("https://mail.ru/", UriKind.RelativeOrAbsolute);

//UriBuilder uriBuilder1 = new UriBuilder("https","metanit.com",443,"sharp/net");
//Uri uri4 = uriBuilder1.Uri;
//Console.WriteLine(uri4);


//UriBuilder uriBuilder2 = new UriBuilder();
//uriBuilder2.Scheme = "https";
//uriBuilder2.Host = "metanit.com";
//uriBuilder2.Port = 80;
//Uri uri5= uriBuilder2.Uri;
//Console.WriteLine(uri5);

//var adapters=NetworkInterface.GetAllNetworkInterfaces();
//Console.WriteLine($"Обнаружено {adapters.Length} устройств");
//foreach (NetworkInterface adapter in adapters)
//{
//    Console.WriteLine($"ID:{adapter.Id}");
//    Console.WriteLine($"Имя:{adapter.Name}");
//    Console.WriteLine($"Описание:{adapter.Description}");
//    Console.WriteLine($"Тип:{adapter.NetworkInterfaceType}");
//    Console.WriteLine($"MAC:{adapter.GetPhysicalAddress()}");
//    Console.WriteLine($"Статас:{adapter.OperationalStatus}");
//    Console.WriteLine($"Скорость:{adapter.Speed}");

//    IPInterfaceStatistics stats=adapter.GetIPStatistics();
//    Console.WriteLine($"Получено:{stats.BytesReceived}");
//    Console.WriteLine($"Отправлено:{stats.BytesSent}");
//    Console.WriteLine();
//}

var ipProps=IPGlobalProperties.GetIPGlobalProperties();
var ipStats=ipProps.GetIPv4GlobalStatistics();
Console.WriteLine($"Входящие пакеты:{ipStats.ReceivedPackets}");
Console.WriteLine($"Исходящие пакеты:{ipStats.OutputPacketRequests}");
Console.WriteLine($"Отброшенные входящие пакеты:{ipStats.ReceivedPacketsDiscarded}");
Console.WriteLine($"Отброшенные исходящие пакеты:{ipStats.OutputPacketsDiscarded}");
Console.WriteLine($"Ошибки фрагментации:{ipStats.PacketFragmentFailures}");
Console.WriteLine($"Ошибки восстановления пакетов:{ipStats.PacketReassemblyFailures}");





