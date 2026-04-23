using Lab12WPF.Command;
using Lab12WPF.Model;
using Lab12WPF.View;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Lab12WPF.ViewModel
{
    public class MainViewModel:INotifyPropertyChanged
    {
        private AutoOwner? selectedOwner;
        public AutoOwner SelectedOwner
        {
            get => selectedOwner!;
            set
            {
                selectedOwner = value;
                OnPropertyChanged(nameof(SelectedOwner));
            }
        }
        public ObservableCollection<AutoOwner>? AutoOwners { get; set; }

        public MainViewModel()
        {
            AutoOwners = new ObservableCollection<AutoOwner>()
            {
                new AutoOwner()
                {
                    FIO="Никитин Никитос Никитич",
                    Marka="Мерседес",
                    Phone="+79557854387",
                    Number="в567ru39",
                    TechPassport="ту678a",
                    Address=new HomeAddress()
                    {
                        PostalCode=896756,
                        City="Москва",
                        Area="город Москва",
                        Department=4,
                        Country="Россия",
                        Home=12,
                        Region="Москвовская область",
                        Street="Моховая"
                    }
                },
                 new AutoOwner()
                {
                    FIO="Игого",
                    Marka="Лошадь",
                    Phone="+79557854387",
                    Number="в567ru39",
                    TechPassport="ту678a",
                    Address=new HomeAddress()
                    {
                        PostalCode=896756,
                        City="Москва",
                        Area="город Москва",
                        Department=4,
                        Country="Россия",
                        Home=12,
                        Region="Москвовская область",
                        Street="Моховая"
                    }
                }
            };

            Load();
        }
        private async void Load()
        {

        }
        #region Commands
        private RelayCommand addCommand;
        public RelayCommand AddCommand
        {
            get
            {
                return addCommand ?? (addCommand = new RelayCommand(obj =>
                {
                    AutoOwnerWindow window=new AutoOwnerWindow();
                    window.Show();
                }));
            }
        }
        #endregion
        public event PropertyChangedEventHandler? PropertyChanged;
        public void OnPropertyChanged([CallerMemberName] string prop = "")
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
        }
    }
}
