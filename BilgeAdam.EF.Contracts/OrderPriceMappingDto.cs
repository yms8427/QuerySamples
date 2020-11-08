using System;

namespace BilgeAdam.EF.Contracts
{
    public class OrderPriceMappingDto
    {
        public DateTime OrderDate { get; set; }
        public decimal Amount { get; set; }
    }
}