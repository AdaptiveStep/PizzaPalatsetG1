using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cashier
{
    public class OrdersComplete
    {
        public List<Customer> OrderID;

        public OrdersOnGoing ordersOngoing;

        public OrdersComplete()
        {
            this.OrderID = new List<Customer>();
            //OrdersOngoing ordersOngoing;
        }

        public void GetCompletedOrders(OrdersOnGoing ordersOngoing)
        {
            //int orderID = ordersOngoing.FinishedOrder();
            OrderID.Add(ordersOngoing.FinishedOrder());

        }
        public void ShowCompletedOrders()
        {
            int cursorPosition = 4;
            foreach (var customer in OrderID)
            {
                Console.SetCursorPosition(60, cursorPosition);
                Console.WriteLine($"#ID: {customer.ID} #Name: {customer.Name}");
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
