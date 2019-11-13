﻿
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

    internal class Pizza : Product
    {
        public static Dictionary<string, Pizza> standardpizzas = new Dictionary<string, Pizza>()
        {

            {"Vesuvio" , new Pizza(name: "Vesuvio" , pingredients: new List<PIngreds>{skinka}  )},
          {"Capriciosa" , new Pizza(name: "Capriciosa" , pingredients: new List<PIngreds>{skinka, champinjoner}  )},
          {"Hawaii" , new Pizza(name: "Hawaii" , pingredients: new List<PIngreds>{skinka, ananas}  )},
          {"Mexicana" , new Pizza(name: "Mexicana" , pingredients: new List<PIngreds>{skinka, jalapenjos}  )},
          {"Vegetarisk" , new Pizza(name: "Vegetarisk" , pingredients: new List<PIngreds>{tomat, jalapenjos}  )},
          {"Salami" , new Pizza(name: "Salami" , pingredients: new List<PIngreds>{salami, tomat}  )}

        };
        #region Hide
        //Möjliga ingredienser för en instans
        public enum PIngreds { tomatsås=20, tomat=20, sallad, räkor, ost, skinka, champinjoner, ananas, jalapenjos, kebab, oxfile, paprika, salami, oliver };
        public string botten;

        //Ingredienser som självaste instansen kommer innehålla
        public List<PIngreds> ingredients = new List<PIngreds>();

        public List<PizzaIngredient> objIngredients = new List<PizzaIngredient>();
        public static List<PIngreds> standardingredients = new List<PIngreds> { tomatsås, ost };

        //Konstruktor
        public Pizza(string name = "EgenPizza", int price = 75, string pbotten = "Italiensk Pizzabotten", List<PIngreds> pingredients = null)
            : base(name, price)
        {

            if (botten == "Italiensk Pizzabotten") this.price += 50;
            else if (botten == "Amerikansk Pizzabotten") this.price += 70;

            if (pingredients != null)
            {

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
            {
                this.ingredients.Add(ost);
                this.ingredients.Add(tomatsås);
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