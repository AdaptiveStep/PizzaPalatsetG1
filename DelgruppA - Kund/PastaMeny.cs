using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using static KundTermiPizzaPalatset.Terminal;

namespace KundTermiPizzaPalatset
{
    public class PastaMeny
    {

        public static void ChoosePasta(Order porder)
        {
            Console.Clear();
            AbMeny.PrintPastaLogo();
            Console.WriteLine("\t\t\t\t\tVälj pasta: \n " +
                "\t\t\t\t\t1: Marinara \n " + 
                "\t\t\t\t\t2: Pesto \n " +
                "\t\t\t\t\t3: Carbonara \n " +
                "\t\t\t\t\t4: Frutti di mare \n\n\n " +
                "\t\t\t\t\t0: Bakåt");
            Submeny.PrintSummary(porder);
            int pastachoice = IntIn();
            switch (pastachoice)
            {
                case 1:
                    porder.AddStuff(new Pasta("Marinara och Senapspasta", 55));
                    return;
                case 2:
                    porder.AddStuff(new Pasta("Pesto", 50));
                    return;
                case 3:
                    porder.AddStuff(new Pasta("Carbonara", 76));
                    return;
                case 4:
                    porder.AddStuff(new Pasta("Frutti di mare", 70));
                    return;
                case 0:
                    //Submeny.StarMenuChoice(porder);
                    return;
                default:
                    Console.WriteLine("\t\t\t\tFelaktig inmatning, försök igen!");
                    Thread.Sleep(1000);
                    break;
            }
        }
        
    }
}
