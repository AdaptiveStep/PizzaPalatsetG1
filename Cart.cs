using System;
using System.Collections.Generic;
using System.Linq;

namespace PizzaPalatsetG1
{
    class Cart
    {
        public List<Item> items = new List<Item>();
        public Cart(){
            //
        }
        public void AddItem(Item item)
        {
            this.items.Add(item);
        }
        public bool RemoveItem(Item item)
        {
            return this.items.Remove(item);
        }
        public decimal GetOrderTotalPrice()
        {
            return this.items.Sum(item => item.price);
        }
        public int GetAverageItemNameLength(){
            
            int len = (int)Math.Round(this.items.Average(item => item.name.Length));
            return len;
        }
        public void Reset()
        {
            this.items.Clear();
        }
    }
}
