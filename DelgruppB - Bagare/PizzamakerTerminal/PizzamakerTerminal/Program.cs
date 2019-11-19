using System;

/* Projekt Pizzeria Palatsen
 * 
 * Bagarens terminal
 * 
 * Version 2.0
 * elchinoj08@gmail.com 
 * Elchin J. & Jakob A. (group 1)
 * 
 * Support & feedback av jkb (https://jkb.zone)
 * 
 */
namespace PizzamakerTerminal
{
    class Program
    {
        // Välkommensmeny på bagarensterminal
        public static void Main()
        {
            // Hello screen thingy
            View.DisplayFancyIntro();
            // Text som hälsar användaren välkommen till sin egen arbetsplats
            View.DisplayPizzaLogo();
            // 'key' reassignas till så fort ny Console.ReadKey() sker
            ConsoleKeyInfo key = new ConsoleKeyInfo();
            // Startar Programmet med en ny randomiserad order
            Data.GeneraterOrder();

            //
            //  Konstant Main Loop
            //
            while (Status.IsProgramRunning)
            {
                // ------------
                while (Status.IsLoggedIn == false)
                {
                    // LoginCheck som upprepas tills den är godkänd
                    Cock.LogIn();
                    View.DisplayPizzaLogo();
                }

                Console.Clear();

                // 'View' printar långa textstringar
                View.DisplayHeader();
                View.DisplayOrders();

                key = Console.ReadKey(true);

                OrderSelection.OrderChoice(key);

            }
        }
    }
}
