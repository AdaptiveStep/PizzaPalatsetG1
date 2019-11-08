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
            RunOngoingOrders();
            RunCompleteOrders();

            do
            {
                GenerateNewOrder();
                
                
            } while (true);

        }

        public void GenerateNewOrder()
        {
            Random random = new Random();
            Thread.Sleep(random.Next(5000, 10000));
            onGoingOrders.NewOrder();
            TimerForCompleteOrder();
            RunOngoingOrders();
            RunCompleteOrders();
              
            //Random random = new Random();           
            
            //Thread.Sleep(random.Next(5000, 10000));
            //onGoingOrders.NewOrder();
        }

        public void RunOngoingOrders()
        {
            Thread secondThread = new Thread(() =>
            {
                Console.SetCursorPosition(4, 14);
                onGoingOrders.ShowOngoingOrders();
                
            });
            secondThread.Start();            
        }

        public void RunCompleteOrders()
        {
            Thread thirdThread = new Thread(() =>
            {                
                Console.SetCursorPosition(4, 50);
                completeOrders.ShowCompletedOrders();
                
                    
            });
            thirdThread.Start();
        }

        public void TimerForCompleteOrder()
        {
            Thread fourthThread = new Thread(() =>
            {
                Thread.Sleep(1000);                
                completeOrders.GetCompletedOrders(onGoingOrders);              
            });
            fourthThread.Start();

            Thread fifthThread = new Thread(() =>
            {
                Thread.Sleep(10000);
                completeOrders.RemoveCompleteOrders();
            });
            fifthThread.Start();
        }
    }
}
