using System;
using System.Collections.Generic;
using System.Text;

namespace PizzamakerTerminal
{
    class Order
    {
        public int ID { get; set; }
        public bool isComplete { get; set; }
        private string Name;
        private string[] Ingredients;

        public Order()
        {
            ID = Queue.GetLowestIdNum();
            isComplete = false;       
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
