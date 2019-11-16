using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace PizzamakerTerminal
{
    class Queue
    {
        public static List<Order> OrderList = new List<Order>();

        public static void AddOrder(Order order)
        {
            OrderList.Add(order); // Lägg till order
        }

        public static Order GetOrderById(int id)
        {
            return OrderList.Find(a => a.ID == id); //Hämtar specific order
        }

        public static void DeleteOrderById(int id)
        {
            OrderList.Remove(GetOrderById(id)); // Tar bort från listan. ( Index uppdateras AUTOMATISKT)
        }

        public static void DeleteFirstCompleteOrder()
        {
            var orders = GetCompletedOrders();
            var match = orders.FirstOrDefault(item => item.isComplete == true);
            if(match != null)
            {
                OrderList.Remove(match); // Tar bort den första 'complete'-order den hittar
            }
        }

        public static bool OrderExist(int id)
        {
            return OrderList.Exists(item => item.ID == id);
        }

        public static List<Order> GetIncompleteOrders()
        {
            return OrderList.Where(item =>item.isComplete == false).ToList();
        }

        public static List<Order> GetCompletedOrders()
        {
            return OrderList.Where(item => item.isComplete == true).ToList();
        }

        public static int CountCompletedOrders()
        {
            return OrderList.FindAll(item => item.isComplete == true).Count();
        }
        public static int CountTotalOrders()
        {
            return OrderList.Count();
        }

        public static int GetLowestIdNum()
        {
            int i = 1;
            // Upprepas tills hittar ett unikt id
            while (OrderList.Exists(item => item.ID == i))
            {
                i++;
            }
            return i;
        }
    }
}
