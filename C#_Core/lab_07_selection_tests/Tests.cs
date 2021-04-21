using NUnit.Framework;
using Selection;
using System;

namespace lab_07_selection_test
{
    public class Tests
    {
        [Test]
        public void Mark40AndOverPasses()
        {
            var actual = Program.PassFail(40);
            Assert.AreEqual("Pass", actual);
        }

        [Test]
        public void Mark39AndUnderFails()
        {
            var actual = Program.PassFail(39);
            Assert.AreEqual("Fail", actual);
        }

        [TestCase(75,"Pass with Distinction")]
        [TestCase(76, "Pass with Distinction")]
        [TestCase(100, "Pass with Distinction")]
        public void Mark75AndOverPassesWithDistinction(int a, string expected)
        {
            var actual = Program.Grade(a);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(60,"Pass with Merit")]
        [TestCase(65, "Pass with Merit")]
        [TestCase(74,"Pass with Merit")]
        public void MarkBetween60And74PassesWithMerit(int a, string expected)
        {
            var actual = Program.Grade(a);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(101)]
        [TestCase(-1)]
        public void MarkOutOfBoundsThrowsException(int a)
        {
            Assert.Fail();
            // Assert.Throws<IllegalMarkException>(() => Program.Grade(a);
        }

        [TestCase(3, "Code Red")]
        [TestCase(2, "Code Amber")]
        [TestCase(1, "Code Amber")]
        [TestCase(0, "Code Green")]
        [TestCase(5, "Error")]
        public void PriorityTest(int level, string expected)
        {
            var actual = Program.Priority(level);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(60, "Pass")]
        [TestCase(40, "Pass")]
        [TestCase(39, "Fail")]
        public void PassTest(int mark, string expected)
        {
            var actual = Program.PassFailTernary(mark);
            Assert.AreEqual(expected, actual);
        }
    }
}