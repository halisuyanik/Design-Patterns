using DecoratorDesignPattern.Abstracts;
using DecoratorDesignPattern.Concretes;
using System;

namespace DecoratorDesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            IPlate plate = new Plate();
            plate = new PatternedPlate(plate);
            plate = new PaintedPlate(plate);
            plate.Decorate();
        }
    }
}
