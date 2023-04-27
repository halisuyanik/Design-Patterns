using BuilderDesignPattern.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderDesignPattern.Abstracts
{
    public interface IPizzaBuilder
    {
        void BuildDough();
        void BuildSauce();
        void BuildTopping();
        Pizza GetPizza();
    }
}
