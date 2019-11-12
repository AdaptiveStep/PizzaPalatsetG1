using System;
using System.Collections.Generic;
using System.Text;
using static KundTermiPizzaPalatset.Terminal;

namespace KundTermiPizzaPalatset
{
    public class PizzaMeny
    {

        public static void StandardPizza(Order porder)
        {
            Console.Clear();
            Console.WriteLine("Välj pizza: \n " +
                "1: Vesuvio \n " +
                "2: Capriciosa \n " +
                "3: Hawaii \n " +
                "4: Mexicana \n " +
                "5: Vegetarisk \n " +
                "6: Salami \n \n \n " +
                "0: Bakåt");
            Submeny.PrintSummary(porder);
            int pizzachoice = IntIn();
            switch (pizzachoice)
            {
                case 1:
                    porder.AddStuff(Pizza.standardpizzas["Vesuvio"]);
                    return;
                case 2:
                    porder.AddStuff(Pizza.standardpizzas["Capriciosa"]);
                    return;
                case 3:
                    porder.AddStuff(Pizza.standardpizzas["Hawaii"]);
                    return;
                case 4:
                    porder.AddStuff(Pizza.standardpizzas["Mexicana"]);
                    return;
                case 5:
                    porder.AddStuff(Pizza.standardpizzas["Vegetarisk"]);
                    return;
                case 6:
                    porder.AddStuff(Pizza.standardpizzas["Salami"]);
                    return;
                case 0:
                    //Submeny.StarMenuChoice(porder);
                    return;
            }
        }


    }
}
