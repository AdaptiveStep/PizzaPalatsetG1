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
            AbMeny.PrintLogo();
            Console.WriteLine("\t\t\t\t\tVälj pizza: \n " +
                "\t\t\t\t\t1: Vesuvio \n " +
                "\t\t\t\t\t2: Capriciosa \n " +
                "\t\t\t\t\t3: Hawaii \n " +
                "\t\t\t\t\t4: Mexicana \n " +
                "\t\t\t\t\t5: Vegetarisk \n " +
                "\t\t\t\t\t6: Salami \n \n \n" +
                "\t\t\t\t\t0: Bakåt");
            Submeny.PrintSummary(porder);
            
            bool done = false;
            Pizza onepizza = new Pizza();
            while (!done)
            {
                int pizzachoice = IntIn();
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
                        Console.WriteLine("\t\t\t\t\tFelaktig inmatning! försök igen:");
                        Thread.Sleep(1000);
                        Console.SetCursorPosition(Console.CursorLeft, Console.CursorTop - 1);
                        Console.WriteLine("                                                                                                       ");
                        Console.SetCursorPosition(Console.CursorLeft, Console.CursorTop - 2);
                        continue;
                }
                
            }
            

            Console.WriteLine("" +
                "\t\t\t\t\tÄr du nöjd med din meny? \n" +
                "\t\t\t\t\tTryck 0 för att acceptera och 1 för att " +
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
