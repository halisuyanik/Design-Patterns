using StrategyDesignPattern.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyDesignPattern.Concretes
{
    public class BlowFishEncryptionStrategy : IEncryptionStrategy
    {
        public bool EncrypData(string data)
        {
            Console.WriteLine("Data is encrypted with Blowfish " + data);
            return true;
        }
    }
}
