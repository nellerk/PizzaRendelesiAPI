namespace PizzaRendelesiAPI.Entities
{
    public class Order
    {
        public int Id { get; set; }
        public int CustomerId {  get; set; }
        public int PizzaId { get; set; }
        public int Quantity { get; set; }
        public DateTime OrderDate { get; set; }

        // Navigation properties
        public virtual Customer Customer { get; set; }
        public virtual Pizza Pizza { get; set; }
    }
}
