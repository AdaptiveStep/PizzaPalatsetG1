using System;
using System.Collections.Generic;
using System.Text;

namespace Info
{
    public class OrdersComplete
    {
        public List<Customer> OrderID;
        public DateTime TimeStamp { get; set; }
        //public OrdersOngoing ordersOngoing;

        public OrdersComplete()
        {
            this.OrderID = new List<Customer>();
            //OrdersOngoing ordersOngoing;
        }

        public void GetCompletedOrders(OrdersOngoing ordersOngoing)
        {
            //int orderID = ordersOngoing.FinishedOrder();
            OrderID.Add(ordersOngoing.FinishedOrder());
            
        }
        public void ShowCompletedOrders()
        {
            foreach (var customer in OrderID)
            {
                Console.WriteLine($"Färdig Order:\nID: {customer.ID}  Name: {customer.Name}");
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
