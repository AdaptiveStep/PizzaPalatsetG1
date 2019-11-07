using System;
using System.Collections.Generic;
using System.Text;

namespace Info
{
    class OrdersComplete
    {
        public Dictionary<int, string> OrderID;
        public DateTime TimeStamp { get; set; }

        public OrdersComplete()
        {
            this.OrderID = new Dictionary<int, string>();
        }

        public void GetCompletedOrders()
        {
            
        }
        public void ShowCompletedOrders()
        {
            foreach (KeyValuePair<int, string> key in OrderID)
            {
                Console.WriteLine($"ID: {key.Key} Name: {key.Value}");
            }
        }
        public void RemoveCompleteOrders()
        {

        }
        public void BeepOrder()
        {
            System.Console.Beep();
        }
    }
}
