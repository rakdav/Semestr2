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
        private HomeAddress? address;
        public HomeAddress Address
        {
            get => address ??= new HomeAddress();
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

        public override string? ToString()
        {
            return $"{FIO},{Phone},{Address.PostalCode},{Address.Country}," +
                $"{Address.Region},{Address.Area},{Address.City},{Address.Street},{Address.Home},{Address.Department}," +
                $"{Marka},{Number},{TechPassport}";
        }

        public event PropertyChangedEventHandler? PropertyChanged;
        public void OnPropertyChanged([CallerMemberName] string prop = "")
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
        }
    }
}
