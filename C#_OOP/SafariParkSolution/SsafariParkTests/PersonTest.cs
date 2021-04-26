using NUnit.Framework;
using SafariPark;

namespace SafariParkTests
{
    public class PersonTest
    {

        [TestCase("Nish", "Mandal", "Nish Mandal")]
        [TestCase("", "", " ")]
        public void GetFullNameTest(string fName, string lName, string expected)
        {
            var subject = new Person(fName, lName);
            var actual = subject.GetFullName();
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void AgeTest()
        {
            var subject = new Person("A", "B") { Age = 30 };
            Assert.AreEqual(30, subject.Age);
        }
    }
}