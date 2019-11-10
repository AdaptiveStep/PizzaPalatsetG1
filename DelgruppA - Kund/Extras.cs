using System;
using System.Collections.Generic;
using System.Text;
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
            int choice = IntIn();
            switch (choice)
            {
                case 0:
                    return;
            }
        }
    }
}
