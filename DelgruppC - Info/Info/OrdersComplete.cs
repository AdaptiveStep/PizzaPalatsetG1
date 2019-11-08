using System;
using System.Collections.Generic;
using System.Text;

namespace Info
{
    public class OrdersComplete
    {
        public List<Customer> OrderID;
        
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
            int cursorPosition = 4;
            Console.Clear();
            foreach (var customer in OrderID)
            {
                //Console.SetCursorPosition(50, cursorPosition);
                Console.WriteLine($"#ID: {customer.ID}");
                cursorPosition++;
            }
        }
        public void RemoveCompleteOrders()
        {
            OrderID.RemoveAt(0);
        }
        public void BeepOrder()
        {
            System.Console.Beep();
        }
    }
}
