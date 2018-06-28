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
        Weather weather;
        Customers Customers;


        public Day()
        {
          

        }

        public void RunDay(Inventory inventory, LemonadeStand lemonadeStand, Store store, Day day,int currentDay)
        {
            weather = new Weather();
            store.DisplayStore(inventory, lemonadeStand, weather);
            lemonadeStand.SetRecipe();
            GetPossibleCustomers();
            payingCustomers = 0;
            for(int j=0; j<possibleCustomers;j++)
            {
                Customers = new Customers(weather.actualTemperature, weather.weatherCondition, lemonadeStand, day);
            }
            UpdatePopularity(lemonadeStand);
            UpdateCustomerSatisfaction(lemonadeStand);
            UpdateInventory(inventory)
            DisplayDayResults()


        }
        public void GetPossibleCustomers()
        {
            Random rnd = new Random();
            possibleCustomers = rnd.Next(85, 120);
        }
        public void UpdatePopularity(LemonadeStand lemonadeStand)
        {
            lemonadeStand.popularity += (payingCustomers / 10);
        }
        public void UpdateCustomerSatisfaction(LemonadeStand lemonadeStand)
        {
            if(payingCustomers>lemonadeStand.customerSatisfaction)
            {
                lemonadeStand.customerSatisfaction += (payingCustomers / 3);
            }
            else
            {
                lemonadeStand.customerSatisfaction -= (payingCustomers / 3);
            }
        }
    }
}
