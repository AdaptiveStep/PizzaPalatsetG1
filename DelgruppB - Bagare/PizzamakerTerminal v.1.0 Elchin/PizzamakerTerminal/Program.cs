/* Projekt Pizzeria Palatsen
 * 
 * Bagarens terminal
 * 
 * Version 1.0
 * Elchin Jabbari group 1
 */



using System;

namespace PizzamakerTerminal
{
    class Program
    {
        // Välkommensmeny på bagarensterminal
        static void Main(string[] args)
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
