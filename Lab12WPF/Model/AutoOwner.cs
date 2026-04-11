using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Lab12WPF.Model
{
    public class AutoOwner:INotifyPropertyChanged
    {
        private string? fio;
        public string FIO
        {
            get=>fio!;
            set
            {
                fio = value;
                OnPropertyChanged(nameof(FIO));
            }
        }
        private string? phone;
        public string Phone
        {
            get => phone!;
            set
            {
                phone = value;
                OnPropertyChanged(nameof(Phone));
            }
        }
        private HomeAddress address;
        public HomeAddress Address
        {
            get => address;
            set
            {
                address = value;
                OnPropertyChanged(nameof(Address));
            }
        }
        private string? marka;
        public string Marka
        {
            get => marka!;
            set
            {
                marka = value;
                OnPropertyChanged(nameof(Marka));
            }
        }
        private string? number;
        public string Number
        {
            get => number!;
            set
            {
                number = value;
                OnPropertyChanged(nameof(Number));
            }
        }
        private string? techPassport;
        public string TechPassport
        {
            get => techPassport!;
            set
            {
                techPassport = value;
                OnPropertyChanged(nameof(TechPassport));
            }
        }
        public event PropertyChangedEventHandler? PropertyChanged;
        public void OnPropertyChanged([CallerMemberName] string prop = "")
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
        }
    }
    public class HomeAddress
    {
        public int PostalCode { get; set; }
        public string? Country { get; set; }
        public string? Region { get; set; }
        public string? Area { get; set; }
        public string? City { get; set; }
        public string? Street { get; set; }
        public int Home { get; set; }
        public int Department { get; set; }
    }
}
