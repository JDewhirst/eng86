using System;

namespace IterationLib
{
    public class Highest
    {
        public static int HighestWhileLoop(int[] nums)
        {
            // this method should use a while loop
            if (nums.Length == 0) { return int.MaxValue; };

            int i = 1;
            int biggest = nums[0]; 
            while (i < nums.Length)
            {
                if (nums[i] > biggest) { biggest = nums[i]; }
                i++;
            }
            return biggest;
        }

        public static int HighestForLoop(int[] nums)
        {
            // this method should use a for loop
            if (nums.Length == 0) { return int.MaxValue; };
            int biggest = nums[0];
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] > biggest) { biggest = nums[i];  }
            }
            return biggest;
        }

        public static int HighestForEachLoop(int[] nums)
        {
            // this method should use a for-each loop
            if (nums.Length == 0) { return int.MaxValue; };
            int biggest = nums[0];
            foreach (var number in nums)
            {
                if (number > biggest) { biggest = number; }
            }
            return biggest;
        }

        public static int HighestDoWhileLoop(int[] nums)
        {
            // this method should use a do-while loop
            if (nums.Length == 0) { return int.MaxValue; };
            int biggest = nums[0];
            int i = 1;
            do
            {
                if (nums[i] > biggest) { biggest = nums[i]; }
                i++;
            } 
            while 
            (i < nums.Length);

            return biggest;
        }
    }
}