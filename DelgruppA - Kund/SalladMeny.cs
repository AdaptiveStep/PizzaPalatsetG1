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
            Submeny.PrintSummary(porder);
            int saladchoice = IntIn();
            switch (saladchoice)
            {
                case 1:
                    porder.AddStuff( new Sallad("Avocadosallad", 70, "RhodeIsland"));
                    return;
                case 2:
                    porder.AddStuff(new Sallad("FetaOst-sallad", 70, "Kebabsås"));
                    return;
                case 3:
                    porder.AddStuff(new Sallad("Räksallad", 70, "Jordgubb och Cocacolasås"));
                    return;
                case 4:
                    porder.AddStuff(new Sallad("Kycklingsallad", 170, "Smultron och Mahmodisås"));
                    return;
                case 0:
                    //Submeny.StarMenuChoice(porder);
                    return;
            }

        }
        
    }
}
