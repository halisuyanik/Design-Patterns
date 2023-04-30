using ProxyDesignPattern.Abstracts;
using ProxyDesignPattern.Concretes;
using System;

namespace ProxyDesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var realFileUploader =new RealFileUploader();
            var fileUploaderProxy = new FileUploaderProxy(realFileUploader);
            fileUploaderProxy.FileUpload("desktop");
            fileUploaderProxy.FileUpload("desktop");
            fileUploaderProxy.FileUpload("desktop");
        }
    }
}
