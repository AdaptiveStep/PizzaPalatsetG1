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
    /*Denna klass hanterar alla färdiga ordrar, den kan färdigställa en pågående order,
     skriva ut alla färdiga ordrar och ta bort färdiga ordrar. */
    public class OrdersComplete
    {
        public  List<Customer> CompleteOrderID;

        public OrdersOnGoing ordersOngoing;
        private int CountExistingOrders;

        public OrdersComplete()
        {
            this.CompleteOrderID = new List<Customer>();
            CountExistingOrders = 0;
        }

        public void GetCompletedOrders(OrdersOnGoing ordersOngoing)/*gör en pågående order till en färdig order,
                                                                    genom att hämta ordern från pågående ordrar.*/
        {
            CompleteOrderID.Add(ordersOngoing.FinishedOrder());
            CountExistingOrders++;
        }
        public void ShowCompletedOrders()/*Skriver ut alla färdiga ordrar*/
        {
            int cursorPosition = 4;
            ResetCurrentLines();
            if(CompleteOrderID.Count != 0)
            {
                try
                {
                    foreach (var customer in CompleteOrderID)
                    {
                        Console.SetCursorPosition(60, cursorPosition);
                        Console.WriteLine($"#ID: {customer.ID}");
                        cursorPosition++;
                    }
                }
                catch (Exception e)
                {
                    return;
                }
            }
        }
        public void ResetCurrentLines()/*Nollställer consolen från tidigare orderID*/
        {
            int position = 4;
            for (int i  = 0; i < CountExistingOrders; i++)
            {
                Console.SetCursorPosition(60, position);
                Console.Write("       ");
                position++;
            }
        }
        public void RemoveCompleteOrders()/*Tar bort en färdig order*/
        {
            if (CompleteOrderID.Count != 0)
            {
                CompleteOrderID.Remove(CompleteOrderID[0]);
            }
        }
        public void BeepOrder()/*Skapar ett "beep" när en order läggs.*/
        {
            System.Console.Beep();
        }
    }
}
