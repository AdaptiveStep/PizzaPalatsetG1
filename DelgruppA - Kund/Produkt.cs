
using System.Collections.Generic;

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

    internal class Pizza : Product
    {
        public static List<PizzaIngredient> Lings(params string[] args)
        {
            List<PizzaIngredient> tmp = new List<PizzaIngredient>();
            foreach(string i in args)
            {
                PizzaIngredient convertedstring = new PizzaIngredient(i);
                tmp.Add(convertedstring);
            }
            return tmp;
        }
        public static Dictionary<string, Pizza> standardpizzas = new Dictionary<string, Pizza>()
        {

          {"Vesuvio" , new Pizza(name: "Vesuvio" ,pbotten:"Amerikansk Botten", pingredients: Lings("skinka", "oliver")  )},
          {"Capriciosa" , new Pizza(name: "Capriciosa" , pingredients: Lings("skinka", "champinjoner")  )},
          {"Hawaii" , new Pizza(name: "Hawaii" ,pbotten:"Amerikansk Botten", pingredients: Lings("skinka", "ananas")  )},
          {"Mexicana" , new Pizza(name: "Mexicana", pbotten:"Amerikansk Botten", pingredients:Lings("skinka", "jalapenjos")  )},
          {"Vegetarisk" , new Pizza(name: "Vegetarisk" , pingredients: Lings("tomat", "jalapenjos", "paprika")  )},
          {"Salami" , new Pizza(name: "Salami" , pingredients: Lings("salami", "tomat")  )}

        };
        #region Hide
        //Möjliga ingredienser för en instans
        //public enum PIngreds { tomatsås, tomat, sallad, räkor, ost, skinka, champinjoner, ananas, jalapenjos, kebab, oxfile, paprika, salami, oliver };
        public string botten;

        //Ingredienser som självaste instansen kommer innehålla
        public List<PizzaIngredient> ingredients = new List<PizzaIngredient>();

        public List<PizzaIngredient> objIngredients = new List<PizzaIngredient>();
        public static List<PizzaIngredient> standardingredients = Lings("skinka", "ost");





        //Konstruktor
        public Pizza(string name = "EgenPizza", int price = 75, string pbotten = "Italiensk Pizzabotten", List<PizzaIngredient> pingredients = null)
            : base(name, price)
        {

            if (botten == "Italiensk Pizzabotten") this.price += 50;
            else if (botten == "Amerikansk Pizzabotten") this.price += 70;

            PizzaIngredient ost = new PizzaIngredient("ost");
            PizzaIngredient tomatsos = new PizzaIngredient("Tomatsås");

            if (pingredients != null)
            {
                

                //garanterar att instansen har ost och tomatsås
                if (!pingredients.Contains(ost)) { pingredients.Add(ost); }
                if (!pingredients.Contains(tomatsos)) { pingredients.Add(tomatsos); }

                //Bygger upp instansens ingredienslista
                foreach (PizzaIngredient ing in pingredients)
                {
                    this.ingredients.Add(ing);
                }
            }
            else if (pingredients == null)
            {
                this.ingredients.Add(ost);
                this.ingredients.Add(tomatsos);
            }

            this.botten = pbotten;
        }

        public string printIngreds()
        {
            string tmp = "";

            foreach (PizzaIngredient i in objIngredients)
            {
                tmp += i.name + " ";
            }
            return tmp;
        }
        #endregion
    




        public void AddStuff(PizzaIngredient ping)
        {
            objIngredients.Add(ping);
            this.price += ping.price;
        }

        public void RemoveStuff(PizzaIngredient ping)
        {
            objIngredients.Remove(ping);
            this.price -= ping.price;
        }

        //public int TotalPrice()
        //{
        //    int tmp = 0;
        //    if (botten == "Italiensk Pizzabotten") tmp += 40;
        //    else if (botten == "Amerikansk Pizzabotten") tmp += 70;


        //    foreach(PizzaIngredient i in objIngredients )
        //    {
        //        tmp += i.price;
        //    }
        //    return tmp;
        //}
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

        public Tillbehör(string name, int price = 10) : base(name, price)
        {

        }
    }

    internal class PizzaIngredient : Product
    {
        //Lägg till dessa till pizza ingreds
        //enum PizzaIngredients { Tomat, sallad, räkor, ost, skinka, champinjoner, ananas, jalapenjos, kebab, oxfile, paprika, salami, oliver };

        public int maxantal=1;

        public PizzaIngredient(string name, int price=10): base(name,price)
        {
            this.name=name;
            this.price = price;
        }
    }
}