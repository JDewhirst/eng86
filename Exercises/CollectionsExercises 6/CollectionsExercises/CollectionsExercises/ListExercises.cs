
using System;
using System.Collections.Generic;

namespace CollectionsExercisesLib
{
    public class ListExercises
    {
        // returns a list of all the integers between 1 to max inclusive
        // that are multiples of 5
        public static List<int> MakeFiveList(int max)
        {
            List<int> multiplesOfFive = new List<int>();
            for (int i = 5; i <= max; i+=5)
            {
                multiplesOfFive.Add(i);
            }
            return multiplesOfFive;
        }

        // return the average of all the numbers in argList 
        public static double Average(List<double> argList)
        {
            double sum = 0.0;
            foreach (var item in argList)
            {
                sum += item;
            }
            return argList.Capacity != 0 ? sum / argList.Capacity : 0.0;
        }

        // returns a list of all the strings in sourceList that start with the letter 'A' or 'a'
        public static List<string> MakeAList(List<string> sourceList)
        {
            List<string> outputList = new List<string>();
            foreach (var item in sourceList)
            {
                if ( item[0] == 'A' || item[0] == 'a' ) { outputList.Add(item);  }
            }
            return outputList;
        }
    }
}
  