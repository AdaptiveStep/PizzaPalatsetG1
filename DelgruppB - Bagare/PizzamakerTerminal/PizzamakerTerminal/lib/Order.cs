using System;
using System.Collections.Generic;
using System.Text;

namespace PizzamakerTerminal
{
    class Order
    {
        public int ID { get; set; }
        public bool isComplete { get; set; }
        private static int IDCount = 1;
        private string Name;
        private string[] Ingredients;

        public Order()
        {
            ID = IDCount;
            isComplete = false;
            IDCount++;
        }
        public void SetIngredients(string[] ingrs)
        {
            Ingredients = ingrs;
        }

        public string GetIngredients()
        {
            var _ = "";
            foreach(string str in Ingredients)
            {
                _ += str + " ";
            }
            return _;
        }

        public void SetName(string name)
        {
            Name = name;
        }

        public string GetName()
        {
            return Name;
        }

        public void SetComplete()
        {
            isComplete = true;
        }
    }
}
