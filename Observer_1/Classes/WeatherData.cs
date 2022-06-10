using System;
using System.Collections.Generic;
using System.Text;

using Observer_1.Interfaces;
using Observer_1.Classes;


namespace Observer_1.Classes
{
    internal class WeatherData : Subject
    {
        private List<Observe> observer_instance = new List<Observe>();
        private double Temperature;
        private double Pressure;
        private double Humidity;

        public void registerObserver(Observe observer)
        {
            observer_instance.Add(observer);
        }

        public void removeObserver(Observe observer)
        {
            observer_instance.Remove(observer);
        }

        public void notifyObservers()
        {
            foreach(Observe observer in observer_instance)
            {
                observer.update(getTemperature(), getPressure(), getHumidity());
            }
        }

        double getTemperature()
        {
            return Temperature;
        }
        double getPressure()
        {
            return Pressure;
        }

        double getHumidity()
        {
            return Humidity;
        }

        public void change_indicators (double temp, double press, double hum)
        {
            Temperature = temp;
            Pressure = press;
            Humidity = hum;
            notifyObservers();
        }


    }
}
