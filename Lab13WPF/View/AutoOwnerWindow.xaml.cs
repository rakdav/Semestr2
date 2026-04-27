using Lab13WPF.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Lab13WPF.View
{
    /// <summary>
    /// Логика взаимодействия для AutoOwnerWindow.xaml
    /// </summary>
    public partial class AutoOwnerWindow : Window
    {
        public AutoOwner AutoOwner { get; private set; }
        public AutoOwnerWindow(AutoOwner _autoOwner)
        {
            InitializeComponent();
            AutoOwner = _autoOwner;
            DataContext = AutoOwner;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            DialogResult = true;
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            DialogResult=false;
        }
    }
}
