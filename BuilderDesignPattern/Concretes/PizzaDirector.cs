using BuilderDesignPattern.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderDesignPattern.Concretes
{
    public class PizzaDirector
    {
        private IPizzaBuilder _pizzaBuilder;

        public PizzaDirector(IPizzaBuilder pizzaBuilder)
        {
            _pizzaBuilder = pizzaBuilder;
        }
        public void MakePizza()
        {
            _pizzaBuilder.BuildDough();
            _pizzaBuilder.BuildSauce();
            _pizzaBuilder.BuildTopping();
        }
    }
}
