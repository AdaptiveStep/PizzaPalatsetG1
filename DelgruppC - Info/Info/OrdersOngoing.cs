using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading;

/*  Autor: @ Grupp 1
 *  Version @1.0
 *  marcuswelin88@gmail.com
 */
namespace Info
{
    /*Denna klass hanterar de pågående ordrarna,
      den kan lägga till, ta bort samt skriva ut pågående ordrar*/
    public class OrdersOngoing
    {
        public List<Customer> OngoingOrderID;
       

        public OrdersOngoing()
        {
            this.OngoingOrderID = new List<Customer>();          
        }

        public void ShowOngoingOrders()/*Skriver ut pågående ordrar*/
        {
            int cursorPosition = 18;
            
            foreach (Customer customer in OngoingOrderID)
            {
                Console.SetCursorPosition(21, cursorPosition);
                Console.WriteLine($"#ID: {customer.ID}");
                cursorPosition++;
            }           
        }

        public void NewOrder() /*Skapar en ny order och lägger till den i Listan för ordrar*/
        {
            Customer customer = new Customer();
            if (customer.ID % 2 == 0)
                Thread.Sleep(1000);
            OngoingOrderID.Add(customer);
            BeepOrder();
        }

        public Customer FinishedOrder()/*Flyttar över en pågående order till färdig order.
                                        Samt tar bort den pågående ordern*/
        {
            Customer customer = OngoingOrderID[0];           
            OngoingOrderID.Remove(OngoingOrderID[0]);
            return customer;
        }
        public void BeepOrder()
        {
            System.Console.Beep();
        }

           
    }
}
