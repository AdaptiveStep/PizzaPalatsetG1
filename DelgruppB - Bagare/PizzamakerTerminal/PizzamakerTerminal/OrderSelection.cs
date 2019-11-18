using System;
using System.Collections.Generic;
using System.Linq;

namespace PizzamakerTerminal
{
    class OrderSelection
    {
        public static void OrderChoice(ConsoleKeyInfo key)
        {
            string input = key.KeyChar.ToString();

            // Enter        => Ny beställning simuleras 
            // [1 - 9]      => Öppnas slumpa beställningarsinformation.
            // subtract '-' => Valet raderas den första klargjorda beställningen från listan.

            if (int.TryParse(input, out int res) && res >= 1 && res <= 9)
            {
                //OrderInfo.ActivateOrder(res);
                var orderToBake = Queue.GetOrderById(res);
                if(orderToBake != null && orderToBake.isComplete != true)
                {
                    //BAKE
                    Console.Clear();
                    Console.Write("BAKING order {0} {1} [{2}]\n",orderToBake.ID, orderToBake.GetName(), orderToBake.GetIngredients());
                    
                    // Animera en loading bar
                    foreach(char dot in new char[5] { '.', '.', '.','.','.' })
                    {
                        Console.Write(dot);
                        System.Threading.Thread.Sleep(900);
                    }
                    Console.Beep();
                    // Set Order som klar
                    orderToBake.isComplete = true;

                    Console.Write("\nKlar! Tryck på valfri knapp för att gå tillbaka\n");
                    Console.ReadKey();
                }
            }
            else if (key.Key == ConsoleKey.Enter &&  Queue.CountTotalOrders() < Status.MaxOnGoingOrders)
            {
                Data.GeneraterOrder();
            }
            else if (key.Key == ConsoleKey.Subtract || key.Key == ConsoleKey.OemMinus)
            {
                Queue.DeleteFirstCompleteOrder();
            }
            else if (key.Key == ConsoleKey.NumPad0 || key.Key == ConsoleKey.D0)
            {
                foreach(var item in Queue.OrderList.ToList())
                {
                    if (item.isComplete)
                    {
                        Queue.DeleteOrderById(item.ID);
                    }
                }
                Cock.Logout();
                
                Console.Clear();
            }
            else
            {
                //Console.Beep(); // Error Beep när
            }
        }
    }
}
