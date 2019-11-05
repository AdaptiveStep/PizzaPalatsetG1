using System;
using System.Collections.Generic;
using System.Linq;
using System.Timers;

namespace PizzaPalatsetG1
{
    public class OrderTerminal : Terminal
    {
        public delegate void FakeOrderHandle(object source, EventArgs args);

        public event FakeOrderHandle FakeOrder;
        public OrderTerminal()
        {
            isInteractable = false;
        }
        public override void Run()
        {
            Console.Write("... \n");
            System.Threading.Thread.Sleep(1000);
            OnFakeOrder();
            System.Threading.Thread.Sleep(2000);
        }
        protected virtual void OnFakeOrder()
        {
            Console.Write("Fake order delivered! todo; Add this to loop. Quitting for now \n");
        }

    }
}
