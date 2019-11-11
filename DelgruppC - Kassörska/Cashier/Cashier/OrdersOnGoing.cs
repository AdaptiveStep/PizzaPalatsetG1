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
        private int countExistingOrders;

        public OrdersOnGoing()
        {
            this.OrderID = new List<Customer>();
            countExistingOrders = 0;
        }

        public void ShowOngoingOrders()
        {
            int cursorPosition = 4;
            ResetCurrentLines();
            foreach (Customer customer in OrderID)
            {
                Console.SetCursorPosition(12, cursorPosition);
                Console.WriteLine($"#ID: {customer.ID}");
                cursorPosition++;

            }
        }
        public void ResetCurrentLines()
        {
            int position = 4;
            for (int i = 0; i < countExistingOrders; i++)
            {
                Console.SetCursorPosition(12, position);
                Console.Write("       ");
                position++;
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
            if (OrderID.Count != 0)
            {
                Customer customer = OrderID[0];
                OrderID.RemoveAt(0);
                return customer;
            }
            else
            {
                return null;
            }
        }
        public void BeepOrder()
        {
            System.Console.Beep();
        }


    }
}
