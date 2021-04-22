# Collections

Use generic collections including List, Queue, Stack, and Dictionary

Discuss the advantages advantage and disadv of arrays vs. lists

Lists are mutable, arrays are not. 

Collects are classes for holding and manipulating groups of primitive types or objects.

System.Collections.Generics: List, Queue, Stack, and more.

Don't use ArrayLists, they've been deprecated.

```c#
ArrayList myAL = new ArrayList();
myAL.add("Hello");
myAL.add(1);
```

## Lists

```c#
// Lists
List<int> nums = new List<int>();
List<int> nums2 = new List<int>{ 1, 4, 3, 7, 0 };

var x = nums2[0];
nums2.Remove(1);
nums2.ForEach(x => Console.WriteLine(x));
```

## Queues

A list except it's first in first out (FIFO). New items can only be added to the back of the queue. Items can only be removed from the front of the queue.

```c#
var myQueue = new Queue<string>();
myQueue.Enqueue("Nish");
myQueue.Enqueue("Jack");

// prints Nish then Jack
foreach (var item in myQueue)
{
    Console.WriteLine(item);
}

Console.WriteLine(myQueue.Peek()); // shows first item without removing it
Console.WriteLine(myQueue.Contains("Jack"));
Console.WriteLine(myQueue.Dequeue());
```

## Stacks

When you push something onto a stack it becomes the first element. First in, last out. FILO

```c#
var myStack = new Stack<string>();

myStack.Push("Blue");
myStack.Push("Green");
myStack.Push("Yellow");
myStack.Push("Red");

Console.WriteLine(myStack.Pop()); //gives us Red
```

## Hash Sets

Usually used for LINQ methods, distinct, union, intersect, etc. Also used for comparisons. They are sets where each item must be unique.

```c#
var eng86 = new List<string> { "Eric", "Rouz", "Callum", "Hamse", "Callum" };
eng86.ForEach(x => Console.WriteLine(x));

var hSet = new HashSet<string>(eng86);
Console.WriteLine();
// hSet of the list will only have Callum once, can only have unique values
foreach (var item in hSet)
{
Console.WriteLine(item);
}
```

## Dictionaries

Dictionaries are collections of key:value pairs. Keys must be unique

```c#
Dictionary<int, string> trainers = new Dictionary<int, string>();
trainers.Add(1, "Cathy");
trainers.Add(2, "David");
trainers.Add(3, "Paula");
trainers.TryAdd(3, "Manish");
```

Declaring dictionaries.

```c#
var trainees = new Dictionary<int, string>() { {1, "Bongani" },{2, "Uzair" },{3, "Michael" },{4, "Hossain" } };
var trainees2 = new Dictionary<int, string>() { [1] = "Bongani" , [2] = "Uzair", [3] = "Michael", [4] = "Hossain" };

foreach (var item in trainees)
{
	Console.WriteLine(item.Key + " " + item.Value + " " + item);
}
```

