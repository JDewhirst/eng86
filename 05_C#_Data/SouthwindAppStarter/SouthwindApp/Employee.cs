using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SouthwindApp
{
    public partial class Employee
    {
        public Employee()
        {
            Customers = new HashSet<Customer>();
        }

        public string EmployeeId { get; set; }
        public string EmployeeName { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        public string PostalCode { get; set; }
        public virtual ICollection<Customer> Customers { get; set; }

        public override string ToString()
        {
            return $"{EmployeeName} - {PostalCode}";
        }
    }
}