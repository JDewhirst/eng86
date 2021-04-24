using System;
using NUnit.Framework;
using CalculatorLib;

namespace lab_11_wpf_tests
{
    public class CalculatorTests
    {
        //[SetUp]
        //public void Setup()
        //{
        //}

        [TestCase(1, 8, 9)]
        [TestCase(0, 0, 0)]
        [TestCase(double.MaxValue - 1, 1, double.MaxValue)]
        [TestCase(0, double.MaxValue, double.MaxValue)]
        [TestCase(double.MinValue, double.MaxValue, 0)] // max 2,147,483,647 //min -2147483648
        public void AddTest(double num1, double num2, double expectedResult)
        {
            var result = Calculator.Add(num1, num2);
            Assert.AreEqual(expectedResult, result);
        }

        [TestCase(0, 1, -1)]
        [TestCase(0, 0, 0)]
        [TestCase(894, 100, 794)]
        [TestCase(double.MaxValue, double.MaxValue, 0)]
        [TestCase(double.MaxValue, 1, double.MaxValue - 1)]
        [TestCase(0, double.MaxValue, -double.MaxValue)]
        //[TestCase(double.MinValue, double.MaxValue, 1)]
        public void SubtractTest(double num1, double num2, double expectedResult)
        {
            var result = Calculator.Subtract(num1, num2);
            Assert.AreEqual(expectedResult, result);
        }

        [TestCase(4, 4, 16)]
        [TestCase(60, 60, 3600)]
        [TestCase(-20, -1, 20)]
        [TestCase(double.MinValue, -1, 1.7976931348623157E+308)]
        public void MultiplyTest(double num1, double num2, double expectedResult)
        {
            var result = Calculator.Multiply(num1, num2);
            Assert.AreEqual(expectedResult, result);
        }

        [TestCase(2, 1, 2)]
        [TestCase(2, 2, 1)]
        [TestCase(800, 100, 8)]
        [TestCase(-10, -5, 2)]
        [TestCase(-10, 5, -2)]
        [TestCase(double.MaxValue, double.MinValue, -1)]
        [TestCase(double.MaxValue, double.MaxValue, 1)]
        [TestCase(double.MinValue, double.MinValue, 1)]
        public void DivideTest(double num1, double num2, double expectedResult)
        {
            var result = Calculator.Divide(num1, num2);
            Assert.AreEqual(expectedResult, result);
        }

        [TestCase(5, 1, 0)]
        [TestCase(5, 2, 1)]
        [TestCase(5, 5, 0)]
        [TestCase(-10, 6, -4)]
        [TestCase(-10, -6, -4)]
        public void ModulusTest(double num1, double num2, double expectedResult)
        {
            var result = Calculator.Modulus(num1, num2);
            Assert.AreEqual(expectedResult, result);
        }

        [Test]
        public void DivideByZeroThrowsException()
        {
            Assert.Throws<DivideByZeroException>(() => Calculator.Divide(1, 0));
        }
    }
}