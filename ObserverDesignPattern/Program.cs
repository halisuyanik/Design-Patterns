using ObserverDesignPattern.Concretes;
using System;

namespace ObserverDesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            WeatherData weatherData = new WeatherData();
            CurrentConditionsDisplay currentConditionDisplay = new CurrentConditionsDisplay();

            weatherData.RegisterObserver(currentConditionDisplay);
            weatherData.SetMeasurements(25, 5, 14);
            weatherData.SetMeasurements(18, 8, 11);
            weatherData.RemoveObserver(currentConditionDisplay);
            weatherData.SetMeasurements(13, 5, 7);
            Console.ReadKey();
        }
    }
}
