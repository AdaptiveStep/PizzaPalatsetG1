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
            Console.WriteLine("Tillbehör: \n " +
                "1: Läsk 33cl \n " +
                "2: Läsk 2L \n " +
                "3: Stor Stark \n " +
                "4: Vin, rött 40cl\n" +
                "5: Vin, vitt 40cl \n" +
                "6: Pizzasallad \n" +
                "7: Dipsås \n\n\n " +
                "0: Bakåt");
            Submeny.PrintSummary(porder);
            int choice = IntIn();
            switch (choice)
            {
                case 1:
                    porder.AddStuff(new Tillbehör("Läsk 33cl", 15));
                    return;
                case 2:
                    porder.AddStuff(new Tillbehör("Läsk 2L", 25));
                    return;
                case 3:
                    porder.AddStuff(new Tillbehör("Stor Stark", 40));
                    return;
                case 4:
                    porder.AddStuff(new Tillbehör("Vin, rött 40cl", 50));
                    return;
                case 5:
                    porder.AddStuff(new Tillbehör("Vin, vitt 40cl", 50));
                    return;
                case 6:
                    porder.AddStuff(new Tillbehör("Pizzasallad", 5));
                    return;
                case 7:
                    porder.AddStuff(new Tillbehör("Dipsås", 7));
                    return;

                case 0:
                    //Submeny.StarMenuChoice(porder);
                    return;
                default:
                    Console.WriteLine("Felaktig inmatning, försök igen!");
                    Thread.Sleep(1000);
                    break;
            }
        }
    }
}
