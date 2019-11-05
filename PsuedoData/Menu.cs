using System;
using System.Collections.Generic;
using System.Linq;

namespace PizzaPalatsetG1
{
    public class Menu
    {
        public List<Item> items;

        public int GetAverageItemNameLength()
        {
            int len = (int)Math.Round(this.items.Average(item => item.name.Length));
            return len;
        }
    }
}
