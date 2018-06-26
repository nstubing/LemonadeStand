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
        public Inventory newInventory;
        public double newMoney;


        public Store(Inventory inventory, double money)
        {
            this.newInventory = inventory;
            this.newMoney = money;
            DisplayStore(newInventory);
        }


        public void DisplayStore(Inventory newInventory)
        {
            Console.WriteLine("Use up and down arrow to navigate, press enter to look at item prices!");
            DisplayStoreHighlight(storeKeyCounter,newInventory);
            var keyPressed = Console.ReadKey().Key;
            if (keyPressed==ConsoleKey.Enter)
            {
                if (storeKeyCounter==4)
                {
                    return;
                }
                else
                {
                    Console.Clear();
                    DisplayItem(storeKeyCounter,itemKeyCounter,newInventory);
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
            DisplayStore(newInventory);


        }
        public void DisplayStoreHighlight(int keyCounter,Inventory inventory)
        {
           Console.WriteLine("Cups: " + newInventory.cups + "   Lemons: " + newInventory.lemons + "   Sugar: " + newInventory.sugar + " cups" + "   Ice: " + newInventory.ice + " Cubes"+"   Money:$"+newMoney);
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


        public void DisplayItem(int storeKeyCounter, int itemKeyCounter, Inventory inventory)
        {
            Console.WriteLine("Use up and down arrow to navigate, press enter to buy items!");
            switch (storeKeyCounter)
            {
                case 0:
                    DisplayCup(inventory,itemKeyCounter);
                    break;
                case 1:
                    DisplayLemons(inventory,itemKeyCounter);
                    break;
                case 2:
                    DisplaySugar(inventory,itemKeyCounter);
                    break;
                case 3:
                    DisplayIce(inventory,itemKeyCounter);
                    break;
            }

            var keyPress = Console.ReadKey().Key;
            if (keyPress == ConsoleKey.Enter)
            {
                if (itemKeyCounter == 3)
                {
                    return;
                }
                else
                {
                    UpdateInventory(storeKeyCounter, itemKeyCounter);
               }
            }

            if (itemKeyCounter == 0)
            {
                if (keyPress == ConsoleKey.DownArrow)
                {
                    itemKeyCounter += 1;
                }
            }
            else if (itemKeyCounter == 3)
            {
                if (keyPress == ConsoleKey.UpArrow)
                {
                    itemKeyCounter -= 1;
                }
            }
            else if ((itemKeyCounter > 0) && (itemKeyCounter < 3))
            {
                if (keyPress == ConsoleKey.UpArrow)
                {
                    itemKeyCounter -= 1;
                }
                else if (keyPress == ConsoleKey.DownArrow)
                {
                    itemKeyCounter += 1;
                }

            }
            Console.Clear();
            DisplayItem(storeKeyCounter, itemKeyCounter, inventory);

        }
        public void DisplayCup(Inventory inventory, int itemKeyCounter)
        {
            Console.WriteLine("Cups: " + newInventory.cups + "   Lemons: " + newInventory.lemons + "   Sugar: " + newInventory.sugar + " cups" + "   Ice: " + newInventory.ice + " Cubes" + "   Money:$" + newMoney);
            switch (itemKeyCounter)
            {
                case 0:
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.WriteLine("25 CUPS      $0.86");
                    Console.ResetColor();
                    Console.WriteLine("50 CUPS      $1.63");
                    Console.WriteLine("100 CUPS     $2.75");
                    Console.WriteLine("EXIT");
                    break;
                case 1:
                    Console.WriteLine("25 CUPS      $0.86");
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.WriteLine("50 CUPS      $1.63");
                    Console.ResetColor();
                    Console.WriteLine("100 CUPS     $2.75");
                    Console.WriteLine("EXIT");
                    break;
                case 2:
                    Console.WriteLine("25 CUPS      $0.86");
                    Console.WriteLine("50 CUPS      $1.63");
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.WriteLine("100 CUPS     $2.75");
                    Console.ResetColor();
                    Console.WriteLine("EXIT");
                    break;
                case 3:
                    Console.WriteLine("25 CUPS      $0.86");
                    Console.WriteLine("50 CUPS      $1.63");
                    Console.WriteLine("100 CUPS     $2.75");
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.WriteLine("EXIT");
                    Console.ResetColor();
                    break;




            }

        }

        public void DisplayLemons(Inventory inventory, int itemKeyCounter)
        {

            Console.WriteLine("Cups: " + newInventory.cups + "   Lemons: " + newInventory.lemons + "   Sugar: " + newInventory.sugar + " cups" + "   Ice: " + newInventory.ice + " Cubes" + "   Money:$" + newMoney);
            switch (itemKeyCounter)
            {
                case 0:
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.WriteLine("10 LemonS      $0.64");
                    Console.ResetColor();
                    Console.WriteLine("30 Lemons      $2.16");
                    Console.WriteLine("75 Lemons      $4.19");
                    Console.WriteLine("EXIT");
                    break;
                case 1:
                    Console.WriteLine("10 LemonS      $0.64");
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.WriteLine("30 Lemons      $2.16");
                    Console.ResetColor();
                    Console.WriteLine("75 Lemons      $4.19");
                    Console.WriteLine("EXIT");
                    break;
                case 2:
                    Console.WriteLine("10 LemonS      $0.64");
                    Console.WriteLine("30 Lemons      $2.16");
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.WriteLine("75 Lemons      $4.19");
                    Console.ResetColor();
                    Console.WriteLine("EXIT");
                    break;
                case 3:
                    Console.WriteLine("10 LemonS      $0.64");
                    Console.WriteLine("30 Lemons      $2.16");
                    Console.WriteLine("75 Lemons      $4.19");
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.WriteLine("EXIT");
                    Console.ResetColor();
                    break;

            }
        }
        public void DisplaySugar(Inventory inventory, int itemKeyCounter)
        {

            Console.WriteLine("Cups: " + newInventory.cups + "   Lemons: " + newInventory.lemons + "   Sugar: " + newInventory.sugar + " cups" + "   Ice: " + newInventory.ice + " Cubes" + "   Money:$" + newMoney);
            switch (itemKeyCounter)
            {
                case 0:
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.WriteLine("8 Cups Sugar     $0.51");
                    Console.ResetColor();
                    Console.WriteLine("20 Cups Sugar    $1.64");
                    Console.WriteLine("48 Cups Sugar    $3.28");
                    Console.WriteLine("EXIT");
                    break;
                case 1:
                    Console.WriteLine("8 Cups Sugar     $0.51");
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.WriteLine("20 Cups Sugar    $1.64");
                    Console.ResetColor();
                    Console.WriteLine("48 Cups Sugar    $3.28");
                    Console.WriteLine("EXIT");
                    break;
                case 2:
                    Console.WriteLine("8 Cups Sugar     $0.51");
                    Console.WriteLine("20 Cups Sugar    $1.64");
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.WriteLine("48 Cups Sugar    $3.28");
                    Console.ResetColor();
                    Console.WriteLine("EXIT");
                    break;
                case 3:
                    Console.WriteLine("8 Cups Sugar     $0.51");
                    Console.WriteLine("20 Cups Sugar    $1.64");
                    Console.WriteLine("48 Cups Sugar    $3.28");
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.WriteLine("EXIT");
                    Console.ResetColor();
                    break;

            }
        }
        public void DisplayIce(Inventory inventory, int itemKeyCounter)
        {

            Console.WriteLine("Cups: " + newInventory.cups + "   Lemons: " + newInventory.lemons + "   Sugar: " + newInventory.sugar + " cups" + "   Ice: " + newInventory.ice + " Cubes" + "   Money:$" + newMoney);
            switch (itemKeyCounter)
            {
                case 0:
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.WriteLine("100 Ice Cubes        $.88");
                    Console.ResetColor();
                    Console.WriteLine("250 Ice Cubes        $2.00");
                    Console.WriteLine("500 Ice Cubes        $3.66");
                    Console.WriteLine("EXIT");
                    break;
                case 1:
                    Console.WriteLine("100 Ice Cubes        $.88");
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.WriteLine("250 Ice Cubes        $2.00");
                    Console.ResetColor();
                    Console.WriteLine("500 Ice Cubes        $3.66");
                    Console.WriteLine("EXIT");
                    break;
                case 2:
                    Console.WriteLine("100 Ice Cubes        $.88");
                    Console.WriteLine("250 Ice Cubes        $2.00");
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.WriteLine("500 Ice Cubes        $3.66");
                    Console.ResetColor();
                    Console.WriteLine("EXIT");
                    break;
                case 3:
                    Console.WriteLine("100 Ice Cubes        $.88");
                    Console.WriteLine("250 Ice Cubes        $2.00");
                    Console.WriteLine("500 Ice Cubes        $3.66");
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.WriteLine("EXIT");
                    Console.ResetColor();
                    break;

            }
        }

        public void UpdateInventory(int storeKeyCounter, int itemKeyCounter)
        {
            switch(storeKeyCounter)
            {
                case 0:
                    switch (itemKeyCounter)
                    {
                        case 0:
                            newInventory.cups += 25;
                            newMoney -= .86;
                            break;
                        case 1:
                            newInventory.cups += 50;
                            newMoney-=1.63;
                            break;
                        case 2:
                            newInventory.cups += 100;
                            newMoney -= 2.75;
                            break;
                    }
                    break;
                case 1:
                    switch (itemKeyCounter)
                    {
                        case 0:
                            newInventory.lemons += 10;
                            newMoney -= .64;
                            break;
                        case 1:
                            newInventory.lemons += 30;
                            newMoney -= 2.16;
                            break;
                        case 2:
                            newInventory.lemons += 75;
                            newMoney -= 4.19;
                            break;
                    }
                    break;
                case 2:
                    switch (itemKeyCounter)
                    {
                        case 0:
                            newInventory.sugar += 8;
                            newMoney -= .51;
                            break;
                        case 1:
                            newInventory.sugar += 20;
                            newMoney -= 1.63;
                            break;
                        case 2:
                            newInventory.sugar += 48;
                            newMoney -= 3.28;
                            break;
                    }
                    break;
                case 3:
                    switch (itemKeyCounter)
                    {
                        case 0:
                            newInventory.ice += 100;
                            newMoney -= .88;
                            break;
                        case 1:
                            newInventory.ice += 250;
                            newMoney -= 2.00;
                            break;
                        case 2:
                            newInventory.ice += 500;
                            newMoney -= 3.66;
                            break;
                    }
                    break;
            }

        }
    }
}
