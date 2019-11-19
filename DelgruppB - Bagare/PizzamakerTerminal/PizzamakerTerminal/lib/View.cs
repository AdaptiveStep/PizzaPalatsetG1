using System;

namespace PizzamakerTerminal
{
    class View
    {
        private class Color
        {
            public class ForeGround
            {
                public static string Black = "\u001b[30m";
                public static string Red = "\u001b[31m";
                public static string Green = "\u001b[32m";
                public static string Yellow = "\u001b[33m";
                public static string Blue = "\u001b[34m";
                public static string Magenta = "\u001b[35m";
                public static string Cyan = "\u001b[36m";
                public static string White = "\u001b[37m";
            }
            public class BackGround
            {
                public static string Black = "\u001b[40m";
                public static string Red = "\u001b[41m";
                public static string Green = "\u001b[42m";
                public static string Yellow = "\u001b[43m";
                public static string Blue = "\u001b[44m";
                public static string Magenta = "\u001b[45m";
                public static string Cyan = "\u001b[46m";
                public static string White = "\u001b[47m";
            }
            public static string Bright = ";1m";
            public static string Reset = "\u001b[0m";
        }
        public static void DisplayIntro()
        {
            Console.WriteLine("---------------------------------------------------------");
            Console.WriteLine("-                                                       -");
            Console.WriteLine("-                   PIZZERIA PALATSEN                   -");
            Console.WriteLine("-                                                       -");
            Console.WriteLine("---------------------------------------------------------");
        }

        public static void DisplayWelcome()
        {
            Console.WriteLine("\nVälkommen till Pizzeria Palatset!");
        }

        public static void DisplayHeader()
        {
            DisplayPizzaLogo();
            Console.Write("\nBagare inloggad: \u001b[31m\u001b[47m{0}\u001b[0m\n", Status.CurrentUserName);
            Console.Write("Tangenter: 0 == logga ut, Enter == Generera Order, '-' == Ta bort Färdiga, 1-9 == Baka\n");
        }
        public static void DisplayOrders()
        {
            Console.Write("\n{0}{1}{2}\n", Color.ForeGround.Magenta, "Aktiva beställningar", Color.Reset);
            foreach (Order incomplete in Queue.GetIncompleteOrders())
            {
                Console.Write("\tid:{2} name: {0} [{1}] \n", incomplete.GetName(), incomplete.GetIngredients(), incomplete.ID);
            }

            Console.Write("\n{0}{1}{2}\n", Color.ForeGround.Green, "Färdiga beställningar", Color.Reset);
            foreach (Order complete in Queue.GetCompletedOrders())
            {
                Console.Write("\tid:{2} name: {0} [{1}] \n", complete.GetName(), complete.GetIngredients(), complete.ID);
            }
        }
        public static void DisplayFancyIntro()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            string pizzalogo = @"   
                                  ██████╗ ██╗███████╗███████╗ █████╗                
                                  ██╔══██╗██║╚══███╔╝╚══███╔╝██╔══██╗               
                                  ██████╔╝██║  ███╔╝   ███╔╝ ███████║               
                                  ██╔═══╝ ██║ ███╔╝   ███╔╝  ██╔══██║               
                                  ██║     ██║███████╗███████╗██║  ██║               
                                  ╚═╝     ╚═╝╚══════╝╚══════╝╚═╝  ╚═╝               
                                                                                    
                  ██████╗  █████╗ ██╗      █████╗ ████████╗███████╗███████╗████████╗
                  ██╔══██╗██╔══██╗██║     ██╔══██╗╚══██╔══╝██╔════╝██╔════╝╚══██╔══╝
                  ██████╔╝███████║██║     ███████║   ██║   ███████╗█████╗     ██║   
                  ██╔═══╝ ██╔══██║██║     ██╔══██║   ██║   ╚════██║██╔══╝     ██║   
                  ██║     ██║  ██║███████╗██║  ██║   ██║   ███████║███████╗   ██║   
                  ╚═╝     ╚═╝  ╚═╝╚══════╝╚═╝  ╚═╝   ╚═╝   ╚══════╝╚══════╝   ╚═╝   
                  
        █████╗█████╗█████╗█████╗█████╗█████╗█████╗█████╗█████╗█████╗█████╗█████╗█████╗█████╗█████╗ 
        ╚════╝╚════╝╚════╝╚════╝╚════╝╚════╝╚════╝╚════╝╚════╝╚════╝╚════╝╚════╝╚════╝╚════╝╚════╝                                                                                                           
                 ██╗██╗                                                                       
                 ╚═╝╚═╝                                                                       
        ██╗   ██╗ █████╗ ██╗     ██╗  ██╗ ██████╗ ███╗   ███╗███╗   ███╗███████╗███╗   ██╗██╗
        ██║   ██║██╔══██╗██║     ██║ ██╔╝██╔═══██╗████╗ ████║████╗ ████║██╔════╝████╗  ██║██║
        ██║   ██║███████║██║     █████╔╝ ██║   ██║██╔████╔██║██╔████╔██║█████╗  ██╔██╗ ██║██║
        ╚██╗ ██╔╝██╔══██║██║     ██╔═██╗ ██║   ██║██║╚██╔╝██║██║╚██╔╝██║██╔══╝  ██║╚██╗██║╚═╝
         ╚████╔╝ ██║  ██║███████╗██║  ██╗╚██████╔╝██║ ╚═╝ ██║██║ ╚═╝ ██║███████╗██║ ╚████║██╗
          ╚═══╝  ╚═╝  ╚═╝╚══════╝╚═╝  ╚═╝ ╚═════╝ ╚═╝     ╚═╝╚═╝     ╚═╝╚══════╝╚═╝  ╚═══╝╚═╝";
            Console.WriteLine(pizzalogo);
            Console.ResetColor();
            Console.WriteLine("{0}{1}{2}", Color.ForeGround.Cyan, "\t\t\t\t\tTryck på valfri tangent för att fortsätta ", Color.Reset);
            Console.ReadKey();
            Console.Clear();
        }
        public static void DisplayPizzaLogo()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            string pizzalogo = @"  
                                  ██████╗ ██╗███████╗███████╗ █████╗                
                                  ██╔══██╗██║╚══███╔╝╚══███╔╝██╔══██╗               
                                  ██████╔╝██║  ███╔╝   ███╔╝ ███████║               
                                  ██╔═══╝ ██║ ███╔╝   ███╔╝  ██╔══██║               
                                  ██║     ██║███████╗███████╗██║  ██║               
                                  ╚═╝     ╚═╝╚══════╝╚══════╝╚═╝  ╚═╝               
                                                                                    
                  ██████╗  █████╗ ██╗      █████╗ ████████╗███████╗███████╗████████╗
                  ██╔══██╗██╔══██╗██║     ██╔══██╗╚══██╔══╝██╔════╝██╔════╝╚══██╔══╝
                  ██████╔╝███████║██║     ███████║   ██║   ███████╗█████╗     ██║   
                  ██╔═══╝ ██╔══██║██║     ██╔══██║   ██║   ╚════██║██╔══╝     ██║   
                  ██║     ██║  ██║███████╗██║  ██║   ██║   ███████║███████╗   ██║   
                  ╚═╝     ╚═╝  ╚═╝╚══════╝╚═╝  ╚═╝   ╚═╝   ╚══════╝╚══════╝   ╚═╝   ";
            Console.Write(pizzalogo);
            Console.ResetColor();
        }
    }
}
