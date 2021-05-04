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

        [TestCase(30,30)]
        [TestCase(-10,0)]
        public void AgeTest(int input, int expected)
        {
            var subject = new Person("A", "B") { Age = input };
            Assert.AreEqual(expected, subject.Age);
        }
    }
}