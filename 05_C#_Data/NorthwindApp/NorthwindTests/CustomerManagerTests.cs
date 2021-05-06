using NUnit.Framework;
using NorthwindBusiness;
using NorthwindData;
using System.Linq;

namespace NorthwindTests
{
    public class CustomerTests
    {
        CustomerManager _customerManager;
        [SetUp]
        public void Setup()
        {
           _customerManager = new CustomerManager();
            // remove test entry in DB if present
            using (var db = new NorthwindContext())
            {
                var selectedCustomers =
                from c in db.Customers
                where c.CustomerId == "MANDA"
                select c;

                db.Customers.RemoveRange(selectedCustomers);
                db.SaveChanges();
            }
        }

        [Test]
        public void WhenANewCustomerIsAdded_TheNumberOfCustomersIncreasesBy1()
        {
            using (var db = new NorthwindContext())
            {
                var numCustomers = db.Customers.Count();
                _customerManager.CreateCustomer("MANDA", "Nish Mandal", "Sparta Global", "Birmingham");
                var result = db.Customers.Count();
                Assert.AreEqual(1, result - numCustomers);
            }
        }

        [Test]
        public void WhenACustomersDetailsAreChanged_TheDatabaseIsUpdated()
        {
            using (var db = new NorthwindContext())
            {
                var newCust = new Customer() { CustomerId = "MANDA", ContactName = "Nish Mandal", CompanyName = "Sparta Global" };
                db.Customers.Add(newCust);
                db.SaveChanges();
                var originalCustomer = db.Customers.Find("MANDA");
                _customerManager.UpdateCustomer("MANDA", "Nish Kumar", "Edinburgh", "ED00 45F", "UK");
                var resultCustomer = db.Customers.Find("MANDA");
                Assert.AreNotEqual(originalCustomer.ContactName, resultCustomer.ContactName);
            }
        }

        [Test]

        public void WhenACustomerIsRemoved_TheyAreNoLongerInTheDatabase()
        {
            using (var db = new NorthwindContext())
            {
                var newCust = new Customer() { CustomerId = "MANDA", ContactName = "Nish Mandal", CompanyName = "Sparta Global" };
                db.Customers.Add(newCust);
                db.SaveChanges();
                _customerManager.DeleteCustomer("MANDA");
                var MANDACount = db.Customers.Where(c => c.CustomerId == "MANDA").Count();
                Assert.AreEqual(0, MANDACount);
            }
        }
    

    [TearDown]
        public void TearDown()
        {
            using (var db = new NorthwindContext())
            {
                var selectedCustomers =
                from c in db.Customers
                where c.CustomerId == "MANDA"
                select c;

                db.Customers.RemoveRange(selectedCustomers);
                db.SaveChanges();
            }
        }
    }
}