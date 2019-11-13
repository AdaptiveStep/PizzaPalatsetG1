using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelgruppB___Bagare
{
    class Queue
    {
        public static int iterator = 1; // goes between 001 and 999
        public static List<Item> Items;

        public void AddItem(Item Item)
        {
            Items.Add(Item);
            iterator += iterator <= 999 ? 1 : -998; // For resetting when 999 is reached
        }

        public bool RemoveItem(Item Item)
        {
            return Items.Remove(Item);
        }
    }
}
