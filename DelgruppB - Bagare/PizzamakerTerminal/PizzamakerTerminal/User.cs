using System;

namespace PizzamakerTerminal
{
    class User
    {
        // Mottagna beställningar och beställningsstatus metod 
        public static void OrderTerminal(short userID)
        {
            Console.Clear();
            Console.WriteLine("---------------------------------------------------------");
            Console.WriteLine("-                                                       -");
            Console.WriteLine("-                   PIZZERIA PALATSEN                   -");
            Console.WriteLine("-                                                       -");
            Console.WriteLine("---------------------------------------------------------");
            Console.WriteLine("\n");

            Console.WriteLine($"\t\t\tWelcome User #{userID}");
            Console.WriteLine("\nTryck 0 för att logga ut");
            Console.WriteLine("______________________________________________________\n\n");


            // två olika fälte för pågående beställningar och färdiga beställningar
            Console.Write("Beställningslista: \t\tFärdiga beställningar:\n\n");
            for (int i = 0; i < OrderSelection.activeOrders.Count; i++)
            {
                Console.Write(OrderSelection.activeOrders[i].GetName() + "\n");
            }

            for (int i = 0; i < OrderInfo.completeOrders.Count; i++)
            {
                Console.WriteLine("\t\t\t\t" + OrderInfo.completeOrders[i].GetName());
            }

            // Anropar beställningslista att göra val
            OrderSelection.OrderChoice();
        }
    }
}
