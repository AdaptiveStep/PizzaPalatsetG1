using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using Console = Colorful.Console;

namespace InfoSkärmar
{
    class MainMenu
    {
        public static void Menu()
        {
            Console.WriteAscii("PIZZA PALATSET", Color.Red);

            Console.WriteLine($"\t Pågående ordrar\t\t\t\tKlara ordrar");
            Console.WriteLine($" ______________________________\t\t\t______________________________");
            
        }

    }
}
