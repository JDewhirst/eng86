using System;
using System.Collections.Generic;
using System.Text;

namespace lab_05_arrays_and_strings
{
    class Program
    {
        static void Main(string[] args)
        {
            //int[] intArray = { 1, 2, 3, 4 }; // declare and initialise
            //char[] charArray = new char[4]; // declare with default values as null
            //                                // for ints/floats the default is 0
            //charArray[0] = 'j'; // Inserting values
            //charArray[1] = 'a';
            //charArray[2] = 'c';
            //charArray[3] = 'k';

            //int[] intArray = { 1, 2, 3, 4 };
            //Console.WriteLine(ArraySum(intArray));

            //int[,] grid = new int[2, 4]; //2 rows, 4 columns
            //grid[0, 0] = 1; //accessing values
            //grid[1, 0] = 2;
            ////int[,,,] grid4d = new int[4, 3, 20, 30];
            //int[,] grid2d = { { 1, 2, 3, 4 }, { 6, 1, 7, 10 } };

            //Console.WriteLine(grid2d[1,3]);

            //// Jagged arrays
            //string[][] animalGrid = new string[2][];
            //animalGrid[0] = new string[4];
            //animalGrid[0][0] = "Cat";
            //animalGrid[0][1] = "Elephant";
            //animalGrid[0][2] = "Mouse";
            //animalGrid[1] = new string[] { "Parrot", "Dog" };

            //// Lists
            //var beatles = new List<string>();
            //beatles.Add("Lennon");
            //beatles.Add("McCartney");

            //beatles.ForEach(x => Console.WriteLine(x));

            //var myArray = new int[] { 1, 2, 3, 4 };
            //var myList = new List<int>(myArray);
            //var myList2 = new List<int>() { 4, 3, 2, 1 };

            //// Parsing strings
            //Console.WriteLine("How many trainess");
            //string input = Console.ReadLine();

            //int numTrainees = Int32.Parse(input); // if you enter not an int32 an exception will be thrown
            //Console.WriteLine(numTrainees);

            //Console.WriteLine("how many trainees ?");
            //string input = Console.ReadLine();

            //bool success = Int32.TryParse(input, out int numTrainees);
            //if (success)
            //{
            //    Console.WriteLine($"There are {numTrainees} in Eng86");
            //}
            //else
            //{
            //    Console.WriteLine("Please enter a valid number");
            //}

            //// StringBuilder
            //var sb = new StringBuilder();
            //var sb2 = new StringBuilder("Hello world");
            //sb2.Append(" and eng86");
            //sb2.AppendLine("something something");

            //var sb3 = new StringBuilder();
            //sb3.AppendLine("Jack");
            //sb3.Insert(0, true);
            //sb3.Replace('a', 'o');
            //Console.WriteLine(sb3);
        }

        //public static int ArraySum(int[] practiceArray)
        //{
        //    int arraySum = 0;

        //    foreach (var num in practiceArray)
        //    {
        //        arraySum += num;
        //    }
        //    return arraySum;
        //}
    }
}
