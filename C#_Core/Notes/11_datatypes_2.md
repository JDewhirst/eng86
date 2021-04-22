# Data Types 2

## DateTime class

Dates and times are complicated. The .NET version is a struct.

## Arithmetic

```c#
var date = DateTime.Today;
var birthDate = new DateTime(1989, 11, 02);
var age = date - birthDate;
Console.WriteLine((int)age.Days / 365.25);
```

## Formatting

```c#
var output = DateTime.Now.ToString("dd-MM-yyyy");
var output2 = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
var output3 = DateTime.Now.ToString("yy-dd-MM");
```

## TimeSpan and Ticks

TimeSpan is a struct, it represents what it says it does.

```            c#
// 1 hour time span
var timespan = new TimeSpan(1, 0, 0);
// add timespan to time now
var date = DateTime.Now + timespan;
// add 1 tick to our date
var tick = new TimeSpan(1);
date = date + tick;
```

There is a stopwatch class which contains all the methods you would expect. It's in System.Diagnostics

```c#
// Stopwatch
var s = new Stopwatch();
s.Start();
int total = 0;

for (int i = 0; i < Int32.MaxValue; i++)
{
    total += i;
}
s.Stop();
Console.WriteLine(s.Elapsed);
Console.WriteLine(s.ElapsedMilliseconds);
Console.WriteLine(s.ElapsedTicks);
```

## Enumerated Types

Used when we know all possible values at compile time.

Often useful to be able to represent a fixed set of constants as a data type; days of the week, suits in a pack of cars, &c

Each member in an enum has a value, defaulting to begin at 0 and increase in order. You can cast an enum to an int to get its value.

```c#
// In main
Suit theSuit = Suit.HEARTS;
Console.WriteLine(Suits(theSuit));
// Outside main
public enum Suit
{
    HEARTS, CLUBS, DIAMONDS, SPADES
}

public static string Suits(Suit suit)
{
    switch (suit)
    {
        case Suit.HEARTS:
            return "You have stole in";
        case Suit.CLUBS:
            return "The best one in town";
        case Suit.DIAMONDS:
            return "My best mate";
        case Suit.SPADES:
            return "Dig deep";
        default:
            return "Not a suit";
    }
}
```

### C# Built-In Enums

Days of the week in DateTime()

## Default Values

0 for numerical types and char. false for bool. Primitive types have default values. 

For reference types it's null (nothing to point to).

## Nullable Types

```c#
bool? hasPassed; // gives value of null

int? hasPassed = null;

if (hasPassed.HasValue)
{
    Console.WriteLine("Congrats");
}
else
{
    Console.WriteLine("No value");
}
```

### Null Coalescing Operator - ??

possiblyNullValue ?? valueIfNulll

```c#
int? nullableScore = null;
int score = nullableScore ?? -9999;
int score1 = nullableScore.GetValueOrDefault(-1);
int score2 = nullableScore.GetValueOrDefault();
```

##  Keywords

### readonly

Don't have to assign when we declare it

### const

Do have to assign when we declare it.

Used when declaring a number bool string variable to indicate it can't be changed

### Dynamic

Breaks type safety. Don't use it, C# is strongly typed, if you want something that isn't, use something else.

## Random Class

```c#
var rng = new Random(); //seed with current time
var rngSeeded = new Random(42); // enter our own seed
var between1And10 = rngSeeded.Next(1, 11);
```

