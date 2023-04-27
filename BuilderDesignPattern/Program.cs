using BuilderDesignPattern.Concretes;
using System;

namespace BuilderDesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var builder = new PepperoniPizzaBuilder();
            var director = new PizzaDirector(builder);

            director.MakePizza();

            var pizza = builder.GetPizza();

            Console.WriteLine($"Dough: {pizza.Dough}");
            Console.WriteLine($"Sauce: {pizza.Sauce}");
            Console.WriteLine($"Topping: {pizza.Topping}");
        }
    }
}
