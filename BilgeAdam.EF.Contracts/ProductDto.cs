namespace BilgeAdam.EF.Contracts
{
    public class ProductDto
    {
        public string Name { get; set; }
        public decimal? Price { get; set; }
        public short? Stock { get; set; }
        public string CategoryName { get; set; }
        public string Company { get; set; }
    }
}