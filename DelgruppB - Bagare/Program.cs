using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace DelgruppB___Bagare
{
    class Program
    {
        static void Main(string[] args)
        {
            // Settings
            Config.ConfigurateConsole();
            Config.SetEnvironment();

            Generator generator = new Generator();
            generator.Initiate();

            var pizzor = new List<string>();
            pizzor.Add("Vesuvio");
            pizzor.Add("Hawaii");
            pizzor.Add("Kebabpizzza");

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

                foreach (string pizza in pizzor)
                {
                    Console.Write("{0}\n", pizza);
                }


                var regex = new Regex(@"[1-9]");


            } while (key != 'q');
        }
    }
}
