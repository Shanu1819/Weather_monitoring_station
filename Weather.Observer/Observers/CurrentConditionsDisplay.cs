using System;

using Weather.Observer;
using Weather.Observer.Factory;
using Weather.Observer.Interfaces;
using Weather.Observer.Singleton;


namespace Weather.Observer.Observers
{
    /// <summary>
    /// Observer and Decorator that displays the current weather conditions.
    /// </summary>
    public class CurrentConditionsDisplay : IDisplay
    {
        private readonly WeatherData weatherData;

        public CurrentConditionsDisplay(WeatherData weatherData)
        {
            this.weatherData = weatherData;
            weatherData.RegisterObserver(this);
        }

        public void Display()
        {
            Console.WriteLine("Current conditions: Temperature - " + weatherData.GetTemperature() +
                              "F degrees and Humidity - " + weatherData.GetHumidity() + "%");
        }
    }
}
