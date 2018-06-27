using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lemonadeStand
{
    class CurrentCustomer:Customers
    {

        double chanceToBuy;
        public CurrentCustomer(int actualTemperature, string weatherCondition, int popularity, double price, int payingCustomers)
            :base(actualTemperature,weatherCondition,popularity,price,payingCustomers)
        {

        }
        public override void DoesBuy()
        {
            Random num = new Random();
            int buyNumber = num.Next(0, 101);
            if (buyNumber<chanceToBuy)
            {
                
            }
            

        }
    }
}
