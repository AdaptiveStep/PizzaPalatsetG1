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
                string input = action.KeyChar.ToString();

                // Enter        => Ny beställning simuleras 
                // [1 - 9]      => Öppnas slumpa beställningarsinformation.
                // subtract '-' => Valet raderas den första klargjorda beställningen från listan.

                if (int.TryParse(input,out int res) && res >= 1 && res <= 9)
                {
                    OrderInfo.ActivateOrder(res);
                }
                else if (action.Key == ConsoleKey.Enter)
                {
                    int orderNumber = initialOrder + activeOrders.Count;
                    OrderReceive(orderNumber);
                }
                else if (action.Key == ConsoleKey.Subtract)
                {
                    DismissOrder();
                }
                else if (action.Key == ConsoleKey.NumPad0)
                {
                    Console.Clear();
                    Program.Main();
                }
                else
                {
                    Console.WriteLine("\nFel val. Försök igen"); // Om ingen passande val har blivit valt OrderTerminal() metod körs igen
                    Console.ReadKey();
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
