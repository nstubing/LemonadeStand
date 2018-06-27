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
        public int daysPlaying;


        public Game()
        {
            DisplayRules();
            Console.Clear();
            lemonadeStandOne = new LemonadeStand();
            RunGameDays(lemonadeStandOne.inventory, lemonadeStandOne.money);
        }

        private void DisplayRules()
        {
            Console.WriteLine("Your goal is to make as much money as you can in 7, 14, or 21 days by selling lemonade at your lemonade stand. Buy cups, lemons, sugar, and ice cubes, then set your recipe based on the weather and conditions." + Environment.NewLine +
                "  Start with the basic recipe, but try to vary the recipe and see if you can do better!  Lastly, set your price and sell your lemonade at the stand. try changing up the price based on the weather conditions as well." + Environment.NewLine+
                " At the end of the game, you'll see how much money you made, write it down and try to beat your score! Would you like to play 7,14, or 21 days? please type answer");
            daysPlaying = Int32.Parse(Console.ReadLine());
        }
        private void RunGameDays(Inventory inventory, double money)
        {
            for(int i = 1; i <= daysPlaying; i++)
            {
                day = new Day(inventory,money);
            }

        }





    }

}
