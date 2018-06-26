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
        public int itemKeyCounter;


        public Store(Inventory inventory)
        {
        }


        public void DisplayStore(Inventory inventory)
        {
            Console.WriteLine("Use up and down arrow to navigate, press enter to buy items!");
            DisplayStoreHighlight(storeKeyCounter,inventory);
            var keyPressed = Console.ReadKey().Key;
            if (keyPressed==ConsoleKey.Enter)
            {
                if (storeKeyCounter==4)
                {
                    return;
                }
                else
                {
                    DisplayItemHighlight(storeKeyCounter, inventory);
                }
            }

            if (storeKeyCounter==0)
            {
                if(keyPressed==ConsoleKey.DownArrow)
                {
                    storeKeyCounter += 1;
                }
            }
            else if (storeKeyCounter==4)
            {
                if (keyPressed==ConsoleKey.UpArrow)
                {
                    storeKeyCounter -= 1;
                }
            }
            else if ((storeKeyCounter>0) && (storeKeyCounter<4))
            {
                if (keyPressed == ConsoleKey.UpArrow)
                {
                    storeKeyCounter -= 1;
                }
                else if (keyPressed == ConsoleKey.DownArrow)
                {
                    storeKeyCounter += 1;
                }

            }
            Console.Clear();
            DisplayStore(inventory);


        }
        public void DisplayStoreHighlight(int keyCounter,Inventory inventory)
        {
           Console.WriteLine("Cups: " + inventory.cups + "   Lemons: " + inventory.lemons + "   Sugar: " + inventory.sugar + " cups" + "   Ice: " + inventory.ice + " Cubes");
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

        public void DisplayItemHighlight(int storeKeyCounter,Inventory inventory)
        {

        }
    }
}
