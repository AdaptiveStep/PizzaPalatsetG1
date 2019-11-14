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
            if (orderNum == 1)
            {
                Order1(orderNum);
            }
            else if (orderNum == 2)
            {
                Order2(orderNum);
            }
            else if (orderNum == 3)
            {
                Order3(orderNum);
            }
            else if (orderNum == 4)
            {
                Order4(orderNum);
            }
            else if (orderNum == 5)
            {
                Order5(orderNum);
            }
            else if (orderNum == 6)
            {
                Order6(orderNum);
            }
            else if (orderNum == 7)
            {
                Order7(orderNum);
            }
            else if (orderNum == 8)
            {
                Order8(orderNum);
            }
            else if (orderNum == 9)
            {
                Order9(orderNum);
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
        public static void Order1(int orderNum)
        {
            Console.WriteLine("1 - Vesuvio\n2 - Capricciosa (en med extra oliver)");
        }
        public static void Order2(int orderNum)
        {
            Console.WriteLine("3 - Pasta Carbonara\n1 - Vegetarisk ");
        }
        public static void Order3(int orderNum)
        {
            Console.WriteLine("1 - Hawaii\n1 - Vesuvio \n1 - Margherita");
        }
        public static void Order4(int orderNum)
        {
            Console.WriteLine("1 - Avocado sallad\n1 - Pasta Marinara \n2 - Pepperoni \n1 - Vesuvio");
        }
        public static void Order5(int orderNum)
        {
            Console.WriteLine("1 - Pasta Frutti Di Mare\n1 - Vesuvio med kebabkött");
        }
        public static void Order6(int orderNum)
        {
            Console.WriteLine("1 - Cesar sallad\n1 - Pasta Marinara \n2 - Hawaii \n1 - Vesuvio \n1 - Vegetarisk \n1 - Margherita");
        }
        public static void Order7(int orderNum)
        {
            Console.WriteLine("1 - Pasta Carbonara \n2 - Kebabpizza");
        }
        public static void Order8(int orderNum)
        {
            Console.WriteLine("1 - Pepperoni med extra tomater och sardeller");
        }
        public static void Order9(int orderNum)
        {
            Console.WriteLine("1 - Vesuvio");
        }
    }
}
