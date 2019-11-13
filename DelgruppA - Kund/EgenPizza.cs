using System;
using System.Threading;
using static KundTermiPizzaPalatset.Terminal;
using System.Linq;

namespace KundTermiPizzaPalatset
{
    public static class EgenPizza
    {
        public static void PrintIngredientsChoices()
        {
            Console.Clear();
            AbMeny.PrintLogo();
            Console.WriteLine("\t\t\t\t\tVälj topping: \n " +
                "\t\t\t\t\t1: Extra ost\n " +
                "\t\t\t\t\t2: Skinka \n " +
                "\t\t\t\t\t3: Champinjoner \n " +
                "\t\t\t\t\t4: Ananas \n " +
                "\t\t\t\t\t5: Salami \n " +
                "\t\t\t\t\t6: Oliver \n " +
                "\t\t\t\t\t7: Banan  \n " +
                "\t\t\t\t\t8: Paprika \n" +
                "\t\t\t\t\t9: Färdig \n " +
                "\t\t\t\t\t0: Avbryt / Rensa");
        }

        internal static void PrintCustomSummary(Order porder, Pizza ppizza)
        {

            Console.WriteLine("\n\t\t\t\tUrvalda ingredienser ger nu priset: " + ppizza.price);
            Console.WriteLine("\t\t\t\tIngredienser valda nu: tomatsås ost " + ppizza.printIngreds());

            Console.WriteLine(porder.printProducts() +
                "\t\t\t\t(Antal Produkter hittils tillagda: " + porder.CustomerProducts.Count + ",)");

            int summaryprice = porder.TotalSum() + ppizza.price;
            Console.WriteLine("\t\t\t\tHela orderns pris hittils: " + porder.TotalSum() + " + " + ppizza.price + " = " + summaryprice);

        }
        
        public static void CreatePizzaMenu(Order porder)
        {
            Order myorder = porder;
            Pizza mypizza = new Pizza(); //Returnera färdig order endast i sista switch satsen
                                         //Dvs starta först med en "tom" pizza.
            Console.Clear();
            AbMeny.PrintLogo();
            Console.WriteLine
                ("\t\t\t\t\tKomponera din egen Pizza\n " +
                "\t\t\t\t\t1: Italiensk botten \n " +
                "\t\t\t\t\t2: Amerikansk botten \n\n\n " +
                "\t\t\t\t\t0: Gå till huvudmeny"
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
                        bool toolittlecheese = ppizza.objIngredients.Where(x => x.name == "ost").Count() < 1;

                        if (toolittlecheese)
                        {
                            ppizza.AddStuff(new PizzaIngredient("ost"));
                            break;
                        }
                        else { Console.WriteLine("Max två ostpålägg."); break; }

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
                            Console.WriteLine("\t\t\t\t\tför många val av ingredienser, vänligen gör om din pizza med mindre än 6 ingredienser");
                            break;
                        }

                    case 0:
                        done = true;
                        ppizza.objIngredients.Clear(); //möjligtvis onödig för att ordern inte kommer få pizzan
                        break;
                    default:
                        Console.WriteLine("\t\t\t\t\tFelaktig inmatning, försök igen!");
                        Thread.Sleep(1000);
                        break;
                }
                

                PrintCustomSummary(porder, ppizza);
            }

        }
    }
}