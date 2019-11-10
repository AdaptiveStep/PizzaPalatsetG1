using System;
using System.Collections.Generic;

namespace KundTermiPizzaPalatset
{
    public class Order
    {
        DateTime paid;
        DateTime startProd;
        DateTime finishProd;
        DateTime delivered;


        public Person customer;
        internal List<Product> CustomerProducts = new List<Product>();

        public int TotalSum()
        {
            int temp = 0;
            foreach (Product i in CustomerProducts)
            {
                temp += i.price;
            }
            return temp;
        }
      
        public Order(Person pcustomer)
        {
            customer = pcustomer;
        }
    }
}