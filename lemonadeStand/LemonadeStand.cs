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
        public double customerSatisfaction;
        public double popularity;
        public double revenue;
        public Recipe recipe;
        // constructor

        public LemonadeStand()
        {
            customerSatisfaction = 50;
            money = 20;
            inventory = new Inventory();
            recipe = new Recipe();


        }
        //member methods
        public void SetRecipe()
        {
            Console.Clear();
            Console.WriteLine("This is your current recipe! Type the name of the item you would like to change 'lemons' 'sugar' ice' or 'exit' to exit.");
            Console.WriteLine("Lemons:      "+recipe.lemonsToUse);
            Console.WriteLine("Sugar:       "+recipe.sugarToUse);
            Console.WriteLine("Ice:         "+recipe.iceToUse);
            Console.WriteLine("Price:    $"+recipe.price);
            string response = Console.ReadLine().Trim().ToLower();
            switch(response)
            {
                case "lemons":
                    Console.WriteLine("What would you like to set the new amount of lemons to? Input a number.");
                    bool lemonsNumber= double.TryParse(Console.ReadLine(), out recipe.lemonsToUse);
                    SetRecipe();
                    break;
                case "sugar":
                    Console.WriteLine("What would you like to set the new amount of Sugar to? Input a number.");
                     bool sugarNumber= double.TryParse(Console.ReadLine(), out recipe.sugarToUse);
                    SetRecipe();
                    break;
                case "ice":
                    Console.WriteLine("What would you like to set the new amount of ice to? Input a number.");
                    bool iceNUmber= double.TryParse(Console.ReadLine(), out recipe.iceToUse);
                    SetRecipe();
                    break;
                case "price":
                    Console.WriteLine("What would you like to set the price to? example '0.28'");
                     bool priceNumber= double.TryParse(Console.ReadLine(), out recipe.price);
                    SetRecipe();
                    break;
                case "exit":
                    Console.Clear();
                    break;
                default:
                    Console.WriteLine("Please input an item!");
                    SetRecipe();
                    break;



            }

        }

     
    }
}
