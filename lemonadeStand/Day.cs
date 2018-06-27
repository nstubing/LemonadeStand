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
        Customers Customers;


        public Day()
        {
          

        }

        public void RunDay(Inventory inventory, LemonadeStand lemonadeStand, Store store, Day day)
        {
            weather = new Weather();
            store.DisplayStore(inventory, lemonadeStand, weather);
            lemonadeStand.SetRecipe();
            GetPossibleCustomers();
            for(int j=0; j<possibleCustomers;j++)
            {
                Customers = new Customers(weather.actualTemperature, weather.weatherCondition, lemonadeStand.popularity, lemonadeStand.recipe.price, day);
            }
            Console.WriteLine(payingCustomers);
            Console.ReadLine();


        }
        public void GetPossibleCustomers()
        {
            Random rnd = new Random();
            possibleCustomers = rnd.Next(85, 120);
        }
    }
}
