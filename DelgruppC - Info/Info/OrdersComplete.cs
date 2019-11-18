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
            BeepOrder();
            
        }
        public void ShowCompletedOrders()/*Skriver ut alla färdiga ordrar*/
        {
            int cursorPosition = 18;
            foreach (var customer in completeOrderID)
            {
                Console.SetCursorPosition(59, cursorPosition); /*CursorPosition för att hitta rätt plats på consolen.*/
                Console.WriteLine($"#ID: {customer.ID}");
                cursorPosition++;                
            }
            
        }
        public void RemoveCompleteOrders()/*Tar bort en färdig order*/
        {
            completeOrderID.Remove(completeOrderID[0]);
        }
        public void BeepOrder()/*Skapar ett "beep" när en order blir klar.*/
        {
            System.Console.Beep();
        }
    }
}
