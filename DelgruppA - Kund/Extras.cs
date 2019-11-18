using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using static KundTermiPizzaPalatset.Terminal;

namespace KundTermiPizzaPalatset
{
    public class Extras
    {
        public static void SelectExtras(Order porder)
        {
            Console.Clear();
            AbMeny.PrintExtraLogo();
            Console.WriteLine("\t\t\t\t\tTillbehör: \n " +
                "\t\t\t\t\t1: Läsk 33cl \n " +
                "\t\t\t\t\t2: Läsk 2L \n " +
                "\t\t\t\t\t3: Stor Stark \n " +
                "\t\t\t\t\t4: Vin, rött 40cl\n" +
                "\t\t\t\t\t5: Vin, vitt 40cl \n" +
                "\t\t\t\t\t6: Pizzasallad \n" +
                "\t\t\t\t\t7: Dipsås \n\n\n " +
                "\t\t\t\t\t0: Bakåt");
            Submeny.PrintSummary(porder);
            int choice = IntIn();
            switch (choice) // addade radavbrytning så att kvittot inte blir för "brett"
            {
                case 1:
                    porder.AddStuff(new Tillbehör("Läsk 33cl\n\t\t\t\t\t", 15));
                    return;
                case 2:
                    porder.AddStuff(new Tillbehör("Läsk 2L\n\t\t\t\t\t", 25));
                    return;
                case 3:
                    porder.AddStuff(new Tillbehör("Stor Stark\n\t\t\t\t\t", 40));
                    return;
                case 4:
                    porder.AddStuff(new Tillbehör("Vin, rött 40cl\n\t\t\t\t\t", 50));
                    return;
                case 5:
                    porder.AddStuff(new Tillbehör("Vin, vitt 40cl\n\t\t\t\t\t", 50));
                    return;
                case 6:
                    porder.AddStuff(new Tillbehör("Pizzasallad\n\t\t\t\t\t", 5));
                    return;
                case 7:
                    porder.AddStuff(new Tillbehör("Dipsås\n\t\t\t\t\t", 7));
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
