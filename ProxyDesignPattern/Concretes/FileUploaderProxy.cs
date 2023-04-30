using ProxyDesignPattern.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProxyDesignPattern.Concretes
{
    public class FileUploaderProxy : IFileUploader
    {
        private IFileUploader _fileUploader;
        private List<string> _uploadedFiles = new List<string>();
        public FileUploaderProxy(IFileUploader fileUploader)
        {
            _fileUploader = fileUploader;
        }
        public void FileUpload(string filePath)
        {
            if (_uploadedFiles.Contains(filePath))
            {
                Console.WriteLine($"File {filePath} has already been uploaded.");
                return;
            }
            Console.WriteLine($"File {filePath} upload...");
            _fileUploader.FileUpload(filePath);
            _uploadedFiles.Add(filePath);
        }
    }
}
