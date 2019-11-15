using System;
using System.Threading;

namespace PizzamakerTerminal
{
    class User
    {
        // Mottagna beställningar och beställningsstatus metod 
        public static void OrderTerminal()
        {
            Console.Clear();
            Console.WriteLine("---------------------------------------------------------");
            Console.WriteLine("-                                                       -");
            Console.WriteLine("-                   PIZZERIA PALATSEN                   -");
            Console.WriteLine("-                                                       -");
            Console.WriteLine("---------------------------------------------------------");
            Console.WriteLine("\n");

            // två olika fälte för pågående beställningar och färdiga beställningar
            Console.Write("Beställningslista: ");
            Console.WriteLine("\t\tFärdiga beställningar:");
            for (int i = 0; i < OrderInfo.completeOrders.Count; i++)
            {
                Console.WriteLine("\t\t\t\t" + OrderInfo.completeOrders[i].GetName());
            }

            // Anropar beställningslista och att göra val
            OrderSelection.OrderChoice();
        }



        // ----------- FUNKAR INTE !!!!!!!!!!!!!!!!! -----------------
        // -----------------------------------------------------------
        // den första beställningen försvinner från färdiga beställningslistan 
        // efter den hämtas av kunden (10 sekunder ungefär)
        public void CompleteOrder()
        {
            int orderIndex = 0;
            do
            {
                Thread.Sleep(10000);
                OrderInfo.completeOrders.RemoveAt(orderIndex);
                orderIndex++;
            } while (OrderInfo.completeOrders != null);
        }
    }
}
