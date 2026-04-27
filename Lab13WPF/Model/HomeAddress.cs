using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Lab13WPF.Model
{
    public class HomeAddress: INotifyPropertyChanged
    {
        private int? postalCode;
        public int? PostalCode
        {
            get => postalCode;
            set
            {
                postalCode = value;
                OnPropertyChanged(nameof(PostalCode));
            }
        }
        private string? country;
        public string? Country
        {
            get => country;
            set
            {
                country = value;
                OnPropertyChanged(nameof(Country));
            }
        }
        private string? region;
        public string? Region
        {
            get => region;
            set
            {
                region = value;
                OnPropertyChanged(nameof(Region));
            }
        }
        private string? area;
        public string? Area
        {
            get => area;
            set
            {
                area = value;
                OnPropertyChanged(nameof(Area));
            }
        }
        private string? city;
        public string? City
        {
            get => city;
            set
            {
                city = value;
                OnPropertyChanged(nameof(City));
            }
        }
        private string? street;
        public string? Street
        {
            get => street;
            set
            {
                street = value;
                OnPropertyChanged(nameof(Street));
            }
        }
        private int? home;
        public int? Home
        {
            get => home;
            set
            {
                home = value;
                OnPropertyChanged(nameof(Home));
            }
        }
        public int? department;
        public int? Department
        {
            get => department;
            set
            {
                department = value;
                OnPropertyChanged(nameof(Department));
            }
        }
        public event PropertyChangedEventHandler? PropertyChanged;
        public void OnPropertyChanged([CallerMemberName] string prop = "")
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
        }
    }
}
