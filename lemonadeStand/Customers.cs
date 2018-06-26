using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lemonadeStand
{
    class Customers
    {
        int chanceToBuy;

        public Customers(int actualTemperature, string weatherCondition, int popularity, int price)
        {
            chanceToBuy = 10;
            ActualTemperatureInfluence(actualTemperature);
            WeatherConditionInfluence(weatherCondition);
            PopularityInfluence(popularity);
            PriceInfluence(price);

        }

        public void ActualTemperatureInfluence(int temperature)
        {
            if (temperature>=70)
            {
                chanceToBuy += temperature - 70;
            }
            else
            {
                chanceToBuy -= (70 - temperature) / 2;
            }

        }
        public void WeatherConditionInfluence(string weather)
        {
            switch(weather)
            {
                case "clear":
                    chanceToBuy += 7;
                    break;
                case "hazy":
                    chanceToBuy += 3;
                    break;
                case "rainy":
                    chanceToBuy -= 10;
                    break;
                case "overcast":
                    chanceToBuy -= 4;
                    break;
                default:
                    chanceToBuy += 0;
                    break;

            }
        }
        public void PopularityInfluence(int popularity)
        {
            chanceToBuy += popularity;

        }
        public void PriceInfluence(int price)
        {
            if (price>=25)
            {
                chanceToBuy -= (price - 25);
            }
            else
            {
                chanceToBuy += (25 - price) * 2;
            }
        }
    }
}
