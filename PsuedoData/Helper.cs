using System;
using System.Collections.Generic;
using System.Linq;

namespace PizzaPalatsetG1
{
    public class Helper
    {
        public Menu GenerateMenu()
        {
            List<Item> items = new List<Item>()
            {
                new Item(){id = 1, name = "Vesuvio", ingredients=new[] { "Bread", "Tomato", "Cheese" }, price= 9.9M, prep_seconds=600},
                new Item(){id = 2, name = "Hawaii",  ingredients=new[] { "Bread", "Tomato", "Cheese", "Ananas" }, price= 10.9M, prep_seconds=620},
                new Item(){id = 3, name = "Tony's Special", ingredients=new[] { "Bread", "Tomato", "Sås","Skosula" ,"Kärlek"}, price= 39.0M, prep_seconds=800},
                new Item(){id = 4, name = "Sallad", ingredients=new[] { "Isbergssallad"}, price= 7.0M, prep_seconds=340},
                new Item(){id = 5, name = "Grekisk Sallad", ingredients=new[] { "Isbergssallad", "Grekland", "Cheese" }, price= 8.5M, prep_seconds=360},
                new Item(){id = 6, name = "Åbro", ingredients=new[] { "Alcohol", "Water"}, price= 4.5M, prep_seconds=25},
                new Item(){id = 7, name = "Läsk A", ingredients=new[] { "Sugar", "Water" }, price= 2.0M, prep_seconds=10},
                new Item(){id = 8, name = "Läsk B", ingredients=new[] { "Sugar", "Water" }, price= 2.0M, prep_seconds=10},
            };

            Menu menu = new Menu();
            menu.items = items;
            return menu;
        }
    }
}



