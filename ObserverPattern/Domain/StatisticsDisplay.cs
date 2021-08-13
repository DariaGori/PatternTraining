using System;
using System.Collections.Generic;
using System.Linq;
using ObserverPattern.Domain.Contract;

namespace ObserverPattern.Domain
{
    public class StatisticsDisplay : IObserver, IDisplay
    {
        private List<float> TemperatureStats { get; set; } = new();
        private ISubject WeatherData { get; set; }
        
        public StatisticsDisplay(ISubject weatherData)
        {
            WeatherData = weatherData;
            WeatherData.RegisterObserver(this);
        }
        
        public void Display()
        {
            var maxTemp = TemperatureStats.Max();
            var minTemp = TemperatureStats.Min();
            var averageTemp = TemperatureStats.Average();
            
            Console.WriteLine($"Avg/Max/Min temperature = {averageTemp}/{maxTemp}/{minTemp}");
        }

        public void Update(float temperature, float humidity, float pressure)
        {
            TemperatureStats.Add(temperature);
            Display();
        }
    }
}