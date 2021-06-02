using System;

namespace FizzBuzzApp
{
    public class Program
    {
        static void Main(string[] args)
        {
            int max = 50;
            for (int i = 0; i <= max; i++)
            {
                Console.WriteLine($"{FizzBuzz(i)}");
            }
        }

        public static string FizzBuzz(int n)
        {
            string output = "";
            if (n % 3 == 0)
            {
                output += "Fizz";
            }
            if (n % 5 == 0)
            {
                output += "Buzz";
            }
            if (output == "")
            {
                return n.ToString();
            }
            return output;
        }
    }
}
