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
            Console.WriteLine("This is your current recipe! Type the name of );
            Console.WriteLine("Lemons:      "+recipe.lemonsToUse);
            Console.WriteLine("Sugar:       "+recipe.sugarToUse);
            Console.WriteLine("Ice:         "+recipe.iceToUse);

        }

     
    }
}
