using System;
using ObserverPattern.Domain.Contract;

namespace ObserverPattern.Domain
{
    public class CurrentConditionsDisplay : IObserver, IDisplay
    {
        private float Temperature { get; set; }
        private float Humidity { get; set; }
        private ISubject WeatherData { get; set; }

        public CurrentConditionsDisplay(ISubject weatherData)
        {
            WeatherData = weatherData;
            WeatherData.RegisterObserver(this);
        }
        
        public void Display()
        {
            Console.WriteLine($"Current conditions: temperature - {Temperature} degrees F, humidity - {Humidity} %.");
        }

        public void Update(float temperature, float humidity, float pressure)
        {
            Temperature = temperature;
            Humidity = humidity;
            Display();
        }
    }
}