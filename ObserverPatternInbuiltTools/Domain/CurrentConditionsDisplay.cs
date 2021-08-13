using System;

namespace ObserverPatternInbuiltTools.Domain
{
    public class CurrentConditionsDisplay : IObserver<WeatherData>
    {
        private IDisposable _unsubscriber;
        
        private float Temperature { get; set; }
        private float Humidity { get; set; }

        public virtual void Subscribe(IObservable<WeatherData> provider)
        {
            if (provider != null)
                _unsubscriber = provider.Subscribe(this);
        }

        public void OnCompleted()
        {
            Console.WriteLine("The Weather Data Tracker has completed transmitting data to this display/");
            this.Unsubscribe();
        }

        public void OnError(System.Exception error)
        {
            Console.WriteLine("The weather data cannot be determined.");
        }

        public void OnNext(WeatherData value)
        {
            Console.WriteLine($"Current conditions: temperature - {Temperature} degrees F, humidity - {Humidity} %.");
        }
        
        public virtual void Unsubscribe()
        {
            _unsubscriber.Dispose();
        }
    }
}