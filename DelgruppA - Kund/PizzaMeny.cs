using System;
using System.Collections.Generic;
using System.Text;
using static KundTermiPizzaPalatset.Terminal;

namespace KundTermiPizzaPalatset
{
    public class PizzaMeny
    {
        //private string name;
        //private int price;
        public static void StandardPizza(Order porder)
        {
            Console.Clear();
            Console.WriteLine("Välj pizza: \n " +
                "1: Vesuvio \n " +
                "2: Capricosa \n " +
                "3: Hawaii \n " +
                "4: Mexicana \n " +
                "5: Vegetarisk \n " +
                "6: Salami \n \n \n " +
                "0: Bakåt");
            int pizzachoice = IntIn();
            switch (pizzachoice)
            {
                //Lägg till priser och sånt här i instansieringen nedan |
                //                                                      v
                case 1:
                    porder.CustomerProducts.Add(new Pizza(name: "Vesuvio"));
                    return;
                case 2:
                    porder.CustomerProducts.Add(new Pizza(name: "Capricosa"));
                    return;
                case 3:
                    porder.CustomerProducts.Add(new Pizza(name: "Hawaii"));
                    return;
                case 4:
                    porder.CustomerProducts.Add(new Pizza(name: "Mexicana"));
                    return;
                case 5:
                    porder.CustomerProducts.Add(new Pizza(name: "Vegetarisk"));
                    return;
                case 6:
                    porder.CustomerProducts.Add(new Pizza(name: "Salami"));
                    return;
                case 0:
                    Submeny.StarMenuChoice(porder);
                    return;
            }
            //if (pizzachoice == 0)
            //{
            //    Submeny.StarMenuChoice();
            //}
        }
        //public PizzaMeny(string name, int price)
        //{
        //    this.name = name;
        //    this.price = price;

        //}
        //public string Name
        //{
        //    get { return name; }
        //    set { name = value; }
        //}

        //public int Price
        //{
        //    get { return price; }
        //    set { this.price = price; }
        //}

    }
}
