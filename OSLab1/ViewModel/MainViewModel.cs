using OSLab1.Command;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Threading;

namespace OSLab1.ViewModel
{
    public class MainViewModel
    {
        private CancellationTokenSource _cancelToken = new CancellationTokenSource();
        public MainWindow? MainWindow {  get; set; }
        public MainViewModel(MainWindow _mainWindow) 
        {
            MainWindow = _mainWindow;
        }
        #region Commands
        private RelayCommand processCommand;
        public RelayCommand ProcessCommand
        {
            get
            {
                return processCommand ?? (processCommand = new RelayCommand(obj =>
                {
                    Task.Factory.StartNew(() => ProcessFiles());
                }));
            }
        }
        private RelayCommand cancelCommand;
        public RelayCommand CancelCommand
        {
            get
            {
                return cancelCommand ?? (cancelCommand = new RelayCommand(obj =>
                {
                    _cancelToken.Cancel();
                }));
            }
        }
        #endregion
        #region Fuctions
        private void ProcessFiles()
        {
            ParallelOptions parOpts = new ParallelOptions();
            parOpts.CancellationToken = _cancelToken.Token;
            parOpts.MaxDegreeOfParallelism = Environment.ProcessorCount;
            var bathPath = Directory.GetCurrentDirectory();
            var pictureDirectory = Path.Combine(bathPath, "TestPictures");
            var outputDirectory = Path.Combine(bathPath, "ModifiedPictures");
            if (Directory.Exists(outputDirectory)) Directory.Delete(outputDirectory, true);
            Directory.CreateDirectory(outputDirectory);
            string[] files = Directory.GetFiles(pictureDirectory, "*.jpg", SearchOption.AllDirectories);
            //foreach (string file in files)
            try
            {
                Parallel.ForEach(files, file =>
                {
                    parOpts.CancellationToken.ThrowIfCancellationRequested();
                    string filename = Path.GetFileName(file);
                    //this.Title = $"Процесс {filename} в потоке {Thread.CurrentThread.ManagedThreadId}";
                    MainWindow!.Dispatcher?.Invoke(() =>
                    {
                        MainWindow.Title = $"Процесс {file}";
                    });
                    using (Bitmap bitmap = new Bitmap(file))
                    {
                        bitmap.RotateFlip(RotateFlipType.Rotate180FlipNone);
                        bitmap.Save(Path.Combine(outputDirectory, filename));
                    }
                });
                MainWindow!.Dispatcher?.Invoke(() => { MainWindow.Title = "Завершено!"; });
            }
            catch (OperationCanceledException ex)
            {
                MainWindow!.Dispatcher?.Invoke(() => { MainWindow.Title = ex.Message; });
            }
        }
        #endregion
    }
}
