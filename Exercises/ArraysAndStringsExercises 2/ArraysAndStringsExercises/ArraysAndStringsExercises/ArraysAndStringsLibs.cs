
using System;
using System.Text;

namespace ArraysAndStringsLib
{
    public class Exercises
    {
        // returns a formatted address string given its components
        public static string Address(int number, string street, string city, string postcode)
        {
            return $"{number} {street}, {city} {postcode}.";
        }
        // returns a string representing a test score, written as percentage to 1 decimal place
        public static string Scorer(int score, int outOf)
        {
            return $"You got {score} out of {outOf}: {Math.Round( (float)score/(float)outOf * 100, 1) }%";
        }

        // returns the double represented by the string, or -999 if conversion is not possible
        public static double ParseNum(string numString)
        {
            try
            {
                return System.Convert.ToDouble(numString);
            }
            catch (System.FormatException)
            {
                return -999;
            }
        }
        public static string ManipulateString(string input, int num)
        {
            // "  Cathy", 10, "CATHY0123456789"
            var output = string.Empty;
            for (int i = 0; i < num; i++)
            {
                output = String.Concat(output, i.ToString());
            }
            return input.Trim().ToUpper() + output;
        }
    }
}