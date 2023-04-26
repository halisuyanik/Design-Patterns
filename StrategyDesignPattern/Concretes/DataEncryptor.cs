using StrategyDesignPattern.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyDesignPattern.Concretes
{
    public class DataEncryptor
    {
        private IEncryptionStrategy _encryptionStrategy;

        public DataEncryptor()
        {

        }

        public DataEncryptor(IEncryptionStrategy encryptionStrategy)
        {
            _encryptionStrategy = encryptionStrategy;
        }

        public void SetEncryptionTool(IEncryptionStrategy encryptionStrategy)
        {
            _encryptionStrategy = encryptionStrategy;
        }

        public bool EnterWithData(string data)
        {
            return _encryptionStrategy.EncrypData(data);
        }
    }
}
