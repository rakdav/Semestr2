using OSLab1.ViewModel;
using System.Drawing;
using System.IO;
using System.Linq.Expressions;
using System.Windows;


namespace OSLab1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            DataContext = new MainViewModel(this);
        }
    }
}