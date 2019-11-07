using System;

namespace Info
{
    class Program
    {
        static void Main(string[] args)
        {

            CashierMenu cashierMenu = new CashierMenu();
            if (cashierMenu.Login())
            {
               
                OrdersOngoing newOrder = new OrdersOngoing();
                newOrder.NewOrder();             
                newOrder.NewOrder();
                newOrder.ShowOngoingOrders();
                

            }
            //while (!cashierMenu.Login()) { }


            //MainMenu.Menu();

            Customer customer = new Customer();
            Employee employee = new Employee();
            Console.WriteLine($"Customer: {customer._name} ID: {customer._ID} Kredit: {customer._kredit}");
            Customer customer2 = new Customer();
            Console.WriteLine($"Customer: {customer2._name} ID: {customer2._ID} Kredit: {customer2._kredit}");
            Console.WriteLine($"Employee: {employee._name} ID: {employee._ID} Password: {employee._password}");
        }
    }
}
