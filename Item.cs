using System;

namespace PizzaPalatsetG1
{
    public class Item
    {
        public int id { get; set; }
        public string name { get; set; }
        public string[] ingredients { get; set; }
        public decimal price { get; set; }
        public int prep_seconds { get; set; }
    }
}
