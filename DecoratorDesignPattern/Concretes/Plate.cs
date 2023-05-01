using DecoratorDesignPattern.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorDesignPattern.Concretes
{
    public class Plate : IPlate
    {
        public void Decorate()
        {
            Console.WriteLine("A plain plate.");
        }
    }
}
