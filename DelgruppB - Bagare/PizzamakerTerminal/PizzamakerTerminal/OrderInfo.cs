using System;
using System.Collections.Generic;
using System.Threading;

namespace PizzamakerTerminal
{
    class OrderInfo
    {
        public static List<CompleteOrder> completeOrders = new List<CompleteOrder>();

        // Metoden öppnar aktiverande beställningar
        public static void ActivateOrder(int orderID)
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

            int orderNum = orderID;
            OrderContent(orderNum);
        }

        // 9 olika beställningar med inehållsinformation och tidsinformation 
        public static void OrderContent(int orderNum)
        {
            Console.WriteLine($"Beställning # {orderNum}\n");
            if (orderNum <= 1 && orderNum >= 9)
            {
                Order(orderNum);
            }
            Console.WriteLine($"\nBeställningstid: {DateTime.Now.ToShortTimeString()}");
            Console.Beep();
            Console.WriteLine("\n\nTryck på någon knapp för att stoppa pizzan i ugnen.");
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine($"Beställning {orderNum}\nbakas ...");
            Thread.Sleep(5000);
            Console.Beep();
            Console.WriteLine($"\nBeställning {orderNum} är färdig");
            completeOrders.Add(new CompleteOrder($"Beställning {orderNum}"));
            Console.WriteLine("\n\nTryck på någon knapp för att komma till beställningsmenyn");
            Console.ReadKey();
            User.OrderTerminal(Cock.user);
        }
        public static void Order(int n)
        {
            List<string> orderList = new List<string>()
            {
                "1 - Vesuvio\n2 - Capricciosa (en med extra oliver)",
                "3 - Pasta Carbonara\n1 - Vegetarisk",
                "1 - Hawaii\n1 - Vesuvio \n1 - Margherita",
                "1 - Avocado sallad\n1 - Pasta Marinara \n2 - Pepperoni \n1 - Vesuvio",
                "1 - Vesuvio\n2 - Capricciosa (en med extra oliver)",
                "1 - Pasta Frutti Di Mare\n1 - Vesuvio med kebabkött",
                "1 - Vesuvio\n2 - Capricciosa (en med extra oliver)",
                "1 - Cesar sallad\n1 - Pasta Marinara \n2 - Hawaii \n1 - Vesuvio \n1 - Vegetarisk \n1 - Margherita",
                "1 - Pasta Carbonara \n2 - Kebabpizza",
                "1 - Pepperoni med extra tomater och sardeller",
                "1 - Vesuvio"
            };
            Console.WriteLine(orderList[n]);
        }
    }
}
