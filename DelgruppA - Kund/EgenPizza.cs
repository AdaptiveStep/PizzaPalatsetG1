using System;
using static KundTermiPizzaPalatset.Pizza.PIngreds;
using static KundTermiPizzaPalatset.Terminal;

namespace KundTermiPizzaPalatset
{
    public static class EgenPizza
    {
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

            //myorder.CustomerProducts.Add
            Console.Clear();
            Console.WriteLine("Välj topping: \n " +
                "1: Ost\n " +
                "2: Skinka \n " +
                "3: Champinjoner \n " +
                "4: Ananas \n " +
                "5: Salami \n " +
                "9: Färdig \n\n\n " +
                "0: Avbryt / Rensa");

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

            bool done = false;
            while (!done)
            {
                int topChoice = Terminal.IntIn();
                switch (topChoice)
                {
                    case 1:
                        ppizza.ingredients.Add(ost);
                        break;

                    case 2:
                        ppizza.ingredients.Add(skinka);
                        break;

                    case 3:
                        ppizza.ingredients.Add(champinjoner);
                        break;

                    case 4:
                        ppizza.ingredients.Add(ananas);
                        break;

                    case 5:
                        ppizza.ingredients.Add(salami);
                        break;

                    case 9:
                        done = true;
                        break;

                    case 0:
                        done = true;
                        ppizza.ingredients.Clear(); //möjligtvis onödig för att ordern inte kommer få pizzan
                        break;
                }
                Console.Write("\nIngrediens Tillagd!\n gör fler val.\n" +
                    "Pizzan innehåller nu: HÄR KOMMER EN STR MED INNEHÅLLET\n Gör nu ett till val eller gå tillbaka med 0: ");

                porder.CustomerProducts.Add(ppizza);
                Console.WriteLine(porder.TotalSum());
            }
        }
    }
}