using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using NorthwindData;

namespace NorthwindBusiness
{
    public class CustomerManager
    {
        public Customer SelectedCustomer { get; set; }
        private ICustomerService _service;

        public CustomerManager()
        {
            _service = new CustomerService();
        }

        public CustomerManager(ICustomerService service)
        {
            if (service == null)
            {
                throw new ArgumentException("Customer service cannot be null");
            }
            _service = service;
        }


        public void CreateCustomer(string customerId, string contactName = null, string city = null, string postalCode = null, string country = null, string companyName = "")
        {
            var newCust = new Customer() { CustomerId = customerId, ContactName = contactName, City = city, PostalCode = postalCode, Country = country, CompanyName = companyName };
            _service.CreateCustomer(newCust);
        }

        public bool UpdateCustomer(string customerId, string contactName, string city, string postcode, string country, string companyName)
        {

            SelectedCustomer = _service.GetCustomerById(customerId);
            if (SelectedCustomer == null) 
            {
                Debug.WriteLine($"Can't find {customerId}"); 
                return false;
            }

            //SelectedCustomer = db.Customers.Where(c => c.CustomerId == customerId).FirstOrDefault();
            SelectedCustomer.ContactName = contactName;
            SelectedCustomer.City = city;
            SelectedCustomer.PostalCode = postcode;
            SelectedCustomer.Country = country;
            SelectedCustomer.CompanyName = companyName;

            try
            {
                _service.SaveCustomerChanges();
            }
            catch (DbUpdateConcurrencyException e) //an exception can be thrown if the database had been updated since last loaded
            {
                Debug.WriteLine($"Error updating {customerId}");
                return false;
            }
            return true;
        }


        public List<Customer> RetrieveAllCustomers()
        {
            return _service.GetCustomerList();
        }

        public void SetSelectedCustomer(object selectedItem)
        {
            SelectedCustomer = (Customer)selectedItem;
        }

        public bool DeleteCustomer(string customerid)
        {
            SelectedCustomer = _service.GetCustomerById(customerid);
            if (SelectedCustomer == null)
            {
                Debug.WriteLine($"Can't find {customerid}");
                return false;
            }
            _service.RemoveCustomer(SelectedCustomer);
            SelectedCustomer = null;
            return true;
        }

        public bool CheckCustomerExists(string customerid)
        {
            var customer = _service.GetCustomerById(customerid);
            return customer != null ? true : false;
        }
    }
}
