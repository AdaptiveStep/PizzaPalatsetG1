namespace PizzamakerTerminal
{
    public class CompleteOrder
    {
        private string orderName;

        public CompleteOrder(string orderName)
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
