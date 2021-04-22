using System;

namespace IterationLib
{
    public class Highest
    {
        public static int HighestWhileLoop(int[] nums)
        {
            // this method should use a while loop

            int i = 0;
            int biggest = int.MinValue; 
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
            
            int biggest = int.MinValue;
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] > biggest) { biggest = nums[i];  }
            }
            return biggest;
        }

        public static int HighestForEachLoop(int[] nums)
        {
            // this method should use a for-each loop
            int biggest = int.MinValue;
            foreach (var number in nums)
            {
                if (number > biggest) { biggest = number; }
            }
            return biggest;
        }

        public static int HighestDoWhileLoop(int[] nums)
        {
            // this method should use a do-while loop
           
            int biggest = int.MinValue;
            int i = 0;
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