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

       
        public Store()
        {

        }


        public void DisplayStore(Inventory inventory, LemonadeStand lemonadeStand,Weather weather)
        {
            Console.WriteLine("Use up and down arrow to navigate, press enter to look at item prices!");
            DisplayStoreHighlight(storeKeyCounter, inventory, lemonadeStand);
            var keyPressed = Console.ReadKey().Key;
            if (keyPressed==ConsoleKey.Enter)
            {
                if (storeKeyCounter==4)
                {
                    Console.Clear();
                    return;
                }
                else
                {
                    Console.Clear();
                    DisplayItem(storeKeyCounter,itemKeyCounter,inventory,lemonadeStand);
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
            DisplayStore(inventory,lemonadeStand);


        }
        public void DisplayStoreHighlight(int keyCounter,Inventory inventory, LemonadeStand lemonadeStand)
        {
           Console.WriteLine("Cups: " + inventory.cups + "   Lemons: " + inventory.lemons + "   Sugar: " + inventory.sugar + " cups" + "   Ice: " + inventory.ice + " Cubes"+"   Money:$"+lemonadeStand.money);
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


        public void DisplayItem(int storeKeyCounter, int itemKeyCounter, Inventory inventory, LemonadeStand lemonadeStand)
        {
            Console.WriteLine("Use up and down arrow to navigate, press enter to buy items!");
            switch (storeKeyCounter)
            {
                case 0:
                    DisplayCup(inventory,itemKeyCounter,lemonadeStand);
                    break;
                case 1:
                    DisplayLemons(inventory,itemKeyCounter,lemonadeStand);
                    break;
                case 2:
                    DisplaySugar(inventory,itemKeyCounter,lemonadeStand);
                    break;
                case 3:
                    DisplayIce(inventory,itemKeyCounter,lemonadeStand);
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
                    UpdateInventory(storeKeyCounter, itemKeyCounter,inventory, lemonadeStand);
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
            DisplayItem(storeKeyCounter, itemKeyCounter, inventory, lemonadeStand);

        }
        public void DisplayCup(Inventory inventory, int itemKeyCounter, LemonadeStand lemonadeStand)
        {
            Console.WriteLine("Cups: " + inventory.cups + "   Lemons: " + inventory.lemons + "   Sugar: " + inventory.sugar + " cups" + "   Ice: " + inventory.ice + " Cubes" + "   Money:$" + lemonadeStand.money);
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

        public void DisplayLemons(Inventory inventory, int itemKeyCounter, LemonadeStand lemonadeStand)
        {

            Console.WriteLine("Cups: " + inventory.cups + "   Lemons: " + inventory.lemons + "   Sugar: " + inventory.sugar + " cups" + "   Ice: " + inventory.ice + " Cubes" + "   Money:$" + lemonadeStand.money);
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
        public void DisplaySugar(Inventory inventory, int itemKeyCounter, LemonadeStand lemonadeStand)
        {

            Console.WriteLine("Cups: " + inventory.cups + "   Lemons: " + inventory.lemons + "   Sugar: " + inventory.sugar + " cups" + "   Ice: " + inventory.ice + " Cubes" + "   Money:$" + lemonadeStand.money);
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
        public void DisplayIce(Inventory inventory, int itemKeyCounter, LemonadeStand lemonadeStand)
        {

            Console.WriteLine("Cups: " + inventory.cups + "   Lemons: " + inventory.lemons + "   Sugar: " + inventory.sugar + " cups" + "   Ice: " + inventory.ice + " Cubes" + "   Money:$" + lemonadeStand.money);
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

        public void UpdateInventory(int storeKeyCounter, int itemKeyCounter,Inventory inventory, LemonadeStand lemonadeStand)
        {
            switch(storeKeyCounter)
            {
                case 0:
                    switch (itemKeyCounter)
                    {
                        case 0:
                            if (lemonadeStand.money>=.86)
                            {
                                inventory.cups += 25;
                                lemonadeStand.money -= .86;
                            }
                            else
                            {
                                DisplayBrokePerson();
                            }
                            
                            break;
                        case 1:
                            if (lemonadeStand.money >= 1.63)
                            {
                                inventory.cups += 50;
                            lemonadeStand.money-=1.63;
                            }
                            else
                            {
                                DisplayBrokePerson();
                            }
                            break;
                        case 2:
                            if (lemonadeStand.money >=2.75)
                            {
                                inventory.cups += 100;
                            lemonadeStand.money -= 2.75;
                            }
                            else
                            {
                                DisplayBrokePerson();
                            }
                            break;
                    }
                    break;
                case 1:
                    switch (itemKeyCounter)
                    {
                        case 0:
                             if (lemonadeStand.money>=.64)
                            {
                            inventory.lemons += 10;
                            lemonadeStand.money -= .64;
                            }
                            else
                            {
                                DisplayBrokePerson();
                            }
                            break;
                        case 1:
                             if (lemonadeStand.money>=2.16)
                            {
                            inventory.lemons += 30;
                            lemonadeStand.money -= 2.16;
                            }
                            else
                            {
                                DisplayBrokePerson();
                            }
                            break;
                        case 2:
                             if (lemonadeStand.money>=4.19)
                            {
                            inventory.lemons += 75;
                            lemonadeStand.money -= 4.19;
                            }
                            else
                            {
                                DisplayBrokePerson();
                            }
                            break;
                    }
                    break;
                case 2:
                    switch (itemKeyCounter)
                    {
                        case 0:
                             if (lemonadeStand.money>=.51)
                            {
                            inventory.sugar += 8;
                            lemonadeStand.money -= .51;
                            }
                            else
                            {
                                DisplayBrokePerson();
                            }
                            break;
                        case 1:
                             if (lemonadeStand.money>=1.63)
                            {
                            inventory.sugar += 20;
                            lemonadeStand.money -= 1.63;
                            }
                            else
                            {
                                DisplayBrokePerson();
                            }
                            break;
                        case 2:
                             if (lemonadeStand.money>=3.28)
                            {
                            inventory.sugar += 48;
                            lemonadeStand.money -= 3.28;
                            }
                            else
                            {
                                DisplayBrokePerson();
                            }
                            break;
                    }
                    break;
                case 3:
                    switch (itemKeyCounter)
                    {
                        case 0:
                             if (lemonadeStand.money>=.88)
                            {
                            inventory.ice += 100;
                            lemonadeStand.money -= .88;
                            }
                            else
                            {
                                DisplayBrokePerson();
                            }
                            break;
                        case 1:
                             if (lemonadeStand.money>=2.00)
                            {
                            inventory.ice += 250;
                            lemonadeStand.money -= 2.00;
                            }
                            else
                            {
                                DisplayBrokePerson();
                            }
                            break;
                        case 2:
                             if (lemonadeStand.money>=3.66)
                            {
                            inventory.ice += 500;
                            lemonadeStand.money -= 3.66;
                            }
                            else
                            {
                                DisplayBrokePerson();
                            }
                            break;
                    }
                    break;
            }

        }

        public void DisplayBrokePerson()
        {
            Console.WriteLine("You are BROKE, be better!");
            Console.ReadLine();
        }
    }
}
