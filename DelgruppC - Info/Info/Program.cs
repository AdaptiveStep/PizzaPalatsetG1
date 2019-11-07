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
                OrdersComplete complete = new OrdersComplete();
                newOrder.NewOrder();             
                newOrder.NewOrder();
                complete.GetCompletedOrders(newOrder);
                newOrder.ShowOngoingOrders();
                complete.ShowCompletedOrders();

                
                

            }
            //while (!cashierMenu.Login()) { }


            //MainMenu.Menu();

            //Customer customer = new Customer();
            //Employee employee = new Employee();
            //Console.WriteLine($"Customer: {customer.Name} ID: {customer.ID} Kredit: {customer._kredit}");
            //Customer customer2 = new Customer();
            //Console.WriteLine($"Customer: {customer2.Name} ID: {customer2.ID} Kredit: {customer2._kredit}");
            //Console.WriteLine($"Employee: {employee.Name} ID: {employee.ID} Password: {employee._password}");
        }
    }
}
