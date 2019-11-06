using System;
using Console = Colorful.Console;
using System.Drawing;

namespace InfoSkärmar
{
    class Program
    {
        static void Main(string[] args)
        {
<<<<<<< HEAD
            CashierMenu cashierMenu = new CashierMenu();
            if (cashierMenu.Login())
            {

            }
            //while (!cashierMenu.Login()) { }
            
=======
<<<<<<< HEAD
            MainMenu.Menu();
=======
>>>>>>> bf85498bd6a34b23407e3c5bb13b84c219bb4542
            Customer customer = new Customer();
            Employee employee = new Employee();
            Console.WriteLine($"Customer: {customer._name} ID: {customer._ID} Kredit: {customer._kredit}");
            Customer customer2 = new Customer();
            Console.WriteLine($"Customer: {customer2._name} ID: {customer2._ID} Kredit: {customer2._kredit}");
            Console.WriteLine($"Employee: {employee._name} ID: {employee._ID} Password: {employee._password}");
>>>>>>> 6b523564a73e61d9b512211420023d2f70586f69
        }
    }
}
