/* Projekt Pizzeria Palatsen
 * 
 * Bagarens terminal
 * 
 * Version 1.1
 * elchinoj08@gmail.com 
 * Elchin J. (group 1)
 */



// Programmet simulerar Bagarens-terminal. 
// Användaren får 4 olika val att logga in med unika användernamn och unika lösenord.
// Programmet simulerar inkommande beställningar med sina egna beställningsnummer genom att trycka på 'Enter' knappen.
// Man får välja beställningsinformation från inkommande beställnig som öppnas i nytt fönstret och 
// simulerar bakning.
// Simulering skätmen tar ungefär 5 sekunder och beställningen lagras i en färdig gjord beställningslista.
// Finss möjlighet att simulera kundens avhämtning av beställningen genom att trycka på minusknappen '-'

using System;

namespace PizzamakerTerminal
{
    class Program
    {
        // Välkommensmeny på bagarensterminal
        public static void Main()
        {
            Console.WriteLine("---------------------------------------------------------");
            Console.WriteLine("-                                                       -");
            Console.WriteLine("-                   PIZZERIA PALATSEN                   -");
            Console.WriteLine("-                                                       -");
            Console.WriteLine("---------------------------------------------------------");


            // anropar bagarens inloggningsmeny
            Cock.LogIn();
        }
    }
}
