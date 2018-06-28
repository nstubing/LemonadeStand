using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lemonadeStand
{
    class Customers
    {
        double chanceToBuy;


        public Customers(double actualTemperature, string weatherCondition, LemonadeStand lemonadeStand, Day day,Random num)
        {
            chanceToBuy = 10;
            ActualTemperatureInfluence(actualTemperature);
            WeatherConditionInfluence(weatherCondition);
            PopularityInfluence(lemonadeStand.popularity);
            PriceInfluence(lemonadeStand.recipe.price);
            RecipeInfluence(lemonadeStand);
            DoesBuy(day,num);

        }

        public void ActualTemperatureInfluence(double temperature)
        {
            if (temperature>=75)
            {
                chanceToBuy += temperature - 77;
            }
            else
            {
                chanceToBuy -= (75 - temperature) / 2;
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
        public void PopularityInfluence(double popularity)
        {
            chanceToBuy += popularity;

        }
        public void PriceInfluence(double price)
        {
            if (price>=.25)
            {
                double overPrice= (price - .25);
                chanceToBuy -= (overPrice * 100);
            }
            else
            {
                double underPrice = (.25 - price) * 2;
                chanceToBuy += (underPrice * 100);
            }
        }
        public void RecipeInfluence(LemonadeStand lemonadeStand)
        {
            chanceToBuy += LemonInfluence(lemonadeStand.recipe.lemonsToUse);
            chanceToBuy += SugarInfluence(lemonadeStand.recipe.sugarToUse);
            chanceToBuy += IceInfluence(lemonadeStand.recipe.iceToUse);


        }
        public double LemonInfluence(double lemons)
        {
            double influence;
            if (lemons < 8)
            {
                influence=(lemons - 4) * 2;
            }
            else
            {
                influence = (7 - lemons) * 2;
            }
                
            return influence;
        }
        public double SugarInfluence(double sugar)
        {
            double influence;
            if (sugar > 4)
            {
                influence=(4-sugar);
            }
            else
            {
                influence = (sugar - 4);
            }
            return influence;
        }
        public double IceInfluence(double ice)
        {
            double influence;
            if (ice<6)
            {
                influence = (ice - 4) * 2;
            }
            else
            {
                influence = (5 - ice) * 2;
            }
            return influence;

        }

        public void DoesBuy(Day day, Random num)
        {
            double buyNumber = num.Next(0, 101);
            if (buyNumber < chanceToBuy)
            {
                day.payingCustomers += 1;
                day.cupCounter--;
            }
        }
    }
}
