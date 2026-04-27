using Lab13WPF.Command;
using Lab13WPF.Model;
using Lab13WPF.View;
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

namespace Lab13WPF.ViewModel
{
    public class MainViewModel:INotifyPropertyChanged
    {
        private Visibility _expandVisible;
        public Visibility ExpandVisible
        {
            get => _expandVisible;
            set
            {
                _expandVisible = value;
                OnPropertyChanged(nameof(ExpandVisible));
            }
        }
        private string searchText;
        public string SearchText
        {
            get => searchText!;
            set
            {
                searchText = value;
                OnPropertyChanged(nameof(SearchText));
            }
        }

        private AutoOwner selectedOwner;
        public AutoOwner SelectedOwner
        {
            get => selectedOwner!;
            set
            {
                selectedOwner = value;
                if (selectedOwner != null)
                {
                    ExpandVisible = Visibility.Visible;
                }
                OnPropertyChanged(nameof(SelectedOwner));
            }
        }

        private ObservableCollection<AutoOwner>? autoOwners;
        public ObservableCollection<AutoOwner> AutoOwners
        {
            get { return autoOwners!; }
            set
            {
                if (autoOwners != value)
                {
                    autoOwners = value;
                    OnPropertyChanged(nameof(AutoOwners));
                }
            }
        }
        public ObservableCollection<AutoOwner>? AutoOwnersAll { get; set; } = new();

        public MainViewModel()
        {
           AutoOwners=new ObservableCollection<AutoOwner>();
           ExpandVisible =Visibility.Hidden;
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
                    saveDialog.Filter = "Data files(*.dat)|*.dat|(All Files(*.*))|*.*";
                    if (saveDialog.ShowDialog() == true)
                    {
                        string Filepath=saveDialog.FileName;
                        using (BinaryWriter writer=new BinaryWriter(File.Open(Filepath,FileMode.OpenOrCreate)))
                        {
                           foreach(AutoOwner item in AutoOwners)
                            {
                                writer.Write(item.FIO);
                                writer.Write(item.Phone);

                                writer.Write(item.Address.PostalCode??0);
                                writer.Write(item.Address.Country!);
                                writer.Write(item.Address.Region!);
                                writer.Write(item.Address.Area!);
                                writer.Write(item.Address.City!);
                                writer.Write(item.Address.Street!);
                                writer.Write(item.Address.Home??0);
                                writer.Write(item.Address.Department??0);

                                writer.Write(item.Marka);
                                writer.Write(item.Number);
                                writer.Write(item.TechPassport);
                            }
                            MessageBox.Show("Данные успешно сохранены!");
                        }
                    }
                }));
            }
        }
        private RelayCommand openCommand;
        public RelayCommand OpenCommand
        {
            get
            {
                return openCommand ?? (openCommand = new RelayCommand(async obj =>
                {
                    OpenFileDialog openDialog = new OpenFileDialog();
                    openDialog.Filter = "Data files(*.dat)|*.dat|(All Files(*.*))|*.*";
                    if (openDialog.ShowDialog() == true)
                    {
                        string Filepath = openDialog.FileName;
                        using (BinaryReader reader=new BinaryReader(File.Open(Filepath, FileMode.Open)))
                        {
                            try
                            {
                                while (reader.PeekChar() > -1)
                                {
                                    string fio = reader.ReadString();
                                    string phone = reader.ReadString();

                                    int postalCode = reader.ReadInt32();
                                    string country = reader.ReadString();
                                    string region = reader.ReadString();
                                    string area = reader.ReadString();
                                    string city = reader.ReadString();
                                    string street = reader.ReadString();
                                    int home = reader.ReadInt32();
                                    int department = reader.ReadInt32();

                                    string marka = reader.ReadString();
                                    string number = reader.ReadString();
                                    string techPassport = reader.ReadString();
                                    HomeAddress homeAddress = new HomeAddress()
                                    {
                                        Area = area,
                                        City = city,
                                        Home = home,
                                        Department = department,
                                        Street = street,
                                        PostalCode = postalCode,
                                        Country = country,
                                        Region = region
                                    };
                                    AutoOwner autoOwner = new AutoOwner()
                                    {
                                        FIO = fio,
                                        Phone = phone,
                                        Address = homeAddress,
                                        Marka = marka,
                                        Number = number,
                                        TechPassport = techPassport
                                    };
                                    AutoOwners.Add(autoOwner);
                                    AutoOwnersAll!.Add(autoOwner);
                                }
                            }
                            catch (IOException ex) { }
                        }
                    }
                }));
            }
        }
        private RelayCommand searchCommand;
        public RelayCommand SearchCommand
        {
            get
            {
                return searchCommand ?? (searchCommand = new RelayCommand(obj =>
                {
                    if (String.IsNullOrEmpty(SearchText))
                    {
                        AutoOwners = new ObservableCollection<AutoOwner>(AutoOwnersAll!);
                    }
                    else
                    {
                        AutoOwners =new ObservableCollection<AutoOwner> (AutoOwners!.Where(p => p.Marka.StartsWith(SearchText)).ToList());
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
