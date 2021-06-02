using NUnit.Framework;
using FizzBuzzApp;

namespace FizzBuzzTest
{
    public class FizzBuzzShould
    {

        [Test]
        public void GivenOne_Return_OneString()
        {
            Assert.That(Program.FizzBuzz(1), Is.EqualTo("1"));
        }

        [TestCase(1,"1")]
        [TestCase(2, "2")]
        public void GivenANumber_Return_ItsString(int input, string expected)
        {
            Assert.That(Program.FizzBuzz(input), Is.EqualTo(expected));
        }

        [Test]
        public void GivenThree_Return_Fizz()
        {
            Assert.That(Program.FizzBuzz(3), Is.EqualTo("Fizz"));
        }

        [TestCase(3)]
        [TestCase(6)]
        [TestCase(9)]
        public void GivenANumberDivisibleByThree_Return_FizzString(int input)
        {
            Assert.That(Program.FizzBuzz(input), Is.EqualTo("Fizz"));
        }

        [Test]
        public void GivenFive_Return_Buzz()
        {
            Assert.That(Program.FizzBuzz(5), Is.EqualTo("Buzz"));
        }

        [TestCase(5)]
        [TestCase(10)]
        [TestCase(15)]
        public void GivenANumberDivisibleByFive_Return_Buzz(int input)
        {
            Assert.That(Program.FizzBuzz(input), Is.EqualTo("Buzz"));
        }

        [Test]
        public void GivenFifteen_Return_FizzBuzz()
        {
            Assert.That(Program.FizzBuzz(15), Is.EqualTo("FizzBuzz"));
        }

        [TestCase(15)]
        [TestCase(30)]
        [TestCase(45)]
        public void GivenANumberDivisibleByFifteen_return_FizzBuzz(int input)
        {
            Assert.That(Program.FizzBuzz(input), Is.EqualTo("FizzBuzz"));
        }
    }
}