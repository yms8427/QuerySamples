using System;

namespace BilgeAdam.EF.Contracts
{
    public class CustomerOrderDto
    {
        public int OrderCode { get; set; }
        public DateTime? OrderDate { get; set; }
    }
}