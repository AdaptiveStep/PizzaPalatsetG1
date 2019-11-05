using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace PizzaPalatsetG1
{
    public class FrontTerminal : Terminal
    {
        public FrontTerminal()
        {
            isInteractable = true;
        }
        public override void Run()
        {
            Console.Clear();
            Console.CursorVisible = false;

            Menu menu = Helper.GenerateMenu();
            Cart cart = new Cart();
            cart_x = (Console.WindowWidth / 2) - menu.GetAverageItemNameLength();
            cart_y = Console.WindowHeight / 2;
      
            menu.items.ForEach(item =>
            {
                Console.SetCursorPosition(cart_x, y);
                Console.Write($"{item.id} {item.name} ...{item.price}:-");
                y++;
            });

            // Window Refreshed Loop Below
            var key = new ConsoleKeyInfo().KeyChar;
            do
            {
                y = 0;
                // Väntar på knapptryck, annars en evig loop'
                while (Console.KeyAvailable == false)
                {
                    System.Threading.Thread.Sleep(50);
                }
                
                key = Console.ReadKey(true).KeyChar;
                var regex = new Regex(@"[1-9]");

                if (regex.IsMatch(key.ToString()))
                {
                    int n = int.Parse(key.ToString());
                    cart.AddItem(menu.items[n]);
                }

                menu.items.ForEach(item =>
                {
                    Console.SetCursorPosition(cart_x, y);
                    Console.Write($"{item.id} {item.name} ...{item.price}:-");
                    y++;
                });

                cart.items.ForEach(item => {
                    Console.SetCursorPosition(cart_x, y + 4);
                    Console.Write($"{item.id}\t{item.name}");
                    y++;
                });

                y = 0;
            } while (key != 'q'); // q för att quitta
        }
    }
}
