using System;
using System.Collections.Generic;
using System.Text;
using Console = Colorful.Console;
using System.Drawing;

namespace InfoSkärmar
{
    public class OrdersOngoing
    {
        public List<int> OrderID { get; set; }
        public DateTime TimeStamp { get; set; }

        private Random random;

        public OrdersOngoing(int customer)
        {
            this.OrderID.Add(customer._ID);
            this.TimeStamp = DateTime.Now;
        }

        public static void ShowOngoingOrders()
        {
                    
          
        }

        public static void BeepOrder()
        {
            System.Console.Beep();
        }

    }
}
