using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lemonadeStand
{
    class Day
    {
        public double lemonadeBought;
        public double possibleCustomers;
        public double payingCustomers;
        Weather weather;
        Customers Customers;


        public Day()
        {


        }

        public void RunDay(Inventory inventory, LemonadeStand lemonadeStand, Store store, Day day, int currentDay)
        {
            weather = new Weather();
            store.DisplayStore(inventory, lemonadeStand, weather, currentDay);
            lemonadeStand.SetRecipe();
            GetPossibleCustomers();
            payingCustomers = 0;
            for (double j = 0; j < possibleCustomers; j++)
            {
                Customers = new Customers(weather.actualTemperature, weather.weatherCondition, lemonadeStand, day);
            }
            UpdatePopularity(lemonadeStand);
            UpdateCustomerSatisfaction(lemonadeStand);
            UpdateInventory(lemonadeStand);
            DisplayDayResults(weather.actualTemperature, weather.weatherCondition, lemonadeStand, currentDay);


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
            if (payingCustomers > lemonadeStand.customerSatisfaction)
            {
                lemonadeStand.customerSatisfaction += (payingCustomers / 3);
            }
            else
            {
                lemonadeStand.customerSatisfaction -= (payingCustomers / 3);
            }
        }

        public void UpdateInventory(LemonadeStand lemonadeStand)
        {
            lemonadeStand.money += (payingCustomers * lemonadeStand.recipe.price);
            lemonadeStand.inventory.cups -= payingCustomers;
            lemonadeStand.inventory.lemons -= ((payingCustomers / 10) * lemonadeStand.recipe.lemonsToUse);
            lemonadeStand.inventory.sugar -= ((payingCustomers / 10) * lemonadeStand.recipe.sugarToUse);
            lemonadeStand.inventory.ice = 0;
        }
        public void DisplayDayResults(double actualTemperature, string weatherCondition, LemonadeStand lemonadeStand, double currentDay)
        {
            Console.WriteLine("The actual weather of day " + currentDay + " was " + actualTemperature + " and " + weatherCondition + ".");
            Console.WriteLine("");
            Console.WriteLine("You sold " + payingCustomers + " cups of lemonade to " + possibleCustomers + " possible customers!");
            Console.WriteLine("");
            Console.WriteLine("You made $" + (payingCustomers * lemonadeStand.recipe.price) + " which brings your total to $" + lemonadeStand.money);
            Console.WriteLine("");
            Console.WriteLine("press enter to start your next day!");
            Console.WriteLine("");
            Console.BackgroundColor = ConsoleColor.Red;
            Console.WriteLine("NEXT DAY");
            Console.ResetColor();
            if (Console.ReadKey().Key == ConsoleKey.Enter)
            {
                return;
            }
            else
            {
                DisplayDayResults(actualTemperature, weatherCondition, lemonadeStand, currentDay);
            }
        }
    }
}
