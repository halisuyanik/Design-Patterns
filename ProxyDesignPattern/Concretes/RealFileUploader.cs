using ProxyDesignPattern.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProxyDesignPattern.Concretes
{
    public class RealFileUploader : IFileUploader
    {
        public void FileUpload(string filePath)
        {
            Console.WriteLine($"File {filePath} uploaded.");
        }
    }
}
