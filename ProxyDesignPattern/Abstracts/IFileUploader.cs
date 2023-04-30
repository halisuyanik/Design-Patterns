using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProxyDesignPattern.Abstracts
{
    public interface IFileUploader
    {
        void FileUpload(string filePath);
    }
}
