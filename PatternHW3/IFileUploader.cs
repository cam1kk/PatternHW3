using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace PatternHW3
{
    public interface IFileUploader
    {
        void UploadFile(string filePath);
    }

    public class GoogleDriveUploader : IFileUploader
    {
        public void UploadFile(string filePath)
        {
            MessageBox.Show($"Uploading {filePath} to Google Drive...");
            MessageBox.Show($"File {filePath} uploaded successfully to Google Drive.");
        }
    }

    public class DropboxUploaderDecorator : IFileUploader
    {
        private readonly IFileUploader _fileUploader;

        public DropboxUploaderDecorator(IFileUploader fileUploader)
        {
            _fileUploader = fileUploader;
        }

        public void UploadFile(string filePath)
        {
            MessageBox.Show($"Uploading {filePath} to Dropbox...");
            MessageBox.Show($"File {filePath} uploaded successfully to Dropbox.");
        }
    }
}
