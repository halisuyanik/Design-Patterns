using DecoratorDesignPattern.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorDesignPattern.Concretes
{
    public class PatternedPlate:PlateDecorator
    {
        public PatternedPlate(IPlate plate):base(plate)
        {

        }
        public override void Decorate()
        {
            base.Decorate();
            Console.WriteLine("Patterned plate.");
        }
    }
}
