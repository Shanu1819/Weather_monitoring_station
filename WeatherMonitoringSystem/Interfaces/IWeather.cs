namespace WeatherMonitoringSystem.Interfaces
{
    public interface IWeather
    {
        void RegisterObserver(IDisplay observer);
        void RemoveObserver(IDisplay observer);
        void NotifyObservers();
        void SetMeasurements(float temperature, float humidity, float pressure);
    }
}
