﻿/* Project name: PizzaPalatset
 * author: @ AndréTheGiant @ Hariz aka Skattmasen
 * groupmembers: Elchin, Jonathan, Marcus, André, Hariz
 * version: @2.3
 * andre.lundstrom@gmail.com - Hariz @kth.se
 **/
using System;

namespace KundTermiPizzaPalatset
{
    
    public class Program
    {
        static void Main(string[] args)
        {
            Terminal terminal = new Terminal();
            while (true)
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Cyan;
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
                  ╚═╝     ╚═╝  ╚═╝╚══════╝╚═╝  ╚═╝   ╚═╝   ╚══════╝╚══════╝   ╚═╝   
                  
        █████╗█████╗█████╗█████╗█████╗█████╗█████╗█████╗█████╗█████╗█████╗█████╗█████╗█████╗█████╗ 
        ╚════╝╚════╝╚════╝╚════╝╚════╝╚════╝╚════╝╚════╝╚════╝╚════╝╚════╝╚════╝╚════╝╚════╝╚════╝                                                                                                           
                 ██╗██╗                                                                       
                 ╚═╝╚═╝                                                                       
        ██╗   ██╗ █████╗ ██╗     ██╗  ██╗ ██████╗ ███╗   ███╗███╗   ███╗███████╗███╗   ██╗██╗
        ██║   ██║██╔══██╗██║     ██║ ██╔╝██╔═══██╗████╗ ████║████╗ ████║██╔════╝████╗  ██║██║
        ██║   ██║███████║██║     █████╔╝ ██║   ██║██╔████╔██║██╔████╔██║█████╗  ██╔██╗ ██║██║
        ╚██╗ ██╔╝██╔══██║██║     ██╔═██╗ ██║   ██║██║╚██╔╝██║██║╚██╔╝██║██╔══╝  ██║╚██╗██║╚═╝
         ╚████╔╝ ██║  ██║███████╗██║  ██╗╚██████╔╝██║ ╚═╝ ██║██║ ╚═╝ ██║███████╗██║ ╚████║██╗
          ╚═══╝  ╚═╝  ╚═╝╚══════╝╚═╝  ╚═╝ ╚═════╝ ╚═╝     ╚═╝╚═╝     ╚═╝╚══════╝╚═╝  ╚═══╝╚═╝";
                Console.WriteLine(pizzalogo);
                Console.ResetColor();
                Console.WriteLine("\t\t\t\t\tPress anykey to continue ");
                Console.ReadKey();
                Customer customer = new Customer();
                Order order = new Order(customer);
                Submeny.StarMenuChoice(order);
                //När användaren trycker på valfri knapp så skapas ett nytt customer och orderobjekt
                //orderobjektet skickas med genom hela programmet när ny metod kallas.
            }
        }
    }
}
