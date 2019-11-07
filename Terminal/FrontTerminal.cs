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
 
            var key = new ConsoleKeyInfo().KeyChar;
            do
            {
                // Väntar på knapptryck, annars en evig loop'
                while (Console.KeyAvailable == false)
                {
                    System.Threading.Thread.Sleep(50);
                }
                key = Console.ReadKey(true).KeyChar;
                var regex = new Regex(@"[1-9]");

                //////////////////////////////////
                /// 
                ///      LOGIK HÄR
                /// 
                ///////////////////////////////////

            } while (key != 'q'); // q för att quitta

        }
    }
}
