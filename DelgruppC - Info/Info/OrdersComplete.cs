using System;
using System.Collections.Generic;
using System.Text;
/*  Autor: @ Grupp 1
 *  Version @1.0
 *  marcuswelin88@gmail.com
 */
namespace Info
{
    /*Denna klass hanterar alla färdiga ordrar, den kan färdigställa en pågående order,
     skriva ut alla färdiga ordrar och ta bort färdiga ordrar. */
    public class OrdersComplete
    {
        public List<Customer> completeOrderID;

        public OrdersComplete()
        {
            this.completeOrderID = new List<Customer>();
        }

        public void GetCompletedOrders(OrdersOngoing ordersOngoing)/*gör en pågående order till en färdig order,
                                                                    genom att hämta ordern från pågående ordrar.*/
        {
            completeOrderID.Add(ordersOngoing.FinishedOrder());
            
        }
        public void ShowCompletedOrders()/*Skriver ut alla färdiga ordrar*/
        {
            int cursorPosition = 4;
            foreach (var customer in completeOrderID)
            {
                Console.SetCursorPosition(60, cursorPosition);
                Console.WriteLine($"#ID: {customer.ID}");
                cursorPosition++;                
            }
            
        }
        public void RemoveCompleteOrders()/*Tar bort en färdig order*/
        {
            completeOrderID.Remove(completeOrderID[0]);
        }
        public void BeepOrder()/*Skapar ett "beep" när en order läggs.*/
        {
            System.Console.Beep();
        }
    }
}
