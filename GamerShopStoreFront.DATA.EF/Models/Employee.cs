using System;
using System.Collections.Generic;

namespace GamerShopStoreFront.DATA.EF.Models
{
    public partial class Employee
    {
        public int EmployeeId { get; set; }
        public string LastName { get; set; } = null!;
        public string FirstName { get; set; } = null!;
        public string? Title { get; set; }
        public DateTime BirthDate { get; set; }
        public DateTime HireDate { get; set; }
        public string Address { get; set; } = null!;
        public string City { get; set; } = null!;
        public string State { get; set; } = null!;
        public string ZipCode { get; set; } = null!;
        public string? Phone { get; set; }
        public string? Email { get; set; }
    }
}
