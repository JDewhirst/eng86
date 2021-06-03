# Mocking

Why mocking ? Slow even with a local database. We'd like to be able to test the classes without needing the database to be set up, or similar for an API. 

The generic term he uses is a [Test Double](http://xunitpatterns.com/Test Double.html) (think stunt double). Test Double is a generic term for any case where you replace a production object for testing purposes. There are various kinds of double that Gerard lists:

- **Dummy** objects are passed around but never actually used. Usually they are just used to fill parameter lists.
- **Fake** objects actually have working implementations, but usually take some shortcut which makes them not suitable for production (an [InMemoryTestDatabase](https://www.martinfowler.com/bliki/InMemoryTestDatabase.html) is a good example).
- **Stubs** provide canned answers to calls made during the test, usually not responding at all to anything outside what's programmed in for the test.
- **Spies** are stubs that also record some information based on how they were called. One form of this might be an email service that records how many messages it was sent.
- **Mocks** are pre-programmed with expectations which form a specification of the calls they are expected to receive. They can throw an exception if they receive a call they don't expect and are checked during verification to ensure they got all the calls they were expecting.

## moq

```c#
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
```

