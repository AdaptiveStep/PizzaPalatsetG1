using System;
using System.Collections.Generic;
using System.Text;
using static KundTermiPizzaPalatset.Terminal;

namespace KundTermiPizzaPalatset
{
    public class SalladMeny
    {
        public static void ChooseSalad(Order porder)
        {
             
            Console.Clear();
            Console.WriteLine("Salladsmeny: \n " +
                "1: Avocadosallad \n " +
                "2: FetaOst-sallad \n " +
                "3: Räksallad \n " +
                "4: Kycklingsallad\n\n\n" +
                "0: Bakåt");
            int input = IntIn();
            switch (input)
            {
                case 0:
                    return;
            }

        }
        
    }
}
