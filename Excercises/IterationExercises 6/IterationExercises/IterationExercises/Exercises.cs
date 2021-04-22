using System;

namespace IterationLib
{

    public class Program
    {
       
        public static void Main(string[] args)
        {
            //ignore
        }
    }
    public class Exercises
    {
        // returns the lowest number in the array nums
        public static int Lowest(int[] nums)
        {

            int i = 1;
            int smallest = Int32.MaxValue;
            while (i < nums.Length)
            {
                if (nums[i] < smallest) { smallest = nums[i]; }
                i++;
            }
            return smallest;
        }

        // returns the sum of all numbers between 1 and n inclusive that are divisible by either 2 or 5
        public static int SumEvenFive(int max)
        {
            int sum = 0;
            for (int i = 0; i <= max; i++)
            {
                if (i % 2 == 0 || i % 5 == 0)
                {
                    sum += i;
                }
            }
            return sum;
        }

        // Returns the a string containing the count of As, Bs, Cs and Ds in the parameter string
        // all other letters are ignored
        public static string CountLetters(string input)
        { // "A:1 B:4 C:2 D:5"
            int[] counts = new int[4];
            string letters = "ABCD";

            for (int i = 0; i < 4; i++)
            {
                foreach (var character in input)
                {
                    if (character == letters[i])
                    {
                        counts[i]++;
                    }
                }
            }
            return $"A:{counts[0]} B:{counts[1]} C:{counts[2]} D:{counts[3]}";
        }
    }
}