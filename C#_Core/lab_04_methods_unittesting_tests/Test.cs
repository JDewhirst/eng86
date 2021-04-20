using NUnit.Framework;
using Methods;
namespace lab_04_methods_unittesting_tests
{
    public class Tests
    {
        //private int _result;
        //private int _sum;

        //[SetUp]
        //public void Setup()
        //{
        //    // arrange and act
        //    _result = Program.TripleCalc(10, 2, 4, out int sum);
        //    _sum = sum;
        //}

        [TestCase(10,2,4,80)]
        [TestCase(0,-3,7,0)]
        public void ProductIsCorrect(int a, int b, int c, int expected)
        {
            var actual = Program.TripleCalc(a, b, c, out int sum);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(10,2,4,16)]
        [TestCase(0,-3,7,4)]
        public void SumIsCorrect(int a, int b, int c, int expected)
        {
            Program.TripleCalc(a, b, c, out int sum);
            Assert.AreEqual(expected, sum);
        }
    }
}