using NUnit.Framework;
using lab_09_exceptions;
using System;

namespace lab_09_exceptions_tests
{
    public class Tests
    {

        [TestCase(-1)]
        [TestCase(4)]
        public void WhenAnIllegalPositionIsSpecifiedAnExceptionIsThrown(int pos)
        {
            var ex = Assert.Throws<ArgumentException>(() => Program.AddBeatle(pos, "George"));
            Assert.AreEqual($"The Beatles do not have a position {pos}", ex.Message, "Exception message not correct");
        }
    }
}