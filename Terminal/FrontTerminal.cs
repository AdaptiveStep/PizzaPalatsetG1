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
            Console.SetCursorPosition(x, y);

            Menu menu = Helper.GenerateMenu();
            Cart cart = new Cart();
            cart_x = (Console.WindowWidth / 2) - (cart.GetAverageItemNameLength() / 2);
            cart_y = Console.WindowHeight / 2;

            // Window Refreshed Loop Below
            var key = new ConsoleKeyInfo().KeyChar;
            do
            {
                // Väntar på knapptryck, annars en evig loop'
                while (Console.KeyAvailable == false)
                {
                    System.Threading.Thread.Sleep(50);
                }
                //
                key = Console.ReadKey(true).KeyChar;
                var regex = new Regex(@"[1-9]");



                if (regex.IsMatch(key.ToString()))
                {
                    int n = int.Parse(key.ToString());
                    cart.AddItem(menu.items[n]);

                }
                menu.items.ForEach(item =>
                {
                    Console.Write($"{item.id}\t{item.name}\t\t...{item.price}:-");
                });

                cart.items.ForEach(item => {
                    Console.SetCursorPosition(cart_x, cart_y);
                    Console.Write($"{item.id}\t{item.name}");
                }); 
                // cart.ForEach(item =>
                // {
                //     Console.SetCursorPosition(0, i + 2);
                //     Console.Write($"{item.id}\t{item.name}");
                //     i++;
                // });


            } while (key != 'q'); // q för att quitta

        }
    }
}
