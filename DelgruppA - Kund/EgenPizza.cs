using System;
using System.Threading;
using static KundTermiPizzaPalatset.Pizza.PIngreds;
using static KundTermiPizzaPalatset.Terminal;

namespace KundTermiPizzaPalatset
{
    public static class EgenPizza
    {
        public static void PrintIngredientsChoices()
        {
            Console.Clear();
            Console.WriteLine("Välj topping: \n " +
                "1: Extra ost\n " +
                "2: Skinka \n " +
                "3: Champinjoner \n " +
                "4: Ananas \n " +
                "5: Salami \n " +
                "6: Oliver \n " +
                "7: Banan  \n " +
                "8: Paprika \n" +
                "9: Färdig \n " +
                "0: Avbryt / Rensa");
        }

        internal static void PrintCustomSummary(Order porder, Pizza ppizza)
        {

            Console.WriteLine("Urvalda ingredienser ger nu priset: " + ppizza.price);
            Console.WriteLine("Ingredienser valda nu: tomatsås ost " + ppizza.printIngreds());

            Console.WriteLine(porder.printProducts() +
                "(Antal Produkter hittils tillagda: " + porder.CustomerProducts.Count + ",)");

            int summaryprice = porder.TotalSum() + ppizza.price;
            Console.WriteLine("Hela orderns pris hittils: " + porder.TotalSum() + " + " + ppizza.price + " = " + summaryprice);

        }
        
        public static void CreatePizzaMenu(Order porder)
        {
            Order myorder = porder;
            Pizza mypizza = new Pizza(); //Returnera färdig order endast i sista switch satsen
                                         //Dvs starta först med en "tom" pizza.
            Console.Clear();
            Console.WriteLine
                ("Komponera din egen Pizza\n " +
                "1: Italiensk botten \n " +
                "2: Amerikansk botten \n\n\n " +
                "0: Gå till huvudmeny"
                );
            int inputChoice = IntIn();

            if (inputChoice == 1) { 
            
                mypizza.botten = "Italiensk Botten";
                EgenPizza.CaseLoop(mypizza, myorder);
            }
            else if(inputChoice == 2)
            {
                mypizza.botten = "Amerikansk Botten";

                CaseLoop(mypizza, myorder);
            }
            else if(inputChoice == 0)
            {
                return;
            }
        }

        internal static void CaseLoop(Pizza ppizza, Order porder)
        {            

            PrintIngredientsChoices();
            PrintCustomSummary(porder, ppizza);

            bool done = false;
            while (!done)
            {

                int topChoice = Terminal.IntIn();
                PrintIngredientsChoices();

                switch (topChoice)
                {
                    case 1:
                        ppizza.AddStuff(new PizzaIngredient("extra ost"));
                        break;

                    case 2:
                        ppizza.AddStuff(new PizzaIngredient("skinka"));
                        break;

                    case 3:
                        ppizza.AddStuff(new PizzaIngredient("champinjoner"));
                        break;

                    case 4:
                        ppizza.AddStuff(new PizzaIngredient("ananas"));
                        break;

                    case 5:
                        ppizza.AddStuff(new PizzaIngredient("salami"));
                        break;

                    case 6: ppizza.AddStuff(new PizzaIngredient("oliver"));
                        break;

                    case 7: ppizza.AddStuff(new PizzaIngredient("banan"));
                        break;
                    case 8: ppizza.AddStuff(new PizzaIngredient("paprika"));
                        break;

                    case 9:
                        if (porder.CustomerProducts.Count < 6)
                        {
                            done = true;
                            porder.CustomerProducts.Add(ppizza);
                            break;
                        }
                        else
                        {
                            Console.WriteLine("för många val av ingredienser, vänligen gör om din pizza med mindre än 6 ingredienser");
                            break;
                        }

                    case 0:
                        done = true;
                        ppizza.objIngredients.Clear(); //möjligtvis onödig för att ordern inte kommer få pizzan
                        break;
                    default:
                        Console.WriteLine("Felaktig inmatning, försök igen!");
                        Thread.Sleep(1000);
                        break;
                }
                

                PrintCustomSummary(porder, ppizza);
            }

        }
    }
}