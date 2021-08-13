using System;
using ObserverPattern.Domain.Contract;

namespace ObserverPattern.Domain
{
    public class ForecastDisplay : IObserver, IDisplay
    {
        private float Pressure { get; set; }
        private float PressureShift { get; set; }
        private ISubject WeatherData { get; set; }
        
        public ForecastDisplay(ISubject weatherData)
        {
            WeatherData = weatherData;
            WeatherData.RegisterObserver(this);
        }
        
        public void Display()
        {
            switch (PressureShift)
            {
                case > 0:
                    Console.WriteLine("It seems to be getting worse :(");
                    break;
                case < 0:
                    Console.WriteLine("Yay, it's improving!");
                    break;
                case 0:
                    Console.WriteLine("Same old");
                    break;
            }
        }

        public void Update(float temperature, float humidity, float pressure)
        {
            if (Pressure != 0) PressureShift = Pressure - pressure;
            
            Pressure = pressure;
            Display();
        }
    }
}