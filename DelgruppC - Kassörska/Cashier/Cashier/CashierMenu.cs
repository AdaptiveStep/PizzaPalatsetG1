using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
/*  Autor: @ Grupp 1
 *  Version @1.0
 *  jonathan.harlin@icloud.com
 */
namespace Cashier
{
    /*Denna klass är "huvudmenyn" och hanterar flera metoder,
     * för att bland annat skapa nya ordrar samt skriva ut dem till consolen */
    public class CashierMenu
    {
        OrdersOnGoing onGoingOrders;
        OrdersComplete completeOrders;
        private string _password = "Password123";
        public CashierMenu()
        {
            this.onGoingOrders = new OrdersOnGoing();
            this.completeOrders = new OrdersComplete();
        }
 
        public void Run()/*Denna metod loggar in kassörskan och skriver sedan ut alla ordrar.*/
        {
            if (Login())
            {     
                Console.SetWindowSize(100, 45);
                PrintLogo();                
                Console.WriteLine($"\n\t\t Pågående ordrar\t\t\tKlara ordrar");
                Console.WriteLine($"\t ______________________________\t\t______________________________");
                Thread thread = new Thread(CheckForInput);
                thread.Start();

                do
                {
                    GenerateNewOrder();
                    PrintOrders();
                } while (true);   
            }

        }
        
        private bool Login()/*Denna metod hanterar lösenord och returnerar
                            true när kassörskan skriver in korrekt lösenord*/
        {
            do
            {            
                Console.SetWindowSize(100, 45);
                PrintLogo();
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

        public void GenerateNewOrder()/*Simulerar inkomande ordrar från kunder*/
        {
            Thread.Sleep(2000);
            onGoingOrders.NewOrder();
        }

        public void PrintOrders()/*Visar pågående och klara ordrar i consolen*/
        {
            onGoingOrders.ShowOngoingOrders();
            completeOrders.ShowCompletedOrders();
        }
        public void CheckForInput()/*Metod körs i separat tråd för att hantera input från kassörskan*/
        {
            do
            {
                if (onGoingOrders.OnGoingOrderID.Count != 0 && onGoingOrders.OnGoingOrderID.Count != 1)
                {
                    ConsoleKey key = Console.ReadKey(true).Key;
                    if (key == ConsoleKey.Enter)//Flyttar order från pågende till klar
                    {
                        completeOrders.GetCompletedOrders(onGoingOrders);
                    }
                    else if (key == ConsoleKey.Spacebar)//Tar bort färdiga ordrar
                    {
                        completeOrders.RemoveCompleteOrders();
                    }
                }
            } while (true);
        }
        public static void PrintLogo()//Printar ut PizzaPalatset logga.
        {
            string pizzalogo = @"   
                        ██████╗ ██╗███████╗███████╗ █████╗                
                        ██╔══██╗██║╚══███╔╝╚══███╔╝██╔══██╗               
                        ██████╔╝██║  ███╔╝   ███╔╝ ███████║               
                        ██╔═══╝ ██║ ███╔╝   ███╔╝  ██╔══██║               
                        ██║     ██║███████╗███████╗██║  ██║               
                        ╚═╝     ╚═╝╚══════╝╚══════╝╚═╝  ╚═╝               
                                                                                    
        ██████╗  █████╗ ██╗      █████╗ ████████╗███████╗███████╗████████╗
        ██╔══██╗██╔══██╗██║     ██╔══██╗╚══██╔══╝██╔════╝██╔════╝╚══██╔══╝
        ██████╔╝███████║██║     ███████║   ██║   ███████╗█████╗     ██║   
        ██╔═══╝ ██╔══██║██║     ██╔══██║   ██║   ╚════██║██╔══╝     ██║   
        ██║     ██║  ██║███████╗██║  ██║   ██║   ███████║███████╗   ██║   
        ╚═╝     ╚═╝  ╚═╝╚══════╝╚═╝  ╚═╝   ╚═╝   ╚══════╝╚══════╝   ╚═╝   ";
            Console.WriteLine(pizzalogo);
        }
    }
}
