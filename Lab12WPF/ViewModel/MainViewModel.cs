using Lab12WPF.Command;
using Lab12WPF.Model;
using Lab12WPF.View;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

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
        public ObservableCollection<AutoOwner>? AutoOwners { get; set; }= new();

        public MainViewModel()
        {
            //AutoOwners = new ObservableCollection<AutoOwner>()
            //{
            //    new AutoOwner()
            //    {
            //        FIO="Никитин Никитос Никитич",
            //        Marka="Мерседес",
            //        Phone="+79557854387",
            //        Number="в567ru39",
            //        TechPassport="ту678a",
            //        Address=new HomeAddress()
            //        {
            //            PostalCode=896756,
            //            City="Москва",
            //            Area="город Москва",
            //            Department=4,
            //            Country="Россия",
            //            Home=12,
            //            Region="Москвовская область",
            //            Street="Моховая"
            //        }
            //    },
            //     new AutoOwner()
            //    {
            //        FIO="Игого",
            //        Marka="Лошадь",
            //        Phone="+79557854387",
            //        Number="в567ru39",
            //        TechPassport="ту678a",
            //        Address=new HomeAddress()
            //        {
            //            PostalCode=896756,
            //            City="Москва",
            //            Area="город Москва",
            //            Department=4,
            //            Country="Россия",
            //            Home=12,
            //            Region="Москвовская область",
            //            Street="Моховая"
            //        }
            //    }
            //};
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
                    AutoOwnerWindow window=new AutoOwnerWindow(new AutoOwner());
                    if (window.ShowDialog() == true)
                    {
                        AutoOwner newAutoOwner=window.AutoOwner;
                        
                        AutoOwners!.Add(newAutoOwner);
                    }
                }));
            }
        }
        private RelayCommand editCommand;
        public RelayCommand EditCommand
        {
            get
            {
                return editCommand ?? (editCommand = new RelayCommand(obj =>
                {
                    AutoOwner? owner=obj as AutoOwner;
                    if(owner != null)
                    {
                        AutoOwnerWindow window = new AutoOwnerWindow(owner);
                        if (window.ShowDialog() == true)
                        {
                            int index = AutoOwners!.IndexOf(owner);
                            AutoOwners[index]= window.AutoOwner;
                        }
                    }
                }));
            }
        }
        private RelayCommand deleteCommand;
        public RelayCommand DeleteCommand
        {
            get
            {
                return deleteCommand ?? (deleteCommand = new RelayCommand(obj =>
                {
                    AutoOwner? owner = obj as AutoOwner;
                    if (owner != null)
                    {
                        if (MessageBox.Show("Вы действительно хотите удалить?","Внимание",MessageBoxButton.YesNo,
                            MessageBoxImage.Warning) == MessageBoxResult.Yes)
                        {
                            AutoOwners!.Remove(owner);
                        }
                    }
                }));
            }
        }
        private RelayCommand saveCommand;
        public RelayCommand SaveCommand
        {
            get
            {
                return saveCommand ?? (saveCommand = new RelayCommand(obj =>
                {
                    SaveFileDialog saveDialog = new SaveFileDialog();
                    if (saveDialog.ShowDialog() == true)
                    {
                        string Filepath=saveDialog.FileName;
                        using (StreamWriter writer=new StreamWriter(Filepath,true))
                        {
                            foreach(AutoOwner owner in AutoOwners!)
                            writer.WriteLineAsync(owner!.ToString());
                        }
                    }
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
