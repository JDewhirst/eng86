using NUnit.Framework;
using CalculatorLibrary;

namespace calculator_tests
{
    public class Tests
    {
        //[SetUp]
        //public void Setup()
        //{
        //}

        [TestCase(1, 8, 9)]
        [TestCase(0, 0, 0)]
        [TestCase(int.MaxValue - 1 , 1, int.MaxValue)]
        [TestCase(0, int.MaxValue, int.MaxValue)]
        [TestCase(int.MinValue, int.MaxValue, -1)] // max 2,147,483,647 //min -2147483648
        public void AddTest(int num1, int num2, int expectedResult)
        {
            var result = Calculator.Add(num1, num2);
            Assert.AreEqual(expectedResult, result);
        }

        [TestCase(0, 1, -1)]
        [TestCase(0, 0, 0)]
        [TestCase(894, 100, 794)]
        [TestCase(int.MaxValue, int.MaxValue, 0)]
        [TestCase(int.MaxValue, 1, int.MaxValue - 1)]
        [TestCase(0, int.MaxValue, -int.MaxValue)]
        [TestCase(int.MinValue, int.MaxValue, 1)]
        public void SubtractTest(int num1, int num2, int expectedResult)
        {
            var result = Calculator.Subtract(num1, num2);
            Assert.AreEqual(expectedResult, result);
        }

        [TestCase(4, 4, 16)]
        [TestCase(60, 60, 3600)]
        [TestCase(-20, -1, 20)]
        [TestCase(int.MinValue+1, -1, 2147483647)]
        public void MultiplyTest(int num1, int num2, int expectedResult)
        {
            var result = Calculator.Multiply(num1, num2);
            Assert.AreEqual(expectedResult, result);
        }

        [TestCase(2, 1, 2)]
        [TestCase(2, 2, 1)]
        [TestCase(800, 100, 8)]
        [TestCase(-10, -5, 2)]
        [TestCase(-10, 5, -2)]
        [TestCase(int.MaxValue, int.MinValue, 0)]
        [TestCase(int.MaxValue, int.MaxValue, 1)]
        [TestCase(int.MinValue, int.MinValue, 1)]
        public void DivideTest(int num1, int num2, int expectedResult)
        {
            var result = Calculator.Divide(num1, num2);
            Assert.AreEqual(expectedResult, result);
        }

        [TestCase(5, 1, 0)]
        [TestCase(5, 2, 1)]
        [TestCase(5, 5, 0)]
        [TestCase(-10, 6, -4)]
        [TestCase(-10, -6, -4)]
        public void ModulusTest(int num1, int num2, int expectedResult)
        {
            var result = Calculator.Modulus(num1, num2);
            Assert.AreEqual(expectedResult, result);
        }
    }
}