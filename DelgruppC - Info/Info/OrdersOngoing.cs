using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Info
{
    public class OrdersOngoing
    {
        private List<Customer> OrderID;
       

        public OrdersOngoing()
        {
            this.OrderID = new List<Customer>();          
        }

        public void ShowOngoingOrders()
        {
            int cursorPosition = 4;
            Console.Clear();
            foreach (Customer customer in OrderID)
            {
                
                //Console.SetCursorPosition(14, cursorPosition);
                Console.WriteLine($"\t\t#ID: {customer.ID}");
                cursorPosition++;
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
