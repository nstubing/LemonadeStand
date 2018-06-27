using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lemonadeStand
{
    class Day
    {
        public int lemonadeBought;
        public int possibleCustomers;
        public int payingCustomers;
        public int popularityChange;
        public int customerSatisfactionChange;
        Weather weather;
        CurrentCustomer currentCustomer;


        public Day(Inventory inventory, LemonadeStand lemonadestand, Store store)
        {
            RunDay(inventory, lemonadestand, store);

        }

        public void RunDay(Inventory inventory, LemonadeStand lemonadeStand, Store store)
        {
            weather = new Weather();
            store.DisplayStore(inventory, lemonadeStand, weather);
            lemonadeStand.SetRecipe();
            GetPossibleCustomers();
            for(int j=0; j<possibleCustomers;j++)
            {
                currentCustomer = new CurrentCustomer(weather.actualTemperature, weather.weatherCondition, lemonadeStand.popularity, lemonadeStand.recipe.price, payingCustomers);
            }
            Console.WriteLine(payingCustomers);


        }
        public void GetPossibleCustomers()
        {
            Random rnd = new Random();
            possibleCustomers = rnd.Next(85, 120);
        }
    }
}
