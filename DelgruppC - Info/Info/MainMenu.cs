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
            
            do
            {
                GenerateNewOrder();
                RunOngoingOrders();
                RunCompleteOrders();

            } while (true);

        }

        public void GenerateNewOrder()
        {            
            //Random random = new Random((int)DateTime.Now.Ticks);
            Thread.Sleep(2000);
            onGoingOrders.NewOrder();

            Thread thread = new Thread(TimerForCompleteOrder);
            thread.Start();
        }

        public void RunOngoingOrders()
        {
            onGoingOrders.ShowOngoingOrders();
        }

        public void RunCompleteOrders()
        {
            completeOrders.ShowCompletedOrders();
        }

        public void TimerForCompleteOrder()
        {
            Random random = new Random((int)DateTime.Now.Ticks);
            Thread.Sleep(random.Next(7000, 15000));
            completeOrders.GetCompletedOrders(onGoingOrders);
            Thread.Sleep(5000);
            completeOrders.RemoveCompleteOrders();
        }

    }
}
