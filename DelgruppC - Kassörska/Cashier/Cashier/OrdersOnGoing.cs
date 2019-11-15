using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*  Autor: @ Grupp 1
 *  Version @1.0
 *  jonathan.harlin@icloud.com
 */
namespace Cashier
{
    /*Denna klass hanterar de pågående ordrarna,
      den kan lägga till, ta bort samt skriva ut pågående ordrar*/
    public class OrdersOnGoing
    {
        public List<Customer> OnGoingOrderID { get; set; }
        private int countExistingOrders;
        private int simulatedOrderCount;

        public OrdersOnGoing()
        {
            this.OnGoingOrderID = new List<Customer>();
            countExistingOrders = 0;
            simulatedOrderCount = 0;
        }

        public void ShowOngoingOrders()/*Skriver ut pågående ordrar*/
        {
            int cursorPosition = 18;
            ResetCurrentLines();
            foreach (Customer customer in OnGoingOrderID)
            {
                Console.SetCursorPosition(13, cursorPosition);
                Console.WriteLine($"#ID: {customer.ID}");
                cursorPosition++;
            }
        }
        public void ResetCurrentLines()/*Nollställer consolen från tidigare ordrar*/
        {
            int position = 18;
            for (int i = 0; i < countExistingOrders; i++)
            {
                Console.SetCursorPosition(13, position);
                Console.Write("       ");
                position++;
            }
        }

        public void NewOrder()/*Skapar en ny order och lägger till den i Listan för ordrar*/
        {
            if (simulatedOrderCount < 26)
            {
                Customer customer = new Customer();
                OnGoingOrderID.Add(customer);
                countExistingOrders++;
                simulatedOrderCount++;
            }
        }

        public Customer FinishedOrder()/*Flyttar över en pågående order till färdig order.
                                        Samt tar bort den pågående ordern*/
        {
            if (OnGoingOrderID.Count != 0)
            {
                Customer customer = OnGoingOrderID[0];
                OnGoingOrderID.RemoveAt(0);
                return customer;
            }
            else
            {
                return null;
            }
        }
    }
}
