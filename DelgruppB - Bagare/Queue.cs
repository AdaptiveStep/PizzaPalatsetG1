using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelgruppB___Bagare
{
    class Queue
    {
        public static bool isUpdated = false;
        public static int iterator = 1; // goes between 001 and 999
        public static List<Item> Items= new List<Item>();

        public static void DisplayItems()
        {
            int i = 0;
            foreach(Item item in Items)
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.SetCursorPosition(0, i);
                Console.Write("{0}", i);
                Console.ResetColor();
                Console.SetCursorPosition(2, i);
                Console.Write("#{0} {1} {2}.. {3}", item.UniqueId, item.Name, item.GroupId.Substring(0, 5) , item.Timestamps.Started.ToString("HH:mm:ss"));
                Console.BackgroundColor = item.getStatusColor();
                Console.Write("{0}", item.getStatus());
                Console.ResetColor();
                Console.Write("\t");
                i++;
            }
        }

        public static bool UpdateItem(int n)
        {
            bool res = true;
            try
            {
                n = n - 1;
                Items[n].UpdateState();
            }
            catch (Exception)
            {
                res = false;
                Beeper.PlayError();
            }
            return res;
        }

        public static bool AddItem(Item Item)
        {
            Item.UniqueId = iterator;
            Items.Add(Item);
            iterator += iterator <= 999 ? 1 : -998; // For resetting when 999 is reached
            isUpdated = true;
            return false;
        }

        public static bool RemoveItem(Item Item)
        {
            return Items.Remove(Item);
        }
    }
}
