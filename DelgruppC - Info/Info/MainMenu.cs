using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
/*  Autor: @ Grupp 1
 *  Version @1.0
 *  marcuswelin88@gmail.com
 */
namespace Info
{
    /* Denna klass är huvudmenyn. Den hanterar flera metoder för att lägga till ordrar,
     * skriva ut ordrar, ändra status på ordar samt ta bort färdiga ordrar.*/
    class MainMenu
    {
        OrdersOngoing onGoingOrders;
        OrdersComplete completeOrders;
        public MainMenu()
        {
            this.onGoingOrders = new OrdersOngoing();
            this.completeOrders = new OrdersComplete();           
        }

        public void Run()/*Skriver ut menyn till consolen samt kallar på metoder för att skapa och ta bort ordrar*/
        {
            Console.WriteLine($"\t Pågående ordrar\t\t\t\tKlara ordrar");
            Console.WriteLine($" ______________________________\t\t\t______________________________");
            int counterForCompleteOrder = 0;
            int counterForRemoveCompleteOrder = 0;
            do
            {
                GenerateNewOrder();

                if (counterForCompleteOrder == 2)
                {
                    completeOrders.GetCompletedOrders(onGoingOrders);
                    counterForCompleteOrder = 0;

                    if (counterForRemoveCompleteOrder == 2)
                    {
                        completeOrders.RemoveCompleteOrders();
                        counterForRemoveCompleteOrder = 0;
                    }
                    counterForRemoveCompleteOrder++;
                }
                PrintOrders();
                counterForCompleteOrder++;

            } while (true);
        }

        public void GenerateNewOrder()/*Simulerar att nya ordrar kommer in genom att söva tråden och sedan skapa nya ordrar.*/
        {            
            Thread.Sleep(1000);
            onGoingOrders.NewOrder();
        }

        public void PrintOrders()/*Skriver ut pågående och klara ordrar till consolen.*/
        {               
            onGoingOrders.ShowOngoingOrders();
            completeOrders.ShowCompletedOrders();
        }
        //public void TimerForCompleteOrder()
        //{
        //    //Random random = new Random((int)DateTime.Now.Ticks);
        //    Thread.Sleep(5000);
        //    completeOrders.GetCompletedOrders(onGoingOrders);
        //    Thread.Sleep(7000);
        //    completeOrders.RemoveCompleteOrders();
        //    RunCompleteOrders();     
        //}

    }
}
