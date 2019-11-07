using System;
using System.Collections.Generic;
using System.Linq;

namespace PizzaPalatsetG1
{
    public delegate Item FakeEvent(int a, int b);

    public abstract class Terminal
    {
        protected bool isInteractable;
        protected int x;
        protected int y;
        public delegate int MatchDelegate(int a, int b); // todo;
        System.Timers.Timer fake_events = new System.Timers.Timer(); // todo;
        public abstract void Run();
    }
}
