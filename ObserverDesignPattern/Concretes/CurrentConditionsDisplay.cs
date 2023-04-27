using ObserverDesignPattern.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverDesignPattern.Concretes
{
    public class CurrentConditionsDisplay : IObserver
    {
        private float temperature;
        private float humidity;
        public void Update(float temperature, float humidity, float pressure)
        {
            this.temperature = temperature;
            this.humidity = humidity;
            Display();
        }

        private void Display()
        {
            Console.WriteLine("Current conditions:" + temperature + "C degress and " + humidity + "% humidity");
        }
    }
}
