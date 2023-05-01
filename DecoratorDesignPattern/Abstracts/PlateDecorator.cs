using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorDesignPattern.Abstracts
{
    public abstract class PlateDecorator : IPlate
    {
        protected IPlate _plate;
        public PlateDecorator(IPlate plate)
        {
            _plate = plate;
        }
        public virtual void Decorate()
        {
            _plate.Decorate();
        }
    }
}
