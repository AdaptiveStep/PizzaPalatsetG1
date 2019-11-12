using System;
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
                "1: Ost\n " +
                "2: Skinka \n " +
                "3: Champinjoner \n " +
                "4: Ananas \n " +
                "5: Salami \n " +
                "9: Färdig \n\n\n " +
                "0: Avbryt / Rensa");
        }

        internal static void PrintCustomSummary(Order porder, Pizza ppizza)
        {

            Console.WriteLine("Urvalda ingredienser ger nu priset: " + ppizza.price);
            Console.WriteLine("Ingredienser valda nu: " + ppizza.printIngreds());

            Console.WriteLine(porder.printProducts() +
                "(Antal Produkter hittils tillagda: " + porder.CustomerProducts.Count + ")");

            int summaryprice = porder.TotalSum() + ppizza.price;
            Console.WriteLine("Hela orderns pris hittils: " + porder.TotalSum() + " + " + ppizza.price + " = " + summaryprice);

        }
        public static void CreatePizzaMenu(Order porder)
        {
            Order myorder = porder;
            Pizza mypizza = new Pizza(); //Returnera färdig order endast i sista switch satsen
            Console.Clear();
            Console.WriteLine
                ("Komponera din egen Pizza\n " +
                "1: Italiensk botten \n " +
                "2: Amerikansk botten \n\n\n " +
                "0: Gå till huvudmeny"
                );
            int inputChoice = IntIn();

            if (inputChoice == 1)
            {
                CaseLoop(1, mypizza, myorder);
            }
            else if(inputChoice == 2)
            {
                CaseLoop(2, mypizza, myorder);
            }
            else if(inputChoice == 0)
            {
                return;
            }
        }

        private static void CaseLoop(int pchoice, Pizza ppizza, Order porder)
        {
            if (pchoice == 1) { ppizza.botten = "Italiensk Pizzabotten"; }
            else if (pchoice == 2) { ppizza.botten = "Amerikansk Pizzabotten"; }

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
                        ppizza.AddStuff(new PizzaIngredient("ost"));
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

                    case 9:
                        done = true;
                        porder.CustomerProducts.Add(ppizza);
                        break;

                    case 0:
                        done = true;
                        ppizza.objIngredients.Clear(); //möjligtvis onödig för att ordern inte kommer få pizzan
                        break;
                }
                //Console.Write("\nIngrediens Tillagd!\n gör fler val.\n");

                PrintCustomSummary(porder, ppizza);
            }

        }
    }
}