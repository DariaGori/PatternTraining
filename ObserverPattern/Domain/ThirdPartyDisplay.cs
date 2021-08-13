using System;
using ObserverPattern.Domain.Contract;

namespace ObserverPattern.Domain
{
    public class ThirdPartyDisplay : IObserver, IDisplay
    {
        private float Temperature { get; set; }
        private float Humidity { get; set; }
        private float Pressure { get; set; }
        private ISubject WeatherData { get; set; }
        
        public ThirdPartyDisplay(ISubject weatherData)
        {
            WeatherData = weatherData;
            WeatherData.RegisterObserver(this);
        }
        
        public void Display()
        {
            Console.WriteLine("Got the data, have no clue what to do with it though...");
        }

        public void Update(float temperature, float humidity, float pressure)
        {
            Temperature = temperature;
            Pressure = pressure;
            Humidity = humidity;
            Display();
        }
    }
}