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

            Console.WriteLine("\nUtvalda producter: "+ porder.printProducts() +
                "\n(Antal Produkter hittils tillagda: " + porder.CustomerProducts.Count + ")");
            Console.WriteLine("Hela orderns pris hittils: " + porder.TotalSum());

        }
        public static void StarMenuChoice(Order porder)
        {
            Order order = porder;
            bool done = false;
            while (!done)
            {
                Console.Clear();
                Console.WriteLine("Välkommen till PizzaPalatset! \n " +
                "1: Komponera egen Pizza \n " +
                "2: Standard Pizzor \n " +
                "3: Sallad\n " +
                "4: Pasta \n " +
                "5: Tillbehör \n " +
                "6: Betala \n " +
                "0: Avbryt");

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
                        Console.WriteLine("Felaktig inmatning, försök igen!");
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
