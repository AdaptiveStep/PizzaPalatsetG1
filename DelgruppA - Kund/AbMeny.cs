using System;
using System.Collections.Generic;
using System.Text;

namespace KundTermiPizzaPalatset
{
    public static class AbMeny
    {
        public static void PrintPastaLogo()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            string pastalogo = @"
                        ██████╗  █████╗ ███████╗████████╗ █████╗ 
                        ██╔══██╗██╔══██╗██╔════╝╚══██╔══╝██╔══██╗
                        ██████╔╝███████║███████╗   ██║   ███████║
                        ██╔═══╝ ██╔══██║╚════██║   ██║   ██╔══██║
                        ██║     ██║  ██║███████║   ██║   ██║  ██║
                        ╚═╝     ╚═╝  ╚═╝╚══════╝   ╚═╝   ╚═╝  ╚═╝";
            Console.WriteLine(pastalogo);
            Console.ResetColor();
        }
        public static void PrintExtraLogo()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            string extralogo = @"                  
                                                          ██╗██╗           
                                                          ╚═╝╚═╝    
     ████████╗██╗██╗     ██╗     ██████╗ ███████╗██╗  ██╗ ██████╗ ██████╗ 
     ╚══██╔══╝██║██║     ██║     ██╔══██╗██╔════╝██║  ██║██╔═══██╗██╔══██╗
        ██║   ██║██║     ██║     ██████╔╝█████╗  ███████║██║   ██║██████╔╝
        ██║   ██║██║     ██║     ██╔══██╗██╔══╝  ██╔══██║██║   ██║██╔══██╗
        ██║   ██║███████╗███████╗██████╔╝███████╗██║  ██║╚██████╔╝██║  ██║
        ╚═╝   ╚═╝╚══════╝╚══════╝╚═════╝ ╚══════╝╚═╝  ╚═╝ ╚═════╝ ╚═╝  ╚═╝";
            Console.WriteLine(extralogo);
            Console.ResetColor();
        }
        public static void PrintSaladLogo()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            string saladlogo = @"
                       ███████╗ █████╗ ██╗     ██╗      █████╗ ██████╗ 
                       ██╔════╝██╔══██╗██║     ██║     ██╔══██╗██╔══██╗
                       ███████╗███████║██║     ██║     ███████║██║  ██║
                       ╚════██║██╔══██║██║     ██║     ██╔══██║██║  ██║
                       ███████║██║  ██║███████╗███████╗██║  ██║██████╔╝
                       ╚══════╝╚═╝  ╚═╝╚══════╝╚══════╝╚═╝  ╚═╝╚═════╝ ";
            Console.WriteLine(saladlogo);
            Console.ResetColor();
        }
      
        public static void PrintLogo()
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
            Console.WriteLine(pizzalogo);
            Console.ResetColor();
        }
        
        public static void PrintPayLogo()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            string paylogo = @"
                                ██████╗ ███████╗████████╗ █████╗ ██╗      █████╗ 
                                ██╔══██╗██╔════╝╚══██╔══╝██╔══██╗██║     ██╔══██╗
                                ██████╔╝█████╗     ██║   ███████║██║     ███████║
                                ██╔══██╗██╔══╝     ██║   ██╔══██║██║     ██╔══██║
                                ██████╔╝███████╗   ██║   ██║  ██║███████╗██║  ██║
                                ╚═════╝ ╚══════╝   ╚═╝   ╚═╝  ╚═╝╚══════╝╚═╝  ╚═╝";
            Console.WriteLine(paylogo);
            Console.ResetColor();
        }
        public static void PrintFooter()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            string footer = @"                                                                                                                        
                  ███████╗███████╗███████╗███████╗███████╗███████╗███████╗███████╗███████╗
                  ╚══════╝╚══════╝╚══════╝╚══════╝╚══════╝╚══════╝╚══════╝╚══════╝╚══════╝";
            Console.WriteLine(footer);
            Console.ResetColor();
        }
    }
}
