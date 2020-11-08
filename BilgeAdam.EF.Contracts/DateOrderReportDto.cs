using System;

namespace BilgeAdam.EF.Contracts
{
    public class DateOrderReportDto
    {
        public DateTime OrderDate { get; set; }
        public decimal Summary { get; set; }
    }
}