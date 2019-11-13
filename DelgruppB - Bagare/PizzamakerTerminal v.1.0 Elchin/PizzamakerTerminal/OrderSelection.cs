using System;
using System.Collections.Generic;

namespace PizzamakerTerminal
{
    class OrderSelection
    {
        public static List<Order> activeOrders = new List<Order>();

        // Metod som hjälper välja valet
        public static void OrderChoice()
        {
            short orderNumber = 0;
            while (true)
            {
                ConsoleKeyInfo action = Console.ReadKey();

                // Vid Enter knappen adderas ny beställning på beställningslista. 
                //Vid valet mellan 1 och 9 öppnas slumpa beställningarsinformation.
                if (action.Key == ConsoleKey.Enter)
                {
                    orderNumber++;
                    OrderReceive(orderNumber);
                }
                if (action.Key == ConsoleKey.NumPad1)
                {
                    activeOrders.Add(new Order("Beställning 1"));
                    OrderInfo.ActivateOrder(1);
                }
                if (action.Key == ConsoleKey.NumPad2)
                {
                    activeOrders.Add(new Order("Beställning 2"));
                    OrderInfo.ActivateOrder(2);
                }
                if (action.Key == ConsoleKey.NumPad3)
                {
                    activeOrders.Add(new Order("Beställning 3"));
                    OrderInfo.ActivateOrder(3);
                }
                if (action.Key == ConsoleKey.NumPad4)
                {
                    activeOrders.Add(new Order("Beställning 4"));
                    OrderInfo.ActivateOrder(4);
                }
                if (action.Key == ConsoleKey.NumPad5)
                {
                    activeOrders.Add(new Order("Beställning 5"));
                    OrderInfo.ActivateOrder(5);
                }
                if (action.Key == ConsoleKey.NumPad6)
                {
                    activeOrders.Add(new Order("Beställning 6"));
                    OrderInfo.ActivateOrder(6);
                }
                if (action.Key == ConsoleKey.NumPad7)
                {
                    activeOrders.Add(new Order("Beställning 7"));
                    OrderInfo.ActivateOrder(7);
                }
                if (action.Key == ConsoleKey.NumPad8)
                {
                    activeOrders.Add(new Order("Beställning 8"));
                    OrderInfo.ActivateOrder(8);
                }
                if (action.Key == ConsoleKey.NumPad9)
                {
                    activeOrders.Add(new Order("Beställning 9"));
                    OrderInfo.ActivateOrder(9);
                }
                // Om ingen passande val blev valt OrderTerminal() metod körs igen
                if (action.Key != ConsoleKey.Enter && action.Key != ConsoleKey.NumPad1 && action.Key != ConsoleKey.NumPad2
                    && action.Key != ConsoleKey.NumPad3 && action.Key != ConsoleKey.NumPad4 && action.Key != ConsoleKey.NumPad5
                    && action.Key != ConsoleKey.NumPad6 && action.Key != ConsoleKey.NumPad7 && action.Key != ConsoleKey.NumPad8
                    && action.Key != ConsoleKey.NumPad9)
                {
                    Console.WriteLine("\nFel val. Försök igen");
                    Console.ReadKey();
                    User.OrderTerminal();
                }
            }
        }

        // Vid Enter knappen har valt ny beställning visas på skärmen
        public static void OrderReceive(short orderNumber)
        {
            Random random = new Random();

            Console.WriteLine($"Beställning #{orderNumber}");
            Console.Beep();
            orderNumber++;
        }
    }
}
