using System;
using System.Collections.Generic;
using System.Linq;

namespace PizzaPalatsetG1
{
    class Order
    {
        bool isCancelled = false;
        bool isStarted = false;
        private Cart cart;
        public Timestamp stamp;
        public Order(Cart cart) 
        {
            this.isStarted = true;
            this.cart = cart;
            this.stamp.ordered = DateTime.Now;
        }
    }
}
