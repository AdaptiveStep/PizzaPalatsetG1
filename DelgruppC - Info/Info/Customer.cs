﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Info
{
    public class Customer : Person
    {
        public int _kredit { get; set; }

        public Customer()
        {
            
            _kredit = 1000;
        }
    }
}
