using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Lab14Send
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private UdpClient udpClient;
        public MainWindow()
        {
            InitializeComponent();
            udpClient = new UdpClient();
        }

        private async void Button_Click(object sender, RoutedEventArgs e)
        {
            byte[] data = Encoding.UTF8.GetBytes(Speed.Text);
            IPEndPoint remotePoint = new IPEndPoint(IPAddress.Parse("192.168.122.139"), 5555);
            await udpClient.SendAsync(data, remotePoint);
        }
    }
}