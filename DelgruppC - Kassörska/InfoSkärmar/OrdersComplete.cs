using System;
using System.Collections.Generic;
using System.Text;
using Console = Colorful.Console;
using System.Drawing;

namespace InfoSkärmar
{
    class OrdersComplete
    {
        public List<int> OrderID { get; set; }
        public DateTime TimeStamp { get; set; }

        public OrdersComplete()
        {
            this.OrderID = OrderID;
            this.TimeStamp = TimeStamp;
        }

        public static void ShowCompletedOrders()
        {

        }
        public static void RemoveCompleteOrders()
        {

        }
        public static void BeepOrder()
        {
            System.Console.Beep();
        }
    }
}
