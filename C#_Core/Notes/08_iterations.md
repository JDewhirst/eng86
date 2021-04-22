# Iterations

## For 

```c#
for (int i = 0; i <= 10; i++)
{
	Console.WriteLine(i);
}
```

## Foreach

```c#
foreach (var item in myArray)
{
    Console.WriteLine(item);
}
```

Foreach only iterates forward in single steps, no access to a loop variable

## While

Often don't know the exact number of loops we need to run through. Two types, While, and Do While

### While

Checks continue expression at the beginning of every loop.

```c#
int counter = 0;
while (counter < 10)
{
Console.WriteLine(counter*10);
counter++;
}
```

This will stop before writing 100

### Do While

Checks the continue expression at the end of every loop. Ensures that the body is always executed once.

```c#
int counter = 11;
do
{
Console.WriteLine(counter * 10);
counter++;
} while (counter < 10);
```

This block will execute at least once

## Breaking out of loops

break, continue, goto (hah), return, throw an exception.

```c#
for (int i = 0; i < 10; i++)
{
    Console.WriteLine(i);
    if (i == 5)
    {
        Console.WriteLine("Breaking out");
        break;               
    }
    Console.WriteLine("in the loop");
}
```

## Continue

Used to prematurely finish one iteration and enter the next iteration.

```c#
int counter = 0;
while (counter < 10)
{
    counter++;
    Console.WriteLine(counter);
    if (counter < 4) continue;    // if counter is less than 4, restart the loop
    {
    Console.WriteLine(counter * 10);
    }
}
```

Will result in 
1
2
3
4
40
5
50
6
60
7
70
8
80
9
90
10
100