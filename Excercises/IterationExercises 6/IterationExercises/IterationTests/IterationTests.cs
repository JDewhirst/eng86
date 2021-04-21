using NUnit.Framework;
using IterationLib;

namespace IterationTests
{
    public class IterationTests
    {
        /**  Implement the static methods in IterationLib.Highest class so that they
         * pass the following tests.  Each method should use a different type of loop as indicated:
         * while, for, foreach and do while.
         * 
         * Add more tests for each method.  What happens when the array is empty?
         * When the array contains only negative numbers?  When all the array elements are the same?
         * 
         * You will find one of the loops will not not be suitable in all cases.  Which is it? 
         * You don't need to find a devious way to make it pass - just note that it is not a suitable for this problem.
         **/

        // HighestWhileLoop

        [Test]
        public void WhenTheArrayIsEmptyHighestWhileLoopReturnsMax()
        {
            int[] nums = { };
            var result = Highest.HighestWhileLoop(nums);
            Assert.AreEqual(int.MaxValue, result);
        }

        [Test]
        public void WhenTheArrayIsOnlyNegativeHighestWhileLoop()
        {
            int[] nums = { -1, -50, -100, -20 };
            var result = Highest.HighestWhileLoop(nums);
            Assert.AreEqual(-1, result);
        }

        [Test]
        public void WhenTheArrayIsAllTheSameHighestWhileLoopReturnsMax()
        {
            int[] nums = { 10, 10, 10, 10};
            var result = Highest.HighestWhileLoop(nums);
            Assert.AreEqual(10, result);
        }

        [Test]
        public void HighestWhileLoopTest()
        {
            int[] nums = { 10, 6, 22, 17, 3 };
            var result = Highest.HighestWhileLoop(nums);
            Assert.AreEqual(22, result);
        }

        // HighestForLoop
        [Test]
        public void WhenTheArrayIsEmptyHighestForLoopReturnsMax()
        {
            int[] nums = { };
            var result = Highest.HighestForLoop(nums);
            Assert.AreEqual(int.MaxValue, result);
        }

        [Test]
        public void WhenTheArrayIsOnlyNegativeHighestForLoop()
        {
            int[] nums = { -1, -50, -100, -20 };
            var result = Highest.HighestForLoop(nums);
            Assert.AreEqual(-1, result);
        }

        [Test]
        public void WhenTheArrayIsAllTheSameHighestForLoopReturnsMax()
        {
            int[] nums = { 10, 10, 10, 10 };
            var result = Highest.HighestForLoop(nums);
            Assert.AreEqual(10, result);
        }
        [Test]
        public void HighestForLoopTest()
        {
            int[] nums = { 10, 6, 22, 17, 3 };
            var result = Highest.HighestForLoop(nums);
            Assert.AreEqual(22, result);
        }

        // HighestForEach
        [Test]
        public void WhenTheArrayIsEmptyHighestForEachLoopReturnsMax()
        {
            int[] nums = { };
            var result = Highest.HighestForEachLoop(nums);
            Assert.AreEqual(int.MaxValue, result);
        }

        [Test]
        public void WhenTheArrayIsOnlyNegativeHighestForEachLoop()
        {
            int[] nums = { -1, -50, -100, -20 };
            var result = Highest.HighestForEachLoop(nums);
            Assert.AreEqual(-1, result);
        }

        [Test]
        public void WhenTheArrayIsAllTheSameHighestForEachLoopReturnsMax()
        {
            int[] nums = { 10, 10, 10, 10 };
            var result = Highest.HighestWhileLoop(nums);
            Assert.AreEqual(10, result);
        }
        [Test]
        public void HighestForEachLoopTest()
        {
            int[] nums = { 10, 6, 22, 17, 3 };
            var result = Highest.HighestForEachLoop(nums);
            Assert.AreEqual(22, result);
        }

        // HighestDoWhile

        [Test]
        public void WhenTheArrayIsEmptyHighestDoWhilehLoopReturnsMax()
        {
            int[] nums = { };
            var result = Highest.HighestDoWhileLoop(nums);
            Assert.AreEqual(int.MaxValue, result);
        }

        [Test]
        public void WhenTheArrayIsOnlyNegativeHighestDoWhileLoop()
        {
            int[] nums = { -1, -50, -100, -20 };
            var result = Highest.HighestDoWhileLoop(nums);
            Assert.AreEqual(-1, result);
        }

        [Test]
        public void WhenTheArrayIsAllTheSameHighestDoWhileLoopReturnsMax()
        {
            int[] nums = { 10, 10, 10, 10 };
            var result = Highest.HighestDoWhileLoop(nums);
            Assert.AreEqual(10, result);
        }
        [Test]
        public void HighestDoWhileLoopTest()
        {
            int[] nums = { 10, 6, 22, 17, 3 };
            var result = Highest.HighestDoWhileLoop(nums);
            Assert.AreEqual(22, result);
        }
    }
}