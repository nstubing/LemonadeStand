﻿using System;
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
            Console.WriteLine("This is your current recipe! Type the name of the item you would like to change 'lemons' 'sugar' ice' or 'exit' to exit.");
            Console.WriteLine("Lemons:      "+recipe.lemonsToUse);
            Console.WriteLine("Sugar:       "+recipe.sugarToUse);
            Console.WriteLine("Ice:         "+recipe.iceToUse);
            Console.WriteLine("Price:       "+recipe.price);
            string response = Console.ReadLine().Trim().ToLower();
            switch(response)
            {
                case "lemons":
                    Console.WriteLine("What would you like to set the new amount of lemons to? Input a number.");
                    recipe.lemonsToUse = Int32.Parse(Console.ReadLine());
                    break;
                case "sugar":
                    Console.WriteLine("What would you like to set the new amount of Sugar to? Input a number.");
                    recipe.sugarToUse = Int32.Parse(Console.ReadLine());
                    break;
                case "Ice":
                    Console.WriteLine("What would you like to set the new amount of ice to? Input a number.");
                    recipe.iceToUse = Int32.Parse(Console.ReadLine());
                    break;
                case "price":
                    Console.WriteLine("What would you like to set the price to? example '0.28'");
                    recipe.price = double.Parse(Console.ReadLine());
                    break;
                case "exit":
                    break;
                default:
                    Console.WriteLine("Please input an item!");
                    SetRecipe();
                    break;



            }

        }

     
    }
}
