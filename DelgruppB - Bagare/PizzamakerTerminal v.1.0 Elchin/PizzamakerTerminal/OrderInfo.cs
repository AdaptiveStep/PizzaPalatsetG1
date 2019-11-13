using System;
using System.Collections.Generic;
using System.Threading;

namespace PizzamakerTerminal
{
    class OrderInfo
    {
        public static List<Order> completeOrders = new List<Order>();

        // methoden öppnar aktiverande beställningar
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

            switch (orderID)
            {
                case 1:
                    Console.WriteLine("# 1\n");
                    Console.WriteLine("1 - Vesuvio\n2 - Capricciosa (en med extra oliver)");
                    Console.WriteLine($"\nBeställningstid: {DateTime.Now.ToShortTimeString()}");
                    Console.Beep();
                    Console.WriteLine("\n\nTryck på någon knapp för att stoppa pizzan i ugnen.");
                    Console.ReadKey();
                    Console.Clear();
                    Console.WriteLine("Beställning 1\nbakas ...");
                    Thread.Sleep(5000);
                    Console.Beep();
                    Console.WriteLine("\nBeställning 1 är färdig");
                    completeOrders.Add(new Order("Beställning 1"));
                    Console.WriteLine("\n\nTryck på någon knapp för att komma till bestäningsmenyn");
                    Console.ReadKey();
                    User.OrderTerminal();
                    break;

                case 2:
                    Console.WriteLine("# 2\n");
                    Console.WriteLine("3 - Pasta Carbonara\n1 - Vegetarisk ");
                    Console.WriteLine($"\nBeställningstid: {DateTime.Now.ToShortTimeString()}");
                    Console.Beep();
                    Console.WriteLine("\n\nTryck på någon knapp för att stoppa pizzan i ugnen.");
                    Console.ReadKey();
                    Console.Clear();
                    Console.WriteLine("\nBeställning 2\nbakas ...");
                    Thread.Sleep(5000);
                    Console.Beep();
                    Console.WriteLine("Beställning 2 är färdig");
                    completeOrders.Add(new Order("Beställning 2"));
                    Console.WriteLine("\n\nTryck på någon knapp för att komma till bestäningsmenyn");
                    Console.ReadKey();
                    User.OrderTerminal();
                    break;

                case 3:
                    Console.WriteLine("# 3\n");
                    Console.WriteLine("1 - Hawaii\n1 - Vesuvio \n1 - Margherita");
                    Console.WriteLine($"\nBeställningstid: {DateTime.Now.ToShortTimeString()}");
                    Console.Beep();
                    Console.WriteLine("\n\nTryck på någon knapp för att stoppa pizzan i ugnen.");
                    Console.ReadKey();
                    Console.Clear();
                    Console.WriteLine("Beställning 3\nbakas ...");
                    Thread.Sleep(5000);
                    Console.Beep();
                    Console.WriteLine("\nBeställning 3 är färdig");
                    completeOrders.Add(new Order("Beställning 3"));
                    Console.WriteLine("\n\nTryck på någon knapp för att komma till bestäningsmenyn");
                    Console.ReadKey();
                    User.OrderTerminal();
                    break;

                case 4:
                    Console.WriteLine("# 4\n");
                    Console.WriteLine("1 - Avocado sallad\n1 - Pasta Marinara \n2 - Pepperoni \n1 - Vesuvio");
                    Console.WriteLine($"\nBeställningstid: {DateTime.Now.ToShortTimeString()}");
                    Console.Beep();
                    Console.WriteLine("\n\nTryck på någon knapp för att stoppa pizzan i ugnen.");
                    Console.ReadKey();
                    Console.Clear();
                    Console.WriteLine("Beställning 4\nbakas ...");
                    Thread.Sleep(5000);
                    Console.Beep();
                    Console.WriteLine("\nBeställning 4 är färdig");
                    completeOrders.Add(new Order("Beställning 4"));
                    Console.WriteLine("\n\nTryck på någon knapp för att komma till bestäningsmenyn");
                    Console.ReadKey();
                    User.OrderTerminal();
                    break;

                default:
                    Console.WriteLine("Var snäll att välja korrekt ordernummer. ");
                    goto case 1;
            }

        }
    }
}
