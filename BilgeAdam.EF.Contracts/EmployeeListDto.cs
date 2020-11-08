using System;

namespace BilgeAdam.EF.Contracts
{
    public class EmployeeListDto
    {
        public string FullName { get; set; }
        public DateTime? HireDate { get; set; }
        public string Phone { get; set; }
        public string City { get; set; }
    }
}