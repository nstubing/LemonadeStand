using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lemonadeStand
{
    class LemonadeStand
    {
        //member variable
        public Inventory inventory;
        public double money;
        public int customerSatisfaction;
        public int popularity;
        // constructor

        public LemonadeStand()
        {
            customerSatisfaction = 50;
            money = 20;
            inventory = new Inventory();


        }
        //member methods
     
    }
}
