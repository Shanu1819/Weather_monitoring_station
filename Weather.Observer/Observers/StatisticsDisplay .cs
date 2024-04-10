using System;




using Weather.Observer;
using Weather.Observer.Factory;
using Weather.Observer.Interfaces;
using Weather.Observer.Singleton;

namespace Weather.Observer.Observers
{
    /// <summary>
    /// Observer that displays weather statistics (like average, max, and min temperatures).
    /// </summary>
    public class StatisticsDisplay : IDisplay
    {
        private readonly WeatherData weatherData;

        public StatisticsDisplay(WeatherData weatherData)
        {
            this.weatherData = weatherData;
            weatherData.RegisterObserver(this);
        }

        public void Display()
        {
            Console.WriteLine("Weather statistics: Average, Max, Min temperatures...");
        }
    }
}
