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


        public Day(Inventory inventory,double money)
        {
            Store store = new Store(inventory, money);

        }
    }
}
