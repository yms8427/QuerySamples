namespace BilgeAdam.EF.Contracts
{
    public class OrderDetailDto
    {
        public decimal Price { get; set; }
        public int Quantity { get; set; }
        public float Discount { get; set; }
    }
}