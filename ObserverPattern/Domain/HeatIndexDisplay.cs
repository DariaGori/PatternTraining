using System;
using System.Collections.Generic;
using ObserverPattern.Domain.Contract;

namespace ObserverPattern.Domain
{
    public class HeatIndexDisplay : IObserver, IDisplay
    {
        private float Temperature { get; set; }
        private float Humidity { get; set; }
        private ISubject WeatherData { get; set; }
        
        public HeatIndexDisplay(ISubject weatherData)
        {
            WeatherData = weatherData;
            WeatherData.RegisterObserver(this);
        }
        
        public void Update(float temperature, float humidity, float pressure)
        {
            Temperature = temperature;
            Humidity = humidity;
            Display();
        }

        public void Display()
        {
            var heatIndex = 16.923 + 1.85212 * Math.Pow(10, -1) * Temperature + 5.37941 * Humidity - 1.00254
                            * Math.Pow(10, -1) * Temperature *
                            Humidity + 9.41695 * Math.Pow(10, -3) * Math.Pow(Temperature, 2)
                                     + 7.28898 * Math.Pow(10, -3) * Math.Pow(Humidity, 2)
                                     + 3.45372 * Math.Pow(10, -4) * Math.Pow(Temperature, 2)
                                     * Humidity - 8.14971 * Math.Pow(10, -4) * Temperature
                            * Math.Pow(Humidity, 2) + 1.02102 * Math.Pow(10, -5) * Math.Pow(Temperature, 2) *
                            Math.Pow(Humidity, 2)
                            - 3.8646 * Math.Pow(10, -5) * Math.Pow(Temperature, 3) + 2.91583 * Math.Pow(10, -5)
                            * Math.Pow(Humidity, 3) + 1.42721 * Math.Pow(10, -6) * Math.Pow(Temperature, 3) * Humidity
                            + 1.97483 * Math.Pow(10, -7) * Temperature * Math.Pow(Humidity, 3) - 2.18429 *
                            Math.Pow(10, -8)
                            * Math.Pow(Temperature, 3) * Math.Pow(Humidity, 2) + 8.43296 * Math.Pow(10, -10) *
                            Math.Pow(Temperature, 2)
                            * Math.Pow(Humidity, 3) -
                            4.81975 * Math.Pow(10, -11) * Math.Pow(Temperature, 3) * Math.Pow(Humidity, 3);
            
            Console.WriteLine($"Heat index is {heatIndex}");
        }
    }
}