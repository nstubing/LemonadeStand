using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lemonadeStand
{
    class Store
    {
        public int storeKeyCounter;

        public Store()
        {

        }


        public void DisplayStore()
        {
            Console.WriteLine("Use up and down arrow to navigate, press enter to buy items!");
            DisplayStoreHighlight(storeKeyCounter);
            if ((storeKeyCounter>=0) && (storeKeyCounter<=5))
            {
                if (Console.ReadKey().Key == ConsoleKey.UpArrow)
                {
                    storeKeyCounter -= 1;
                }
                else if (Console.ReadKey().Key == ConsoleKey.DownArrow)
                {
                    storeKeyCounter += 1;
                }

            }
            DisplayStore();


        }
        public void DisplayStoreHighlight(int keyCounter)
        {
            switch(keyCounter)
            {
                case 0:
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.WriteLine("BUY CUPS");
                    Console.ResetColor();
                    Console.WriteLine("BUY LEMONS");
                    Console.WriteLine("BUY SUGAR");
                    Console.WriteLine("BUY ICE");
                    Console.WriteLine("EXIT STORE");
                    break;
                case 1:
                    Console.WriteLine("BUY CUPS");
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.WriteLine("BUY LEMONS");
                    Console.ResetColor();
                    Console.WriteLine("BUY SUGAR");
                    Console.WriteLine("BUY ICE");
                    Console.WriteLine("EXIT STORE");
                    break;
                case 2:
                    Console.WriteLine("BUY CUPS");
                    Console.WriteLine("BUY LEMONS");
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.WriteLine("BUY SUGAR");
                    Console.ResetColor();
                    Console.WriteLine("BUY ICE");
                    Console.WriteLine("EXIT STORE");
                    break;
                case 3:
                    Console.WriteLine("BUY CUPS");
                    Console.WriteLine("BUY LEMONS");
                    Console.WriteLine("BUY SUGAR");
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.WriteLine("BUY ICE");
                    Console.ResetColor();
                    Console.WriteLine("EXIT STORE");
                    break;
                case 4:
                    Console.WriteLine("BUY CUPS");
                    Console.WriteLine("BUY LEMONS");
                    Console.WriteLine("BUY SUGAR");
                    Console.WriteLine("BUY ICE");
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.WriteLine("EXIT STORE");
                    Console.ResetColor();
                    break;
            }

        }
    }
}
