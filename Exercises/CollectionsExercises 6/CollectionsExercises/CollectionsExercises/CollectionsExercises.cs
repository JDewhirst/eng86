
using System.Collections.Generic;
using System.Text;

namespace CollectionsExercisesLib
{
    public class CollectionsExercises
    {
        /* removes and returns the next num entries in the queue, as a comma separated string */
        public static string NextInQueue(int num, Queue<string> queue)
        {
            var outputString = new StringBuilder("");
            if (num != 0)
            {
                
                outputString.Append(queue.Dequeue());
                int i = 1;
                int length = queue.Count;

                while (i <= length && i < num)
                {
                    outputString.Append($", {queue.Dequeue()}");
                    i++;
                }
                return outputString.ToString();
            }

            return outputString.ToString();
            
        }

        /* uses a Stack to create and return array of ints in reverse order to the one supplied */
        public static int[] Reverse(int[] original)
        {
            int[] reverseArray = new int[original.Length];
            var stack = new Stack<int>();

            foreach (var num in original)
            {
                stack.Push(num);
            }

            int i = 0;
            while (i < original.Length)
            {
                reverseArray[i] = stack.Pop();
                i++;
            }

            return reverseArray;
        }
        // using a Dictionary, counts and returns (as a string) the occurence of the digits 0-9 in the given string
        public static string CountDigits(string input)
        {
            Dictionary<char, int> count = new Dictionary<char, int>();
            foreach (var c in input)
            {
                if ("1234567890".Contains(c))
                {
                    if (count.ContainsKey(c))
                    {
                        count[c]++;
                    }
                    else
                    {
                        count.Add(c, 1);
                    }
                }
            }
            var output = new StringBuilder();
            foreach (var item in count)
            {
                output.Append(item);
            }
            return output.ToString();
        }
    }
}