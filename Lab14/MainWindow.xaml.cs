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
using System.Windows.Threading;

namespace Lab14
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private double x1 = 100;
        private double y1 = 100;
        private double x2 = 500;
        private double y2 = 100;
        private double x3 = 500;
        private double y3 = 500;
        private double x4 = 100;
        private double y4 = 500;
        private DispatcherTimer timer;
        private int side = 1;
        private UdpClient udpServer;
        private int speed = 10;
        public MainWindow()
        {
            InitializeComponent();
            timer=new DispatcherTimer();
            Draw(x1, y1, x2, y2, x3, y3, x4, y4);
            udpServer = new UdpClient(5555);
            GetMessage();
        }
        private async void GetMessage()
        {
            while (true)
            {
                var result = await udpServer.ReceiveAsync();
                string message = Encoding.UTF8.GetString(result.Buffer);
                speed = int.Parse(message);
            }
        }
        private void Draw(double _x1,double _y1,
                          double _x2, double _y2,
                          double _x3, double _y3,
                          double _x4, double _y4)
        {
            canva.Children.Clear();
            Polygon polygon = new Polygon();
            polygon.Points = new PointCollection();
            polygon.Points.Add(new Point(_x1, _y1));
            polygon.Points.Add(new Point(_x2, _y2));
            polygon.Points.Add(new Point(_x3, _y3));
            polygon.Points.Add(new Point(_x4, _y4));
            polygon.Fill = Brushes.Red;
            canva.Children.Add(polygon);
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
           
            timer.Interval = TimeSpan.FromSeconds(1);
            timer.Tick += Timer_Tick;
            timer.Start();
        }

        private void Timer_Tick(object? sender, EventArgs e)
        {
            if (side == 1)
            {
                x4 = x1 += speed;
                x2 = x3 -= speed;
                if (x1 == x2) side = 2;
            }
            else if (side == 2)
            {
                x4 = x1 -= speed;
                x2 = x3 += speed;
                if (x1 >= 100 && x2 <= 500) side = 3;
            }
            if (side == 3)
            {
                y1 = y2 += speed;
                y3 = y4 -= speed;
                if (y2 == y3) side = 4;
            }
            else if (side == 4)
            {
                y1 = y2 -= speed;
                y3 = y4 += speed;
                if (y1 >= 100 && y3 <= 500) side = 1;
            }

            Draw(x1, y1, x2, y2, x3, y3, x4, y4);
        }

        private void canva_MouseDown(object sender, MouseButtonEventArgs e)
        {
            timer.Stop();
        }
    }
}