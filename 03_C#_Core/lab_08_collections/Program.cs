using System;
using System.Collections;
using System.Collections.Generic;

namespace lab_08_collections
{
    class Program
    {
        static void Main(string[] args)
        {
            //// Lists
            //List<int> nums = new List<int>();
            //List<int> nums2 = new List<int>{ 1, 4, 3, 7, 0 };

            //var x = nums2[0];
            //nums2.Remove(1);
            //nums2.ForEach(x => Console.WriteLine(x));

            //// Exercise
            //List<int> nums = new List<int> { 1, 2, 3, 4, 5 };
            //nums.ForEach(x => Console.WriteLine(x));
            //nums.Add(6);
            //nums.Add(7);
            //nums.Add(8);
            //nums.Insert(2, 4);
            //nums.Reverse();
            //nums.RemoveAt(3);
            //Console.WriteLine(String.Join(", ", nums));
            //nums.Sort();
            //Console.WriteLine(String.Join(", ", nums));

            //// Queues
            //var myQueue = new Queue<string>();
            //myQueue.Enqueue("Nish");
            //myQueue.Enqueue("Jack");

            //// prints Nish then Jack
            //foreach (var item in myQueue)
            //{
            //    Console.WriteLine(item);
            //}

            //Console.WriteLine(myQueue.Peek()); // shows first item without removing it
            //Console.WriteLine(myQueue.Contains("Jack"));
            //Console.WriteLine(myQueue.Dequeue());

            //// Stacks

            //var myStack = new Stack<string>();

            //myStack.Push("Blue");
            //myStack.Push("Green");
            //myStack.Push("Yellow");
            //myStack.Push("Red");

            //Console.WriteLine(myStack.Pop());

            //var eng86 = new List<string> { "Eric", "Rouz", "Callum", "Hamse", "Callum" };
            //eng86.ForEach(x => Console.WriteLine(x));

            //var hSet = new HashSet<string>(eng86);
            //Console.WriteLine();
            //// hSet of the list will only have Callum once, can only have unique values
            //foreach (var item in hSet)
            //{
            //    Console.WriteLine(item);
            //}

            //Dictionary<int, string> trainers = new Dictionary<int, string>();
            //trainers.Add(1, "Cathy");
            //trainers.Add(2, "David");
            //trainers.Add(3, "Paula");
            //trainers.TryAdd(3, "Manish");

            //var trainees = new Dictionary<int, string>() { {1, "Bongani" },{2, "Uzair" },{3, "Michael" },{4, "Hossain" } };
            //var trainees2 = new Dictionary<int, string>() { [1] = "Bongani" , [2] = "Uzair", [3] = "Michael", [4] = "Hossain" };

            //foreach (var item in trainees)
            //{
            //    Console.WriteLine(item.Key + " " + item.Value + " " + item);
            //}

            //string input = "Sparta";
            //input = input.Trim().ToLower();

            //var count = new Dictionary<char, int>();
            //foreach (var c in input)
            //{
            //    if (count.ContainsKey(c))
            //    {
            //        count[c]++;
            //    }
            //    else
            //    {
            //        count.Add(c, 1);
            //    }
            //}

            //foreach (var item in count)
            //{
            //    Console.WriteLine(item);
            //}

        }
    }
}
