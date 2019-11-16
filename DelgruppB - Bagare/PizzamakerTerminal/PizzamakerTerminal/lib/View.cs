using System;
using System.Collections.Generic;
using System.Text;

namespace PizzamakerTerminal
{
    class View
    {
        public static void DisplayIntro()
        {
            Console.WriteLine("---------------------------------------------------------");
            Console.WriteLine("-                                                       -");
            Console.WriteLine("-                   PIZZERIA PALATSEN                   -");
            Console.WriteLine("-                                                       -");
            Console.WriteLine("---------------------------------------------------------");
        }

        public static void DisplayWelcome()
        {
            Console.WriteLine("\nVälkommen till Pizzeria Palatsen!");
        }
        public static void DisplayOven()
        {
            Console.Clear();
            Console.WriteLine("---------------------------------------------------------");
            Console.WriteLine("-                                                       -");
            Console.WriteLine("-                   PIZZERIA PALATSEN                   -");
            Console.WriteLine("-                                                       -");
            Console.WriteLine("---------------------------------------------------------");
            Console.WriteLine("\n");

            Console.WriteLine("Beställningsinformation: ");
            Console.WriteLine(" ");
        }

        public static void DisplayHeader()
        {
            Console.Write("Pizza-Palatset. Current username: \u001b[31m\u001b[47m{0}\u001b[0m\n", Status.CurrentUserName);
            Console.Write("Tangenter: 0 == logga ut, Enter == Generera Order, '-' == Ta bort Färdiga, 1-9 == Baka\n");
        }
        public static void DisplayOrders()
        {
            Console.Write("\n\u001b[35m{0}\u001b[0m\n", "Active Orders");
            foreach (Order incomplete in Queue.GetIncompleteOrders() )
            {
                Console.Write("\tid:{2} name: {0} [{1}] \n", incomplete.GetName(), incomplete.GetIngredients(), incomplete.ID);
            }

            Console.Write("\n\u001b[32m{0}\u001b[0m\n", "Complete Orders");
            foreach (Order complete in Queue.GetCompletedOrders())
            {
                Console.Write("\tid:{2} name: {0} [{1}] \n", complete.GetName(), complete.GetIngredients(), complete.ID);
            }
        }
    }
}
