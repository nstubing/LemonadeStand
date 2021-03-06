﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lemonadeStand
{
    class Game
    {
        LemonadeStand lemonadeStandOne;
        Day day;
        Store store;
        public int currentDay;
        public double daysPlaying;


        public Game()
        {
            Random num = new Random();
            DisplayRules();
            Console.Clear();
            lemonadeStandOne = new LemonadeStand();
            store = new Store();
            day = new Day();
            currentDay = 1;
            RunGameDays(lemonadeStandOne.inventory, lemonadeStandOne,store, day,num);
            DisplayEndGame(lemonadeStandOne);
        }

        private void DisplayRules()
        {
            Console.WriteLine("Your goal is to make as much money as you can in 7, 14, or 21 days by selling lemonade at your lemonade stand. Buy cups, lemons, sugar, and ice cubes, then set your recipe based on the weather and conditions." + Environment.NewLine +
                "  Start with the basic recipe, but try to vary the recipe and see if you can do better!  Lastly, set your price and sell your lemonade at the stand. try changing up the price based on the weather conditions as well." + Environment.NewLine+
                " At the end of the game, you'll see how much money you made, write it down and try to beat your score! Would you like to play 7,14, or 21 days? please type answer");

            
            bool isNumber = double.TryParse(Console.ReadLine(), out daysPlaying);
            switch (daysPlaying)
             {
                case 1:
                    break;
                 case 7:
                    break;
                 case 14:
                    break;
                 case 21:
                    break;
                 default:
                    Console.Clear();
                    DisplayRules();
                    break;

            }
        }
        private void RunGameDays(Inventory inventory, LemonadeStand lemonadeStand,Store store, Day day,Random num)
        {
            for(double i = 1; i <= daysPlaying; i++)
            {
                day.payingCustomers = 0;
                day.RunDay(inventory,lemonadeStand,store,day,currentDay,num);
                this.currentDay += 1;

            }

        }

        public void DisplayEndGame(LemonadeStand lemonadeStand)
        {
            Console.WriteLine("You made it to day "+daysPlaying+ " and you made $"+lemonadeStand.money+"!");

        }



    }

}
