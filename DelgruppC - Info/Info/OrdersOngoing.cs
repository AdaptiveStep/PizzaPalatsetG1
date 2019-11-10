using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading;
namespace Info
{
    public class OrdersOngoing
    {
        public List<Customer> OrderID;
       

        public OrdersOngoing()
        {
            this.OrderID = new List<Customer>();          
        }

        public void ShowOngoingOrders()
        {
            int cursorPosition = 4;
            
            foreach (Customer customer in OrderID)
            {
                Console.SetCursorPosition(12, cursorPosition);
                Console.WriteLine($"#ID: {customer.ID}");
                cursorPosition++;
            }           
        }

        public void NewOrder()         
        {
            Customer customer = new Customer();
            if (customer.ID % 2 == 0)
                Thread.Sleep(1000);
            OrderID.Add(customer);
            BeepOrder();
        }

        public Customer FinishedOrder()
        {
            Customer customer = OrderID[0];           
            OrderID.Remove(OrderID[0]);
            return customer;
        }
        public void BeepOrder()
        {
            System.Console.Beep();
        }

           
    }
}
