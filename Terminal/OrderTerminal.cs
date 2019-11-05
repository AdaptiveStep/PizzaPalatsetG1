using System;
using System.Collections.Generic;
using System.Linq;

namespace PizzaPalatsetG1
{
    public abstract class OrderTerminal : Terminal
    {
        public OrderTerminal(){
            isInteractable = false;
        }
        
    }
}
