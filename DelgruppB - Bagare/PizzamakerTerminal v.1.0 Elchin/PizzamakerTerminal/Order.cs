namespace PizzamakerTerminal
{
    public class Order
    {
        private string orderName;

        public Order(string orderName)
        {
            this.orderName = orderName;
        }

        public string GetName()
        {
            return orderName;
        }

        public int ID { get; set; }
    }
}
