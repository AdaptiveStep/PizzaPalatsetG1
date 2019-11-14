using System;
using System.Collections.Generic;

namespace PizzamakerTerminal
{
    class OrderSelection
    {
        public static List<ActiveOrder> activeOrders = new List<ActiveOrder>();


        // Metod som hjälper välja valet
        public static void OrderChoice()
        {
            int initialOrder = 1;
            while (true)
            {
                ConsoleKeyInfo action = Console.ReadKey();

                // Vid Enter knappen adderas ny beställning på beställningslista. 
                // Vid valet mellan 1 och 9 öppnas slumpa beställningarsinformation.
                // Vid subtract '-' valet raderas den första klargjorda beställningen från listan.
                if (action.Key == ConsoleKey.Enter)
                {
                    int orderNumber = initialOrder + activeOrders.Count;
                    OrderReceive(orderNumber);
                }
                if (action.Key == ConsoleKey.NumPad1)
                {
                    OrderInfo.ActivateOrder(1);
                }
                if (action.Key == ConsoleKey.NumPad2)
                {

                    OrderInfo.ActivateOrder(2);
                }
                if (action.Key == ConsoleKey.NumPad3)
                {

                    OrderInfo.ActivateOrder(3);
                }
                if (action.Key == ConsoleKey.NumPad4)
                {

                    OrderInfo.ActivateOrder(4);
                }
                if (action.Key == ConsoleKey.NumPad5)
                {

                    OrderInfo.ActivateOrder(5);
                }
                if (action.Key == ConsoleKey.NumPad6)
                {

                    OrderInfo.ActivateOrder(6);
                }
                if (action.Key == ConsoleKey.NumPad7)
                {

                    OrderInfo.ActivateOrder(7);
                }
                if (action.Key == ConsoleKey.NumPad8)
                {

                    OrderInfo.ActivateOrder(8);
                }
                if (action.Key == ConsoleKey.NumPad9)
                {

                    OrderInfo.ActivateOrder(9);
                }
                if (action.Key == ConsoleKey.Subtract)
                {
                    DismissOrder();
                }
                if (action.Key == ConsoleKey.NumPad0)
                {
                    Console.Clear();
                    Program.Main();
                }
                // Om ingen passande val har blivit valt OrderTerminal() metod körs igen
                if (action.Key != ConsoleKey.Enter && action.Key != ConsoleKey.NumPad1 && action.Key != ConsoleKey.NumPad2
                    && action.Key != ConsoleKey.NumPad3 && action.Key != ConsoleKey.NumPad4 && action.Key != ConsoleKey.NumPad5
                    && action.Key != ConsoleKey.NumPad6 && action.Key != ConsoleKey.NumPad7 && action.Key != ConsoleKey.NumPad8
                    && action.Key != ConsoleKey.NumPad9 && action.Key != ConsoleKey.Subtract && action.Key != ConsoleKey.NumPad0)
                {
                    Console.WriteLine("\nFel val. Försök igen");
                    Console.ReadKey();
                    User.OrderTerminal(Cock.user);
                }
            }
        }

        // Vid Enter knappen ny beställning adderas i listan och visas på skärmen
        public static void OrderReceive(int orderNumber)
        {
            activeOrders.Add(new ActiveOrder($"Beställning {orderNumber}"));
            Console.WriteLine($"Beställning {orderNumber}");
            Console.Beep();
        }

        // Vid subtract '-' knappen den första klardjorda beställningen tas bort från listan och skätmen
        public static void DismissOrder()
        {
            while (OrderInfo.completeOrders.Count != 0)
            {
                OrderInfo.completeOrders.RemoveAt(0);
                User.OrderTerminal(Cock.user);
            }
        }
    }
}
