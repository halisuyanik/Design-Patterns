using ProxyDesignPattern.Abstracts;
using ProxyDesignPattern.Concretes;
using System;

namespace ProxyDesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var fileUploaderProxy = new FileUploaderProxy(new RealFileUploader());
            fileUploaderProxy.FileUpload("desktop");
            fileUploaderProxy.FileUpload("desktop");
            fileUploaderProxy.FileUpload("desktop");
        }
    }
}
