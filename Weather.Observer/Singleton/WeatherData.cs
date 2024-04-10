using System;
using System.Collections.Generic;
using Weather.Observer;
using Weather.Observer.Factory;
using Weather.Observer.Interfaces;


namespace Weather.Observer.Singleton
{
    /// <summary>
    /// Singleton class responsible for collecting weather data and notifying observers.
    /// </summary>
    public sealed class WeatherData
    {
        private static WeatherData instance;
        private List<IDisplay> observers = new List<IDisplay>();
        private float temperature;
        private float humidity;
        private float pressure;
        private readonly Random random = new Random();

        // Private constructor to prevent direct instantiation
        private WeatherData() { }

        // Singleton instance accessor
        public static WeatherData GetInstance()
        {
            if (instance == null)
            {
                instance = new WeatherData();
            }
            return instance;
        }

        // Register an observer
        public void RegisterObserver(IDisplay observer)
        {
            observers.Add(observer);
        }

        // Remove an observer
        public void RemoveObserver(IDisplay observer)
        {
            observers.Remove(observer);
        }

        // Notify all observers when data changes
        private void NotifyObservers()
        {
            foreach (IDisplay observer in observers)
            {
                observer.Display();
            }
        }

        // Simulate weather data change
        public void SetMeasurements(float temperature, float humidity, float pressure)
        {
            this.temperature = temperature;
            this.humidity = humidity;
            this.pressure = pressure;
            NotifyObservers();
        }

        // Getters for weather data
        public float GetTemperature()
        {
            return temperature;
        }

        public float GetHumidity()
        {
            return humidity;
        }

        public float GetPressure()
        {
            return pressure;
        }
    }
}
