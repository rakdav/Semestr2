using System.Drawing;
using System.IO;
using System.Windows;


namespace OSLab1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private CancellationTokenSource _cancelToken = new CancellationTokenSource();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void cmdCancel_Click(object sender, RoutedEventArgs e)
        {
            _cancelToken.Cancel();
        }

        private void cmdProcess_Click(object sender, RoutedEventArgs e)
        {
            Task.Factory.StartNew(()=> ProcessFiles());
            this.Title = "Processing Complete";
        }
        private void ProcessFiles()
        {
            ParallelOptions parOpts= new ParallelOptions();
            parOpts.CancellationToken=_cancelToken.Token;
            parOpts.MaxDegreeOfParallelism=Environment.ProcessorCount;
            var bathPath = Directory.GetCurrentDirectory();
            var pictureDirectory = Path.Combine(bathPath, "TestPictures");
            var outputDirectory = Path.Combine(bathPath, "ModifiedPictures");
            if(Directory.Exists(outputDirectory)) Directory.Delete(outputDirectory, true);
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
                    Dispatcher?.Invoke(() =>
                    {
                        this.Title = $"Процесс {file}";
                    });
                    using (Bitmap bitmap = new Bitmap(file))
                    {
                        bitmap.RotateFlip(RotateFlipType.Rotate180FlipNone);
                        bitmap.Save(Path.Combine(outputDirectory, filename));
                    }
                });
                Dispatcher?.Invoke(() => { this.Title = "Завершено!"; });
            }
            catch (OperationCanceledException ex)
            {
                Dispatcher?.Invoke(() => { this.Title = ex.Message; });
            }
        }
    }
}