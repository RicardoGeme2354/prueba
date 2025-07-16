namespace NovaInventory.Models.Entities
{
    public class Order
    {
        public int orderId { get; set; }
        
        public int userId { get; set; }
        public int productId { get; set; }
    }
}