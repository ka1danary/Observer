using System;
using System.Collections.Generic;
using System.Text;

using Observer_1.Interfaces;
using Observer_1.Classes;

namespace Observer_1
{
    class Program
    {
        static void Main(string[] args)
        {
            WeatherData weather_instance = new WeatherData();
            CurentConditionDisplay curentConditionDisplay_instance = new CurentConditionDisplay();
            ForecastDisplay forecastDisplay_instance = new ForecastDisplay();
            StaticDisplay staticDisplay_instance = new StaticDisplay();

            weather_instance.registerObserver(curentConditionDisplay_instance);
            weather_instance.registerObserver(forecastDisplay_instance);
            weather_instance.registerObserver(staticDisplay_instance);


            double t = Convert.ToDouble(Console.ReadLine());
            double p = Convert.ToDouble(Console.ReadLine());
            double h = Convert.ToDouble(Console.ReadLine());

            weather_instance.change_indicators(t, p, h);

            curentConditionDisplay_instance.display();
            forecastDisplay_instance.display();
            staticDisplay_instance.display();

        }
    }
}
