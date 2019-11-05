using System;
using System.Collections.Generic;
using System.Linq;

namespace PizzaPalatsetG1
{
    public delegate Item FakeEvent(int a, int b);
   
    public abstract class Terminal
    {
        protected bool isInteractable;
        public delegate int MatchDelegate(int a, int b); // todo;
        System.Timers.Timer fake_events = new System.Timers.Timer(); // todo;
        public abstract void Run();
        // try
            // {
            //     Console.Clear();
            //     Console.SetCursorPosition(0, 0);

            //     items.ForEach(item =>
            //     {
            //         Console.Write($"{item.id}\t{item.name}\t\t{item.price}:- \n");
            //     });

            //     var key = new ConsoleKeyInfo().KeyChar;
            //     do
            //     {
            //         int i = 0;
            //         // Loop som väntar på att knapp trycks
            //         while (Console.KeyAvailable == false)
            //         {
            //             System.Threading.Thread.Sleep(50);
            //         }
            //         // Allt nedanför körs bara efter knapptryck, annars en evig loop'
            //         //--------------------------------
            //         key = Console.ReadKey(true).KeyChar;

            //         var regex = new Regex(@"[1-9]");

            //         if (regex.IsMatch(key.ToString()))
            //         {
            //             int n = int.Parse(key.ToString());
            //             Item purch = items[n];
            //             cart.Add(purch);
            //         }

            //         items.ForEach(item =>
            //         {
            //             Console.SetCursorPosition(0, i);
            //             Console.Write($"{item.id}\t{item.name}\t\t...{item.price}:-");
            //             i++;
            //         });

            //         cart.ForEach(item =>
            //         {
            //             Console.SetCursorPosition(0, i + 2);
            //             Console.Write($"{item.id}\t{item.name}");
            //             i++;
            //         });

            //     } while (key != 'z');

            // }
            // catch (DivideByZeroException e)
            // {
            //     Console.ForegroundColor = ConsoleColor.DarkRed;
            //     Console.BackgroundColor = ConsoleColor.White;
            //     Console.Write(e);
            // }
            // catch (System.Exception e)
            // {
            //     Console.ForegroundColor = ConsoleColor.Magenta;
            //     Console.Write($"{e}\n");

            // }
            // finally
            // {
            //     Console.ResetColor();
            //     Console.Write("\n");
            // }
            // Console.Write("Press any key to quit\n");
            // //Console.ReadKey();
        //public Item GenerateFakeOrder(){}
    }
}
