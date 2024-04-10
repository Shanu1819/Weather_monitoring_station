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
        private string forecast;

        public ForecastDisplay(WeatherData weatherData)
        {
            this.weatherData = weatherData;
            weatherData.RegisterObserver(this);
        }

       
        /// Update the weather forecast based on the current weather data.
   
        public void UpdateForecast()
        {
            float temperature = weatherData.GetTemperature();
            
            
            if (temperature > 30)
            {
                forecast = "Hot and Sunny";
            }
            else if (temperature < 10)
            {
                forecast = "Cold and Cloudy";
            }
            else
            {
                forecast = "Weather is Good";
            }
        }


        /// Display the weather forecast.
        
        public void Display()
        {
            UpdateForecast();
            Console.WriteLine("Weather Forecast: " + forecast);
        }


       
    }
}
