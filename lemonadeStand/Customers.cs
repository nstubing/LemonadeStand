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


        public Customers(int actualTemperature, string weatherCondition, LemonadeStand lemonadeStand, Day day)
        {
            chanceToBuy = 10;
            ActualTemperatureInfluence(actualTemperature);
            WeatherConditionInfluence(weatherCondition);
            PopularityInfluence(lemonadeStand.popularity);
            PriceInfluence(lemonadeStand.recipe.price);
            RecipeInfluence(lemonadeStand);
            DoesBuy(day);

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
        public int LemonInfluence(int lemons)
        {
            int influence;
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
        public int SugarInfluence(int sugar)
        {
            int influence;
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
        public int IceInfluence(int ice)
        {
            int influence;
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

        public void DoesBuy(Day day)
        {
            Random num = new Random();
            int buyNumber = num.Next(0, 101);
            if (buyNumber < chanceToBuy)
            {
                day.payingCustomers += 1;
            }
        }
    }
}
