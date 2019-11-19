using System;
using System.Collections.Generic;

namespace PizzamakerTerminal
{

    class Data
    {
        private static Random rand = new Random();
        private static List<string> a = new List<string>()
        {
            "Vesuvio", "Hawaii", "Tony-Pizza", "Pasta", "Grekisk Sallad"
        };
        private struct Ingredients
        {
            public string[] _ { get; set; }
        }
        private static List<Ingredients> b = new List<Ingredients>()
        {
           new Ingredients(){_ = new string[3]{ "Ost", "Tomat", "Skinka" } },
           new Ingredients(){_ = new string[4]{ "Ost", "Tomat", "Skinka", "Ananas" } },
           new Ingredients(){_ = new string[2]{ "Ost", "TONYSÅS" } },
           new Ingredients(){_ = new string[2]{ "Makaroner", "Dressing" } },
           new Ingredients(){_ = new string[3]{ "Salladsblad", "Dressing", "Grekland" } }
        };
        private static List<double> c = new List<double>()
        {
            0.50,
            0.20,
            0.05,
            0.15,
            0.10
        };

        public static void GeneraterOrder()
        {
            int n = rand.Next(0, a.Count - 1);
            Order newOrder = new Order();
            //Product p = new Product();

            newOrder.SetName(a[n]);
            newOrder.SetIngredients(b[n]._);
            Queue.AddOrder(newOrder);
        }
    }
}
