using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Cashier
{
    public class CashierMenu
    {
        OrdersOnGoing onGoingOrders;
        OrdersComplete completeOrders;
        
        public CashierMenu()
        {
            this.onGoingOrders = new OrdersOnGoing();
            this.completeOrders = new OrdersComplete();
        }

        private string _password = "Password123";
        private bool Login()
        {
            do
            {
                Console.Write("Skriv in Lösenord: ");
                string passwordCandidate = Console.ReadLine();

                if (passwordCandidate == _password)
                {
                    Console.Clear();
                    return true;
                }
                Console.Clear();
            } while (true);
        }

        public void Run()
        {
            //Console.WriteAscii("PIZZA PALATSET", Color.Red);
            if (Login())
            {
                Console.WriteLine($"\t Pågående ordrar\t\t\t\tKlara ordrar");
                Console.WriteLine($" ______________________________\t\t\t______________________________");
                Thread thread = new Thread(CheckForInput);
                thread.Start();
                do
                {
                    do
                    {
                        GenerateNewOrder();
                        RunOngoingOrders();
                        RunCompleteOrders();
                    } while (true);

                    //ConsoleKey key = Console.ReadKey(false).Key;
                    //if (key == ConsoleKey.Enter)
                    //{
                    //    completeOrders.GetCompletedOrders(onGoingOrders);
                    //}
                    //else if (key == ConsoleKey.Spacebar)
                    //{
                    //    completeOrders.RemoveCompleteOrders();
                    //}
                    

                } while (true);
            }

        }

        public void GenerateNewOrder()
        {
            Thread.Sleep(2000);
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

        public void CheckForInput()
        {
            do
            {
                ConsoleKey key = Console.ReadKey(true).Key;
                if (key == ConsoleKey.Enter)
                {
                    completeOrders.GetCompletedOrders(onGoingOrders);
                }
                else if (key == ConsoleKey.Spacebar)
                {
                    completeOrders.RemoveCompleteOrders();

                }

            } while (true);
        }

        //public  void TimerForCompleteOrder()
        //{

        //    Random random = new Random((int)DateTime.Now.Ticks);
        //    Thread.Sleep(random.Next(7000, 15000));
        //    completeOrders.GetCompletedOrders(onGoingOrders);
        //    Thread.Sleep(5000);
        //    completeOrders.RemoveCompleteOrders();
        //}
    }
}
