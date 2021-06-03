using NUnit.Framework;
using NorthwindBusiness;
using NorthwindData;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace NorthwindTests
{
    public class CustomerServiceTests
    {
        private CustomerService _sut;
        private NorthwindContext _context;

        [OneTimeSetUp]
        public void Setup()
        {
            // Options are that the database will have the same structure as the NorthwindDatabase, but will be stoerd in memory
            var options = new DbContextOptionsBuilder<NorthwindContext>().UseInMemoryDatabase(databaseName: "Example_DB").Options;
            _context = new NorthwindContext(options);
            _sut = new CustomerService(_context);

            // Add stuff to our in memory database
            _sut.CreateCustomer(new Customer { CustomerId = "MANDA", ContactName = "Nish Mandal", CompanyName = "Sparta Global", City = "Paris" });
            _sut.CreateCustomer(new Customer { CustomerId = "FRENC", ContactName = "Cathy French", CompanyName = "Sparta Global", City = "Ottowa" });
        }

        [Test]
        public void GivenANewCustomer_CreateCustomerAddsThemToTheDatabase()
        {
            var numberOfCustomersBefore = _context.Customers.Count();
            var newCustomer = new Customer { CustomerId = "NELSO", ContactName = "Ramone Nelson", CompanyName = "Sparta Global", City = "Luton"};
            _sut.CreateCustomer(newCustomer);
            var numberOfCustomersAfter = _context.Customers.Count();
            Assert.That(numberOfCustomersAfter, Is.EqualTo(numberOfCustomersBefore + 1));
            var result = _sut.GetCustomerById("NELSO");
            Assert.That(result.ContactName, Is.EqualTo("Ramone Nelson"));
            Assert.That(result.CompanyName, Is.EqualTo("Sparta Global"));
            Assert.That(result.City, Is.EqualTo("Luton"));

            // clean up

            _context.Customers.Remove(newCustomer);
            _context.SaveChanges();

        }

        [Test]
        public void GivenWrongCustomerId_getCustomerById_ReturnsNull()
        {
            Assert.That(_sut.GetCustomerById("NELSO"), Is.Null);
        }

        [Test]
        public void GivenACustomerId_DeleteFromDatabase()
        {
            var customersBefore = _sut.GetCustomerList().Count();
            var selectedCustomer = _sut.GetCustomerById("MANDA");
            _sut.RemoveCustomer(selectedCustomer);
            var customersAfter = _sut.GetCustomerList().Count();
            Assert.That(customersAfter, Is.EqualTo(customersBefore - 1));

            //cleanup
            _context.Customers.Add(selectedCustomer);
            _context.SaveChanges();

        }

        [Test]
        public void GivenAValidId_CorrectCustomerIsReturned()
        {
            var result = _sut.GetCustomerById("MANDA");
            Assert.That(result, Is.TypeOf<Customer>());
            Assert.That(result.ContactName, Is.EqualTo("Nish Mandal"));
            Assert.That(result.CompanyName, Is.EqualTo("Sparta Global"));
            Assert.That(result.City, Is.EqualTo("Paris"));
        }
    }
}
