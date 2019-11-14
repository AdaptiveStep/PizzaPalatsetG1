namespace PizzamakerTerminal
{
    public class ActiveOrder
    {
        private string orderName;

        public ActiveOrder(string orderName)
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