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
        public double cupCounter;
        public int pitcher;


        public Day()
        {
       
        }

        public void RunDay(Inventory inventory, LemonadeStand lemonadeStand, Store store, Day day, int currentDay,Random num)
        {
            weather = new Weather();
            store.DisplayStore(inventory, lemonadeStand, weather, currentDay);
            lemonadeStand.SetRecipe();
            GetPossibleCustomers();
            this.cupCounter = inventory.cups;
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
            if ((lemonadeStand.customerSatisfaction + Math.Round((payingCustomers / 6)))<100)
            {
                lemonadeStand.customerSatisfaction += Math.Round((payingCustomers / 6));
            }
            else
            {
                lemonadeStand.customerSatisfaction = 100;
            }
        }

        public void UpdateInventory(LemonadeStand lemonadeStand)
        {
            lemonadeStand.inventory.lemons -= lemonadeStand.recipe.lemonsToUse;
            lemonadeStand.inventory.sugar -= lemonadeStand.recipe.sugarToUse;
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
            lemonadeStand.inventory.cups = cupCounter;
            lemonadeStand.money += payingCustomers * lemonadeStand.recipe.price;
            lemonadeStand.inventory.ice = 0;
        }

        public void RunThroughCustomers(Inventory inventory, LemonadeStand lemonadeStand, Store store, Day day, Random num)
        {
            for (double j = 0; j < possibleCustomers; j++)
            {
                if (j==0 || pitcher==10 ||pitcher ==21 || pitcher==32 || pitcher==43 || pitcher==54 || pitcher == 65 || pitcher == 76 || pitcher==87 || pitcher==98 ||pitcher==109)
                {
                    UpdateInventory(lemonadeStand);
                    pitcher++;
                }
                if (cupCounter > 0 && inventory.lemons > lemonadeStand.recipe.lemonsToUse && inventory.sugar > lemonadeStand.recipe.sugarToUse && inventory.ice > lemonadeStand.recipe.iceToUse)
                {
                    Customers = new Customers(weather.actualTemperature, weather.weatherCondition, lemonadeStand, day, num);
                }
                else
                {
                    return;
                }

            }
        }
    }

}
