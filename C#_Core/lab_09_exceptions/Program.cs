using System;
using System.IO;

namespace lab_09_exceptions
{
    public class Program
    {
        private static string[] _theBeatles = new string[] { "John", "Paul", "George", "Ringo" };
        static void Main(string[] args)
        {
            //try
            //{
            //    _theBeatles[4] = "Brian"; // throws out of range exception
            //}
            //catch (Exception)
            //{
            //    Console.WriteLine("Sorry, you cannot join the Beatles");
            //}

            //// try catch finally
            //int x = 10;
            //int y = 0;
            //int output = 0;

            //try
            //{
            //    output = x / y;
            //}
            //catch (Exception)
            //{
            //    Console.WriteLine("An Exception occured");
            //}
            //finally
            //{
            //    Console.WriteLine("But life goes on");
            //}

            //// Specialised Exceptions :  full example in Nish's notes
            //try
            //{
            //    File.OpenRead("tryEx.txt");
            //}
            //catch (DirectoryNotFoundException ex)
            //{
            //    Console.WriteLine("Could not find tryEx directory");
            //}
            //catch (FileNotFoundException ex)
            //{
            //    Console.WriteLine("something something");
            //}

            // Throwing exceptions
            try
            {
                AddBeatle(4, "Brian");
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception thrown: " + e.Message);
            }
        }

        public static void AddBeatle(int pos, string name)
        {
            if (pos < 0 || pos >= _theBeatles.Length)
            {
                throw new ArgumentException($"The Beatles do not have a position {pos}");
            }
            _theBeatles[pos] = name;
        }
    }
}
