using System;


using Weather.Observer;
using Weather.Observer.Factory;
using Weather.Observer.Interfaces;
using Weather.Observer.Singleton;



namespace Weather.Observer.Observers
{
    /// <summary>
    /// Observer that displays a weather forecast based on the current weather data.
    /// </summary>
    public class ForecastDisplay : IDisplay
    {
        private readonly WeatherData weatherData;

        public ForecastDisplay(WeatherData weatherData)
        {
            this.weatherData = weatherData;
            weatherData.RegisterObserver(this);
        }

        public void Display()
        {
            Console.WriteLine("Weather forecast...");
        }
    }
}
