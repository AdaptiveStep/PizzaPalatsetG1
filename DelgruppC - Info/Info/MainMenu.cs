using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;


namespace Info
{
    class MainMenu
    {
        OrdersOngoing onGoingOrders;
        OrdersComplete completeOrders;
        public MainMenu()
        {
            this.onGoingOrders = new OrdersOngoing();
            this.completeOrders = new OrdersComplete();           
        }

        public void Run()
        {
            //Console.WriteAscii("PIZZA PALATSET", Color.Red);

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
                RunOngoingOrders();
                RunCompleteOrders();
                counterForCompleteOrder++;

            } while (true);
        }

        public void GenerateNewOrder()
        {            
            Thread.Sleep(1000);
            onGoingOrders.NewOrder();
        }

        public void RunOngoingOrders()
        {               
            onGoingOrders.ShowOngoingOrders();
        }

        public void RunCompleteOrders()
        {
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
