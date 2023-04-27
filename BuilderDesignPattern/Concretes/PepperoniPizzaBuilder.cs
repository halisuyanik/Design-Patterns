using BuilderDesignPattern.Abstracts;
using BuilderDesignPattern.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderDesignPattern.Concretes
{
    public class PepperoniPizzaBuilder : IPizzaBuilder
    {
        private Pizza _pizza = new Pizza();
        public void BuildDough()
        {
            _pizza.Dough = "this crust";
        }

        public void BuildSauce()
        {
            _pizza.Sauce = "tomato sauce";
        }

        public void BuildTopping()
        {
            _pizza.Topping = "pepperoni";
        }

        public Pizza GetPizza()
        {
            return _pizza;
        }
    }
}
