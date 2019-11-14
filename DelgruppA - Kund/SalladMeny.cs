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
            AbMeny.PrintSaladLogo();
            Console.WriteLine("\t\t\t\t\tSalladsmeny: \n " +
                "\t\t\t\t\t1: Avocadosallad \n " +
                "\t\t\t\t\t2: FetaOst-sallad \n " +
                "\t\t\t\t\t3: Räksallad \n " +
                "\t\t\t\t\t4: Kycklingsallad\n\n\n" +
                "\t\t\t\t\t0: Bakåt");
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
