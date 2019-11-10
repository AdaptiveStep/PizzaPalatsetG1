using System;
using System.Collections.Generic;
using System.Text;
using static KundTermiPizzaPalatset.Terminal;

namespace KundTermiPizzaPalatset
{
    public class PastaMeny
    {

        public static void ChoosePasta(Order porder)
        {
            Console.Clear();
            Console.WriteLine("Välj pasta: \n " + "hej"
                "1: Marinara \n " + 
                "2: Pesto \n " +
                "3: Carbonara \n " +
                "4: Frutti di mare \n\n\n " +
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
