namespace ObserverPattern.Domain.Contract
{
    public interface IObserver
    {
        public void Update(float temperature, float humidity, float pressure);
    }
}