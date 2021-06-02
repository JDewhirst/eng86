using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;

namespace AdvancedNUnit
{
    public class Tests
    {
        [SetUp]
        public void Setup() { }

        [Test]
        [Category("Happy Path")]
        public void Add_Always_ReturnsExpectedResult()
        {
            // Arrange
            var subject = new Calculator();
            // Act
            var result = subject.Add(2, 4);
            // Assert
            Assert.AreEqual(6, result);
            // Other class model Assert Methods
            //Assert.True
            //Assert.Null
            //Assert.Contains
            //Assert.Throws<ExceptionType>
            //Assert.Greater
        }

        // Constrain vs Classic Model
        [Test]
        public void Constraint_Model()
        {
            //arrange
            var subject = new Calculator();
            //act and assert
            Assert.That(subject.Add(2, 4), Is.EqualTo(6));
            Assert.That(subject.DivisibleBy3(6));
            Assert.That(subject.DivisibleBy3(7), Is.False);
            Assert.That(subject.ToString(), Does.Contain("Calculator"));
        }

        [Test]
        public void ClassicAssertionModel_ListTest()
        {
            var myList = new List<int> { 1, 2, 3 };
            Assert.AreEqual(1, myList.Where(x => x == 4).Count());
        }

        [Test]
        public void ConstraintAssertionModel_ListTest_1()
        {
            var myList = new List<int> { 1, 2, 3 };
            Assert.That(myList, Has.Exactly(1).EqualTo(4));
        }

        [Test]
        public void ConstraintAssertionModel_ListTest_2()
        {
            var myList = new List<int> { 1, 2, 3 };
            Assert.That(myList, Does.Contain(7));
        }
        [Test]
        public void ConstraintAssertionModel_ListTest_3()
        {
            var myList = new List<int> { 1, 2, 3 };
            Assert.That(myList, Has.Length.GreaterThan(4));
        }

        // Testing for exceptions
        [Test]
        [Category("Unhappy Path")]
        public void ClassicModel_ThrowingExceptions()
        {
            var subject = new Calculator();
            var ex = Assert.Throws<ArgumentException>(() => subject.Divide(1, 0));
            Assert.AreEqual(ex.Message, "Can't divide by 0");
        }

        [Test]
        [Category("Unhappy Path")]
        public void ConstraintModel_ThrowingExceptions()
        {
            var subject = new Calculator();
            Assert.That(() => subject.Divide(3, 0), Throws.ArgumentException.And.Message.Contains("Can't divide by 0"));
        }

        //// String constraints
        ///
        [Test]
        public void StringConstraints()
        {
            var subject = new Calculator();
            var strResult = subject.ToString();
            Assert.That(strResult, Does.Contain("Calculator").And.Contains("Calc"));
            Assert.That(strResult, Does.Not.Contain("Orange"));
            Assert.That(strResult, Is.EqualTo("AdvancedNUnit.Calculator"));
            Assert.That(strResult, Is.EqualTo("advancedNunit.calculator").IgnoreCase);
            Assert.That(strResult, Is.Not.Empty);
        }

        //// Collection constraints
        ///
        [Test]
        public void TestListOfStrings()
        {
            var fruit = new List<string> { "apple", "pear", "banana", "peach" };
            Assert.That(fruit, Does.Contain("pear"));
            Assert.That(fruit, Has.Exactly(2).StartsWith("PEA").IgnoreCase);
            Assert.That(fruit, Has.Count.EqualTo(4));
        }

        [Test]
        public void RangeConstraintTests()
        {
            Assert.That(8, Is.InRange(1, 10));
            var nums = new List<int> { 4, 2, 7, 5, 9 };
            Assert.That(nums, Is.All.InRange(1, 10));
            Assert.That(nums, Has.Exactly(3).InRange(1, 5));
        }

        [TestCaseSource("AddCases")]
        public void Add_Always_ReturnsExpectedResult(int x, int y, int expected)
        {
            var subject = new Calculator();
            Assert.That(subject.Add(x, y), Is.EqualTo(expected));
        }

        public static object[] AddCases =
        {
            new int[] {2,4,6},
            new int[] {-2,3,1}
        };
    }
    
}