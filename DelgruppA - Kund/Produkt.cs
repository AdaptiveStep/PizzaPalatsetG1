
using System.Collections.Generic;
using static KundTermiPizzaPalatset.Pizza.PIngreds;

namespace KundTermiPizzaPalatset
{

    internal class Product
    {
        public string name;
        public int price;

        public Product(string name, int price)
        {
            this.name = name;
            this.price = price;
        }
    }

    static class StandardPizzas
    {

    }
    internal class Pizza : Product
    {
        public static Dictionary<string, Pizza> standardpizzas = new Dictionary<string, Pizza>()
        {
            //hej
            {"Vesuvio" , new Pizza(name: "Vesuvio" , pingredients: new List<PIngreds>{skinka}  )},
          {"Capriciosa" , new Pizza(name: "Capricosa" , pingredients: new List<PIngreds>{skinka, champinjoner}  )},
          {"Capriciosa" , new Pizza(name: "Hawaii" , pingredients: new List<PIngreds>{skinka, ananas}  )},
          {"Capriciosa" , new Pizza(name: "Mexicana" , pingredients: new List<PIngreds>{skinka, jalapenjos}  )},
          {"Capriciosa" , new Pizza(name: "Vegetarisk" , pingredients: new List<PIngreds>{tomat, jalapenjos}  )},
          {"Capriciosa" , new Pizza(name: "Salami" , pingredients: new List<PIngreds>{salami, tomat}  )}

        };

        public enum PIngreds { tomatsås, tomat, sallad, räkor, ost, skinka, champinjoner, ananas, jalapenjos, kebab, oxfile, paprika, salami, oliver };
        public string botten;
        public List<PIngreds> ingredients = new List<PIngreds>();
        public static List<PIngreds> standardingredients = new List<PIngreds> { tomatsås, ost} ;
        public Pizza(string name = "EgenPizza", int price = 75, string pbotten = "Italiensk", List<PIngreds> pingredients = null)
            : base(name, price)
            {
            if (pingredients != null) {

                //garanterar att instansen har ost och tomatsås
                if (!pingredients.Contains(ost)) { this.ingredients.Add(ost); }
                if (!pingredients.Contains(tomatsås)) { this.ingredients.Add(tomatsås); }

                //Bygger upp instansens ingredienslista
                foreach (PIngreds ing in pingredients)
                {
                    this.ingredients.Add(ing);
                }
            }
            else if (pingredients == null)
                { this.ingredients.Add(ost); 
                  this.ingredients.Add(tomatsås); }

            this.botten = pbotten;
            }
    }

    internal class Pasta : Product
    {
        public Pasta(string name, int price = 50) : base(name, price)
        {

        }

    }

    internal class Sallad : Product
    {
        public string dressing;

        public Sallad(string name, int price = 70, string pdressing = "") : 
               base(name, price)
        {
            this.dressing = pdressing;
        }
    }

    internal class Tillbehör : Product
    {
        public int kvantet;

        public Tillbehör(string name, int price = 10, int pkvantitet = 1) : base(name, price)
        {
            this.kvantet = pkvantitet;
        }
    }

    internal class PizzaIngredient : Product
    {
        enum PizzaIngredients { Tomat, sallad, räkor, ost, skinka, champinjoner, ananas, jalapenjos, kebab, oxfile, paprika, salami, oliver};

        public int  maxantal;
        Pizza Hostpizza = null;

        public PizzaIngredient(string name, int price, int pmaxantal = 1, Pizza Hostpizza = null) : base(name, price)
        {
            this.maxantal = pmaxantal;
        }
    }
}