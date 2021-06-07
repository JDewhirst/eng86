using NUnit.Framework;
using NorthwindBusiness;
using NorthwindData;
using System.Linq;
using Moq;
using Microsoft.EntityFrameworkCore;

namespace NorthwindTests
{
    class CustomerManagerShould
    {

        //// Using moq as DummyE
        private CustomerManager _sut;

        [Test]
        public void BeAbleToConstruct_CustomerManager_ThisWontWork()
        {
            //Act
            _sut = new CustomerManager(null);

            //Assert
            Assert.That(_sut, Is.InstanceOf<Customer>());
        }

        [Test]
        public void BeAbleToConstruct_CustomerManager()
        {
            //Arrange
            var mockCustomerService = new Mock<ICustomerService>();
            
            //Act
            _sut = new CustomerManager(mockCustomerService.Object);

            //Assert
            Assert.That(_sut, Is.InstanceOf<CustomerManager>());
        }

        //// Using Moq as a STUB 
        /// happy path
        [Test]
        public void ReturnTrue_WhenUpdateIsCalled_WithValidId()
        {
            var mockCustomerService = new Mock<ICustomerService>();
            var originalCustomer = new Customer
            {
                CustomerId = "NAGLE",
                ContactName = "Liam Nagle",
                CompanyName = "Sparta Global",
                City = "Leicester",
                Region = "Midlands"
            };

            //Make up what we want the mock to return
            mockCustomerService.Setup(cs => cs.GetCustomerById("NAGLE")).Returns(originalCustomer);

            //Act
            _sut = new CustomerManager(mockCustomerService.Object);
            var result = _sut.UpdateCustomer("NAGLE", It.IsAny<string>(), It.IsAny<string>(), It.IsAny<string>(), It.IsAny<string>(), It.IsAny<string>());

            // Assert
            Assert.That(result);
        }

        /// SAD path
        [Test]
        public void ReturnFalse_WhenUpdateIsCalled_WithInValidId()
        {
            var mockCustomerService = new Mock<ICustomerService>();

            //Make up what we want the mock to return
            mockCustomerService.Setup(cs => cs.GetCustomerById("NAGLE")).Returns((Customer)null);

            //Act
            _sut = new CustomerManager(mockCustomerService.Object);
            var result = _sut.UpdateCustomer("NAGLE", It.IsAny<string>(), It.IsAny<string>(), It.IsAny<string>(), It.IsAny<string>(), It.IsAny<string>());

            // Assert
            Assert.That(result, Is.False);
        }

        //// DeleteCustomer method tests
        ///HAPPY PATH
        [Test]
        public void ReturnTrue_WhenDeleteCustomerIsCalled_WithValidId()
        {
            var mockCustomerService = new Mock<ICustomerService>();
            var originalCustomer = new Customer
            {
                CustomerId = "NAGLE",
                ContactName = "Liam Nagle",
                CompanyName = "Sparta Global",
                City = "Leicester",
                Region = "Midlands"
            };

            //Make up what we want the mock to return
            mockCustomerService.Setup(cs => cs.GetCustomerById("NAGLE")).Returns(originalCustomer);

            //Act
            _sut = new CustomerManager(mockCustomerService.Object);
            var result = _sut.DeleteCustomer("NAGLE");
            // Assert
            Assert.That(result);
        }

        /// SAD Path
        [Test]
        public void ReturnFalse_WhenDeleteCustomerIsCalled_WithInValidId()
        {
            var mockCustomerService = new Mock<ICustomerService>();

            //Make up what we want the mock to return
            mockCustomerService.Setup(cs => cs.GetCustomerById("NAGLE")).Returns((Customer)null);

            //Act
            _sut = new CustomerManager(mockCustomerService.Object);
            var result = _sut.DeleteCustomer("NAGLE");
            // Assert
            Assert.That(result, Is.False);
        }

        /// Moq simulating throwing an exception
        /// 
        [Test]
        public void ReturnFalse_WhenUpdateIsCalled_AndDatabaseExceptionIsThrown()
        {
            // Arrange
            var mockCustomerService = new Mock<ICustomerService>();
            mockCustomerService.Setup(cs => cs.GetCustomerById(It.IsAny<string>())).Returns(new Customer());
            mockCustomerService.Setup(cs => cs.SaveCustomerChanges()).Throws<DbUpdateConcurrencyException>();
            _sut = new CustomerManager(mockCustomerService.Object);
            // Act
            var result = _sut.UpdateCustomer("NAGLE", It.IsAny<string>(), It.IsAny<string>(), It.IsAny<string>(), It.IsAny<string>(), It.IsAny<string>());

            // Assert
            Assert.That(result, Is.False);
        }

        //// Behaviour based testing - just verifying that the correct methods are called in ICustomerService by our CustomerManager
        ///
        [Test]
        public void CallSaveCustomerChanges_WhenUpdateIsCalled_WithValidId()
        {
            // Arrange
            var mockCustomerService = new Mock<ICustomerService>();
            mockCustomerService.Setup(cs => cs.GetCustomerById(It.IsAny<string>())).Returns(new Customer());
            _sut = new CustomerManager(mockCustomerService.Object);

            // Act
            _sut.UpdateCustomer("NAGLE", It.IsAny<string>(), It.IsAny<string>(), It.IsAny<string>(), It.IsAny<string>(), It.IsAny<string>());
            mockCustomerService.Verify(cs => cs.SaveCustomerChanges(), Times.Once);
        }

        [Test]
        public void NotCallSaveCustomerChanges_WhenUpdateIsCalled_WithInvalidId()
        {
            // Arrange
            var mockCustomerService = new Mock<ICustomerService>();
            mockCustomerService.Setup(cs => cs.GetCustomerById(It.IsAny<string>())).Returns((Customer)null);
            _sut = new CustomerManager(mockCustomerService.Object);

            // Act
            _sut.UpdateCustomer("NAGLE", It.IsAny<string>(), It.IsAny<string>(), It.IsAny<string>(), It.IsAny<string>(), It.IsAny<string>());
            mockCustomerService.Verify(cs => cs.SaveCustomerChanges(), Times.Never);

        }

        [Test]
        public void RemoveCustomer_IsNotCalled_WhenCreateMethodIsCalled()
        {
            // Arrange
            var mockCustomerService = new Mock<ICustomerService>();
            mockCustomerService.Setup(cs => cs.GetCustomerById(It.IsAny<string>())).Returns(new Customer());
            _sut = new CustomerManager(mockCustomerService.Object);

            // Act
            _sut.CreateCustomer("NAGLE", It.IsAny<string>(), It.IsAny<string>(), It.IsAny<string>(), It.IsAny<string>(), It.IsAny<string>());
            
            // Verify
            mockCustomerService.Verify(cs => cs.RemoveCustomer(It.IsAny<Customer>()), Times.Never);

        }
    }
}
