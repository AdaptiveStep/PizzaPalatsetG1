using System;
using System.Collections.Generic;
using System.Linq;

namespace PizzaPalatsetG1
{
    public delegate Item FakeEvent(int a, int b);

    public abstract class Terminal
    {
        protected bool isInteractable;
        /// <summary>
        /// Används som x value i setcursor, håller reda på var cordinaten befinner sig
        /// </summary>
        protected int x;
        /// <summary>
        /// -//- this.x
        /// </summary>
        protected int y;
        static protected int cart_x; // The carts position below menu
        static protected int cart_y; //
        public delegate int MatchDelegate(int a, int b); // todo;
        System.Timers.Timer fake_events = new System.Timers.Timer(); // todo;
        public abstract void Run();
    }
}
