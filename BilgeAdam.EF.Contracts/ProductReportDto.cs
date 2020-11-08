namespace BilgeAdam.EF.Contracts
{
    public class ProductReportDto
    {
        public string Name { get; set; }
        public decimal Value { get; set; }
    }

    public class ComparedProductReportDto
    {
        public string Name { get; set; }
        public decimal DefaultValue { get; set; }
        public decimal DiscountedValue { get; set; }
    }
}