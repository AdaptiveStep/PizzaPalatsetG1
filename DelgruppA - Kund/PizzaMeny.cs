using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
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
                "6: Salami \n \n \n" +
                "0: Bakåt");
            Submeny.PrintSummary(porder);
            int pizzachoice = IntIn();
            bool done = false;
            Pizza onepizza = new Pizza();
            while (!done)
            {
                switch (pizzachoice)
                {
                    case 1:
                        onepizza = Pizza.standardpizzas["Vesuvio"];
                        done = true;
                        break;
                    case 2:
                        onepizza = Pizza.standardpizzas["Capriciosa"];
                        done = true;
                        break;
                    case 3:
                        onepizza = Pizza.standardpizzas["Hawaii"];
                        done = true;
                        break;
                    case 4:
                        onepizza = Pizza.standardpizzas["Mexicana"];
                        done = true;
                        break;
                    case 5:
                        onepizza = Pizza.standardpizzas["Vegetarisk"];
                        done = true;
                        break;
                    case 6:
                        onepizza = Pizza.standardpizzas["Salami"];
                        done = true;
                        break;
                    case 0:
                        //Submeny.StarMenuChoice(porder);
                        return;
                    default:
                        Console.WriteLine("Felaktig inmatning, försök igen!");
                        Thread.Sleep(1000);
                        break;
                }
                
            }
            //Pizza onepizza = (Pizza) porder.CustomerProducts[porder.CustomerProducts.Count- 1];

            Console.WriteLine("" +
                "Är du nöjd med din meny? " +
                "Tryck 0 för att acceptera och 1 för att " +
                "skräddarsy din pizza: ");

            int choice = IntIn();

            if (choice == 0) 
            {
                porder.CustomerProducts.Add(onepizza);
                return;
            }
            else if (choice == 1)
            {
                EgenPizza.CaseLoop(onepizza, porder);
                return;
            }





        }


    }
}
