using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using static KundTermiPizzaPalatset.Terminal;


namespace KundTermiPizzaPalatset
{
    public class Submeny
    {
        internal static void PrintSummary(Order porder)
        {

            Console.WriteLine("\n\t\t\t\t\tUtvalda producter: " + porder.printProducts() +
                "\n\t\t\t\t\t(Antal Produkter hittils tillagda: " + porder.CustomerProducts.Count + ")\n");
            Console.WriteLine("\t\t\t\t\tHela orderns pris hittils: " + porder.TotalSum());

        }
        public static void StarMenuChoice(Order porder)
        {
            Order order = porder;
            bool done = false;
            while (!done)
            {
                Console.Clear();
                AbMeny.PrintLogo();
                Console.WriteLine("\t\t\t\t\tVälkommen till PizzaPalatset! \n " +
                "\t\t\t\t\t1: Komponera egen Pizza \n " +
                "\t\t\t\t\t2: Standard Pizzor \n " +
                "\t\t\t\t\t3: Sallad\n " +
                "\t\t\t\t\t4: Pasta \n " +
                "\t\t\t\t\t5: Tillbehör \n " +
                "\t\t\t\t\t6: Betala \n " +
                "\t\t\t\t\t0: Avbryt");

                PrintSummary(order);

                int input = IntIn();
                switch (input)
                {
                    case 1:
                        EgenPizza.CreatePizzaMenu(porder);
                        break;
                    case 2:
                        PizzaMeny.StandardPizza(porder);
                        break;
                    case 3:
                        SalladMeny.ChooseSalad(porder);
                        break;
                    case 4:
                        PastaMeny.ChoosePasta(porder);
                        break;
                    case 5:
                        Extras.SelectExtras(porder);
                        break;
                    case 6:
                        Betala.PaymentMenu(porder);
                        done = true;
                        break;
                    case 0:
                        return;
                    default:
                        Console.WriteLine("\t\t\t\tFelaktig inmatning, försök igen!");
                        Thread.Sleep(1000);
                        break;

                }
                
            }
        }
        



        //public void ShowPizza()
        //{
        //    PizzaMeny.StandardPizza();
        //}
        //public void ShowPasta()
        //{
        //    PastaMeny.ChoosePasta();
        //}
        //public void ShowSalad()
        //{
        //    SalladMeny.ChooseSalad();
        //}
        //public void ShowCart()
        //{

        //}
        //public void ShowExtra()
        //{
        //    Extras.SelectExtras();
        //}
    }
}
