using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Info
{
    class OrdersOngoing
    {
        private Dictionary<int, string> OrderID;
        public DateTime TimeStamp { get; set; }

        public OrdersOngoing()
        {
            this.OrderID = new Dictionary<int, string>();          
        }

        public void ShowOngoingOrders()
        {
            foreach (KeyValuePair<int,string> key in OrderID)
            {
                Console.WriteLine($"ID: {key.Key} Name: {key.Value}");
            }
        }

        public void NewOrder()         
        {
            Customer customer = new Customer();
            OrderID.Add(customer._ID,customer._name);
            BeepOrder();
        }

        //public int FinishedOrder()
        //{
            
        //}
        public void BeepOrder()
        {
            System.Console.Beep();
        }
    }
}
