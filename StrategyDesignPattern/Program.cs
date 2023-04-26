using StrategyDesignPattern.Abstracts;
using StrategyDesignPattern.Concretes;
using System;

namespace StrategyDesignPattern
{
    class Program
    {
        static void Main(string[] args)
        { 
            Console.WriteLine("Enter the data you want to encrypt");
            var enterData = Console.ReadLine();
            Console.WriteLine("Enter the vehicle you want to encrypt 1:AES 2:BlowFish");
            var enterTool = Console.ReadLine();
            IEncryptionStrategy encryptionStrategy= null;
            DataEncryptor dataEncryptor = new DataEncryptor();
            switch (enterTool)
            {
                case "1":
                    encryptionStrategy = new AESEncryptionStrategy();
                    break;
                case "2":
                    encryptionStrategy = new BlowFishEncryptionStrategy();
                    break;
                default:
                    Console.WriteLine("cannot choose strategy");
                    break;
            }
            dataEncryptor.SetEncryptionTool(encryptionStrategy);
            dataEncryptor.EnterWithData(enterData);
        }
    }
}
