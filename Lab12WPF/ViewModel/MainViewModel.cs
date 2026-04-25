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
        public bool expandVisible= false;
        public bool ExpandVisible
        {
            get => expandVisible!;
            set
            {
                expandVisible = value;
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
           ExpandVisible =false;
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
                        using (StreamWriter writer=new StreamWriter(Filepath,false))
                        {
                            foreach(AutoOwner owner in AutoOwners!)
                            writer.WriteLineAsync(owner!.ToString());
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
                    if (openDialog.ShowDialog() == true)
                    {
                        string Filepath = openDialog.FileName;
                        using (StreamReader reader=new StreamReader(Filepath))
                        {
                            string? line;
                            while((line=await reader.ReadLineAsync())!=null)
                            {
                                string[] mas=line.Split(',');
                                AutoOwner owner=new AutoOwner();
                                owner.FIO = mas[0];
                                owner.Phone = mas[1];
                                owner.Address.PostalCode = int.Parse(mas[2]);
                                owner.Address.Country = mas[3];
                                owner.Address.Region=mas[4];
                                owner.Address.City=mas[5];
                                owner.Address.Area = mas[6];
                                owner.Address.Street=mas[7];
                                owner.Address.Home = int.Parse(mas[8]);
                                owner.Address.Department=int.Parse(mas[9]);
                                owner.Marka = mas[10];
                                owner.Number = mas[11];
                                owner.TechPassport = mas[12];
                                AutoOwners!.Add(owner);
                                AutoOwnersAll!.Add(owner);
                            }
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
