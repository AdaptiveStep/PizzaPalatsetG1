using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using static KundTermiPizzaPalatset.Terminal;

namespace KundTermiPizzaPalatset
{
    public class Betala
    {
        //static Kundkorg kundkorg = new Kundkorg();
        //public static List<Product> Items { get; set; } = new List<Product>();

        public static void PaymentMenu(Order porder)
        {
            Console.Clear();
            AbMeny.PrintPayLogo();
            Console.WriteLine("\t\t\t\t\t***** Kvitto *****");
            Submeny.PrintSummary(porder);  //Visar summering av order som kvitto.


            Console.WriteLine("\t\t\t\t\t1: Betala"); //Vi skrotade kundkorgen och valde att simulera ett köp istället
            
            int input = IntIn();
            if(input == 1)
            {
                Console.Clear();
                AbMeny.PrintLogo();
                Console.WriteLine("\t\t\t\t\tAnvänd kortterminalen för att slutföra din order");
                Thread.Sleep(3000);
                
                Console.Clear();
                AbMeny.PrintLogo();
                Console.WriteLine("\t\t\t\t\tBekräfta order genom att trycka 1.");
                int input2 = IntIn();
                if(input2 == 1)
                {
                    Console.Clear();
                    AbMeny.PrintLogo();
                    Console.WriteLine("\t\t\t\t\tProcessing payment...");
                    Thread.Sleep(3000);
                    Console.WriteLine("\t\t\t\t\tBetalning godkänd!");
                    Thread.Sleep(1500);
                    Console.Clear();
                    AbMeny.PrintLogo();
                    Console.WriteLine("\t\t\t\t\tDin order behandlas nu hos en av våra bagare\n" +
                                "\t\t\t\t\tVänligen följ din order på infoterminalen framme vid kassan\n" +
                                "\t\t\t\t\tBon appetit!");
                    
                    
                    Thread.Sleep(5000);
                    return;
                }
            }
        }

    }
}
