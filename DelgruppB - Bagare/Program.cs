using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace DelgruppB___Bagare
{
    class Program
    {
        static void Main(string[] args)
        {
            // Settings
            Console.CursorVisible = false;
            //
            Generator generator = new Generator();
            generator.Initiate();

            var key = new ConsoleKeyInfo().KeyChar;
            do
            {
                // Loop som väntar på att knapp trycks
                while (Console.KeyAvailable == false)
                {
                    System.Threading.Thread.Sleep(20);
                }
                // Allt nedanför körs bara efter knapptryck, annars en evig loop'
                //--------------------------------
                key = Console.ReadKey(true).KeyChar;

                var regex = new Regex(@"[1-9]");


            } while (key != 'q');
        }
    }
}
