namespace A_1_3690.Models
{
    public class Orders
    {
        public int Order_id { get; set; }
        public string Customer_id { get; set; }
        public int Quantity { get; set; }
        public DateTime Odate { get; set; }
        public DateTime Expected_delivery_date { get; set; }
    }
}
