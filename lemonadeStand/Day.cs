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
        Customers customers;


        public Day(Inventory inventory, LemonadeStand lemonadestand, Store store)
        {
            RunDay(inventory, lemonadestand, store);

        }

        public void RunDay(Inventory inventory, LemonadeStand lemonadeStand, Store store)
        {
            weather = new Weather();
            store.DisplayStore(inventory, lemonadeStand, weather);

            customers = new Customers();


        }
    }
}
