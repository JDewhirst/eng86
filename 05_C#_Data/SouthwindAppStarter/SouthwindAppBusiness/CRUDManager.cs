using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SouthwindApp;

namespace SouthwindAppBusiness
{
    public class CRUDManager
    {
        public Customer SelectedCustomer { get; set; }

        public void CreateCustomer(string customerId, string contactName, string companyName, string city = null)
        {
            var newCust = new Customer() { CustomerId = customerId, ContactName = contactName};
            using (var db = new SouthwindContext())
            {
                db.Customers.Add(newCust);
                db.SaveChanges();
            }
        }

        public void UpdateCustomer(string customerId, string contactName, string city, string postcode, string country)
        {
            using (var db = new SouthwindContext())
            {
                SelectedCustomer = db.Customers.Where(c => c.CustomerId == customerId).FirstOrDefault();
                SelectedCustomer.ContactName = contactName;
                SelectedCustomer.City = city;
                SelectedCustomer.PostalCode = postcode;
                SelectedCustomer.Country = country;
                // write changes to database
                db.SaveChanges();
            }
        }


        public List<Customer> RetrieveAllCustomers()
        {
            using (var db = new SouthwindContext())
            {
                return db.Customers.ToList();
            }
        }

        public void CreateEmployee(string employeeID, string employeeName, string postalCode, string city = null)
        {
            var newEmployee = new Employee() { EmployeeId = employeeID, EmployeeName = employeeName, City = city, PostalCode = postalCode };
            using (var db = new SouthwindContext())
            {
                db.Employees.Add(newEmployee);
                db.SaveChanges();
            }
        }

        public List<Employee> RetrieveAllEmployees()
        {
            using (var db = new SouthwindContext())
            {
                return db.Employees.ToList();
            }
        }

        public void SetSelectedCustomer(object selectedItem)
        {
            SelectedCustomer = (Customer)selectedItem;
        }

        public void DeleteCustomer(string customerid)
        {
            using (var db = new SouthwindContext())
            {
                var selectedCustomer =
                    from c in db.Customers
                    where c.CustomerId == customerid
                    select c;

                db.Customers.RemoveRange(selectedCustomer);
                db.SaveChanges();
            }
        }
    }
}
