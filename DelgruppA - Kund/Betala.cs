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
            Console.WriteLine("***** Kvitto *****");
            Submeny.PrintSummary(porder);

            Console.WriteLine("1: Betala");
            int input = IntIn();
            if(input == 1)
            {
                Console.Clear();
                Console.WriteLine("Använd kortterminalen för att slutföra din order");
                Thread.Sleep(3000);
                
                Console.Clear();
                Console.WriteLine("Bekräfta order genom att trycka 123.");
                int input2 = IntIn();
                if(input2 == 123)
                {
                    Console.Clear();
                    Console.WriteLine("Processing payment...");
                    Thread.Sleep(3000);
                    Console.WriteLine("Betalning godkänd!");
                    Thread.Sleep(1500);
                    Console.Clear();
                    Console.WriteLine("Din order behandlas nu hos en av våra bagare\n" +
                                "Vänligen följ din order på infoterminalen framme vid kassan\n" +
                                "Bon appetit!");
                    
                    Thread.Sleep(5000);
                    return;
                }
            }
        }

        public void PopulateCart()
        {
           // Product.Add(1, 2);
        }
    }
}
