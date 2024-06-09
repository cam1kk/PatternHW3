using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace PatternHW3
{
    public partial class MainWindow : Window
    {
        private IFileUploader _fileUploader;

        public MainWindow()
        {
            InitializeComponent();
            _fileUploader = new GoogleDriveUploader();
        }

        private void UploadFileButton_Click(object sender, RoutedEventArgs e)
        {
            string filePath = @"C:\example.txt";
            _fileUploader.UploadFile(filePath);
        }

        private void UseDropboxCheckbox_Checked(object sender, RoutedEventArgs e)
        {
            if (useDropboxCheckbox.IsChecked == true)
            {
                _fileUploader = new DropboxUploaderDecorator(_fileUploader);
            }
            else
            {
                _fileUploader = new GoogleDriveUploader();
            }
        }
    }
}