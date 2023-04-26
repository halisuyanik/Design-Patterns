using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyDesignPattern.Abstracts
{
    public interface IEncryptionStrategy
    {
        bool EncrypData(string data);
    }
}
