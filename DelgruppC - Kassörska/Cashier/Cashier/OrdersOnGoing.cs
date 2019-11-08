using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cashier
{
    public class OrdersOnGoing
    {
        public List<Customer> OrderID;


        public OrdersOnGoing()
        {
            this.OrderID = new List<Customer>();
        }

        public void ShowOngoingOrders()
        {
            int cursorPosition = 4;

            foreach (Customer customer in OrderID)
            {
                Console.SetCursorPosition(12, cursorPosition);
                Console.WriteLine($"#ID: {customer.ID} #Name: {customer.Name}");
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
