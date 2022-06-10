using System;
using System.Collections.Generic;
using System.Text;

using Observer_1.Interfaces;
using Observer_1.Classes;

namespace Observer_1.Classes
{
    class ForecastDisplay : Observe
    {

        private double Temperature;
        private double Pressure;
        private double Humidity;
        public void update(double temperature, double pressure, double humidity)
        {
            this.Temperature = temperature;
            this.Pressure = pressure;
            this.Humidity = humidity;
            display();
        }

        
        public void display()
        {
            
            Console.WriteLine("Температура : " + Temperature + " градусов");
            Console.WriteLine("Давление : " + Pressure + " Па");
            Console.WriteLine("Уровень влажности :" + Humidity + " %");
            Console.WriteLine();
        }
    }
}
