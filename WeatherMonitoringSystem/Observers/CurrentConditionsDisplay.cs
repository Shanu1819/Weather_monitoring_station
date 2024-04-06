using System;
using WeatherMonitoringSystem.Interfaces;

namespace WeatherMonitoringSystem.Observers
{
    public class CurrentConditionsDisplay : IDisplay
    {
        rivate readonly IWeatherData weatherData;
        private string additionalInfo; // Additional information like date and time

        public CurrentConditionsDisplay(IWeatherData weatherData)
        {
            this.weatherData = weatherData;
            weatherData.RegisterObserver(this);
        }

        public void Display()
        {
            Console.WriteLine("Current conditions: Temperature - " + weatherData.GetTemperature() +
                              "F degrees and Humidity - " + weatherData.GetHumidity() + "%" +
                              (string.IsNullOrEmpty(additionalInfo) ? "" : " | " + additionalInfo));
        }

        // Decorator method to add additional information
        public void AddAdditionalInfo(string info)
        {
            additionalInfo = info;
        }
    }
}
