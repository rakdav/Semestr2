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

namespace ChatClient.ViewModel
{
    public class MainViewModel : INotifyPropertyChanged
    {
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
        public MainViewModel()
        {
            Messages = new ObservableCollection<string>();
            tcpClient = new TcpClient();
        }

        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName] string prop = "")
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
        }
    }
}
