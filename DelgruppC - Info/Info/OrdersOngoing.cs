using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Info
{
    public class OrdersOngoing
    {
        private List<Customer> OrderID;
        public DateTime TimeStamp { get; set; }

        public OrdersOngoing()
        {
            this.OrderID = new List<Customer>();          
        }

        public void ShowOngoingOrders()
        {
            foreach (Customer customer in OrderID)
            {
                Console.WriteLine($"Pågående Order:\nID: {customer.ID} Name: {customer.Name}");
            }
        }

        public void NewOrder()         
        {
            Customer customer = new Customer();
            OrderID.Add(customer);
            BeepOrder();
        }

        public Customer FinishedOrder()
        {
            Customer customer = OrderID[0];
            OrderID.RemoveAt(0);
            return customer;
        }
        public void BeepOrder()
        {
            System.Console.Beep();
        }
    }
}
