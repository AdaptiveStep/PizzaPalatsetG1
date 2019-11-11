using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cashier
{
    public class OrdersComplete
    {
        public  List<Customer> OrderID;

        public OrdersOnGoing ordersOngoing;
        private int CountExistingOrders;

        public OrdersComplete()
        {
            this.OrderID = new List<Customer>();
            CountExistingOrders = 0;
            //OrdersOngoing ordersOngoing;
        }

        public void GetCompletedOrders(OrdersOnGoing ordersOngoing)
        {
            //int orderID = ordersOngoing.FinishedOrder();
            OrderID.Add(ordersOngoing.FinishedOrder());
            CountExistingOrders++;

        }
        public void ShowCompletedOrders()
        {
            int cursorPosition = 4;
            ResetCurrentLines();
            if(OrderID.Count != 0)
            {
                foreach (var customer in OrderID)
                {
                    Console.SetCursorPosition(60, cursorPosition);
                    Console.WriteLine($"#ID: {customer.ID}");
                    cursorPosition++;
                }
            }
        }
        public void ResetCurrentLines()
        {
            int position = 4;
            for (int i  = 0; i < CountExistingOrders; i++)
            {
                Console.SetCursorPosition(60, position);
                Console.Write("       ");
                position++;
            }
        }
        public void RemoveCompleteOrders()
        {
            if (OrderID.Count != 0)
            {
                OrderID.Remove(OrderID[0]);
            }
        }
        public void BeepOrder()
        {
            System.Console.Beep();
        }
    }
}
