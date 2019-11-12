using System;

namespace KundTermiPizzaPalatset
{
    /* author: @ AndréTheGiant @ Hariz aka Skattmasen
 * version: @2.0
 * andre.lundstrom@gmail.com - Hariz@kth.se
 * */
    public class Program
    {
        static void Main(string[] args)
        {
            Terminal terminal = new Terminal();
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Press anykey to continue ");
                Console.ReadKey();
                Customer customer = new Customer();
                Order order = new Order(customer);
                Submeny.StarMenuChoice(order);
            }
        }
    }
}
