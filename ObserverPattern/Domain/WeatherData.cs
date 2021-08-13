using System;
using System.Collections.Generic;
using ObserverPattern.Domain.Contract;

namespace ObserverPattern.Domain
{
    public class WeatherData : ISubject
    {
        private float Temperature { get; set; }
        private float Humidity { get; set; }
        private float Pressure { get; set; }

        private List<IObserver> Observers { get; set; } = new();

        public void RegisterObserver(IObserver observer)
        {
            Observers.Add(observer);
        }

        public void RemoveObserver(IObserver observer)
        {
            Console.WriteLine(Observers.Remove(observer)
                ? "Observer successfully removed"
                : "Requested observer hasn't been registered");
        }

        public void NotifyObservers()
        {
            foreach (var observer in Observers)
            {
                observer.Update(Temperature, Humidity, Pressure);
            }
        }

        private void MeasurementsChanged()
        {
            NotifyObservers();
        }

        public void SetMeasurements(float temperature, float humidity, float pressure)
        {
            Temperature = temperature;
            Humidity = humidity;
            Pressure = pressure;
            MeasurementsChanged();
        }
    }
}