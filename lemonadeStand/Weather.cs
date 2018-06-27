using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lemonadeStand
{
    class Weather
    {
        public int forcastTemperature;
        public int actualTemperature;
        public string weatherCondition;

        public Weather()
        {
        
            GetTemperature();
            GetWeatherCondition();
            GetActualTemperature();
        }

        public void GetTemperature()
        {
            Random rnd = new Random();
            forcastTemperature = rnd.Next(50, 100);
        }
        public void GetWeatherCondition()
        {
            Random rnd = new Random();
            int numberCondition = rnd.Next(0, 4);
            switch(numberCondition)
            {
                case 0:
                    weatherCondition = "clear";
                    break;
                case 1:
                    weatherCondition = "hazy";
                    break;
                case 2:
                    weatherCondition = "rainy";
                    break;
                case 3:
                    weatherCondition = "overcast";
                    break;
            }
        }


        public void GetActualTemperature()
        {
            Random rnd = new Random();
            actualTemperature = rnd.Next(forcastTemperature - 10, forcastTemperature + 10);
        }
    }
}
