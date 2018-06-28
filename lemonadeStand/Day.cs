using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lemonadeStand
{
    class Day
    {
        public double possibleCustomers;
        public double payingCustomers;
        Weather weather;
        Customers Customers;


        public Day()
        {
       
        }

        public void RunDay(Inventory inventory, LemonadeStand lemonadeStand, Store store, Day day, int currentDay,Random num)
        {
            weather = new Weather();
            store.DisplayStore(inventory, lemonadeStand, weather, currentDay);
            lemonadeStand.SetRecipe();
            GetPossibleCustomers();
            RunThroughCustomers(inventory, lemonadeStand, store, day, num);
            UpdateEndOfDayVariables(lemonadeStand);
            UpdatePopularity(lemonadeStand);
            UpdateCustomerSatisfaction(lemonadeStand);
            DisplayDayResults(weather.actualTemperature, weather.weatherCondition, lemonadeStand, currentDay);
        }
        public void GetPossibleCustomers()
        {
            Random rnd = new Random();
            possibleCustomers = rnd.Next(85, 120);
        }
        public void UpdatePopularity(LemonadeStand lemonadeStand)
        {
            lemonadeStand.popularity += Math.Round((payingCustomers / 10));
        }
        public void UpdateCustomerSatisfaction(LemonadeStand lemonadeStand)
        {
            if (payingCustomers > lemonadeStand.customerSatisfaction)
            {
                lemonadeStand.customerSatisfaction += Math.Round((payingCustomers / 3));
            }
            else
            {
                lemonadeStand.customerSatisfaction -= Math.Round((payingCustomers / 3));
            }
        }

        public void UpdateInventory(LemonadeStand lemonadeStand)
        {
            lemonadeStand.inventory.cups -= 10;
            lemonadeStand.inventory.lemons -= (10 * lemonadeStand.recipe.lemonsToUse);
            lemonadeStand.inventory.sugar -= (10 * lemonadeStand.recipe.sugarToUse);
        }
        public void DisplayDayResults(double actualTemperature, string weatherCondition, LemonadeStand lemonadeStand, double currentDay)
        {
            Console.WriteLine("The actual weather of day " + currentDay + " was " + actualTemperature + " and " + weatherCondition + ".");
            Console.WriteLine("");
            Console.WriteLine("You sold " + payingCustomers + " cups of lemonade to " + possibleCustomers + " possible customers!");
            Console.WriteLine("");
            Console.WriteLine("You made $" + (payingCustomers * lemonadeStand.recipe.price) + " which brings your total to $" + lemonadeStand.money);
            Console.WriteLine("");
            Console.WriteLine("Your popularity is now at "+lemonadeStand.popularity+" and your customer satisfaction is at "+lemonadeStand.customerSatisfaction+"%!");
            Console.WriteLine("press enter to start your next day!");
            Console.WriteLine("");
            Console.BackgroundColor = ConsoleColor.Red;
            Console.WriteLine("NEXT DAY");
            Console.ResetColor();
            if (Console.ReadKey().Key == ConsoleKey.Enter)
            {
                Console.Clear();
                return;
            }
            else
            {
                DisplayDayResults(actualTemperature, weatherCondition, lemonadeStand, currentDay);
            }
        }
        public void UpdateEndOfDayVariables(LemonadeStand lemonadeStand)
        {
            lemonadeStand.money += payingCustomers * lemonadeStand.recipe.price;
            lemonadeStand.inventory.ice = 0;
        }

        public void RunThroughCustomers(Inventory inventory, LemonadeStand lemonadeStand, Store store, Day day, Random num)
        {
            for (double j = 0; j < possibleCustomers; j++)
            {
                if ((j == 0) || (payingCustomers % 10 == 0))
                {
                    UpdateInventory(lemonadeStand);
                }
                if ((inventory.cups > 9) && (inventory.lemons > lemonadeStand.recipe.lemonsToUse) && (inventory.sugar > lemonadeStand.recipe.sugarToUse) && (inventory.ice > lemonadeStand.recipe.iceToUse))
                {
                    Customers = new Customers(weather.actualTemperature, weather.weatherCondition, lemonadeStand, day, num);
                }

            }
        }
    }

}
