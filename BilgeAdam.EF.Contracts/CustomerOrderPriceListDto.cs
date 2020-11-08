using System;
using System.Collections.Generic;

namespace BilgeAdam.EF.Contracts
{
    public class CustomerOrderPriceListDto
    {
        public DateTime OrderDate { get; set; }
        public IEnumerable<OrderDetailDto> Detail { get; set; }
    }
}