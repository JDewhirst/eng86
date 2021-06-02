using NUnit.Framework;

namespace AdvancedNUnit
{
    public class Tests
    {
        [SetUp]
        public void Setup() { }

        [Test]
        public void Add_Always_ReturnsExpectedResult()
        {
            // Arrange
            var subject = new Calculator();
            // Act
            var result = subject.Add(2, 4);
            // Assert
            Assert.AreEqual(6, result);
        }
    }
    
}