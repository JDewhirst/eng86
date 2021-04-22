# Arrays and Strings

An array is a way to store a list of data of the same type. A string is text, a string of characters.

Arrays and strings are on the heap, since they're reference types.

## Declaring Arrays

```c#
int[] intArray = { 1, 2, 3, 4 }; // declare and initialise
char[] charArray = new char[4]; // declare with default values as null
// for ints/floats the default is 0
charArray[0] = 'j'; // Inserting values
charArray[1] = 'a';
charArray[2] = 'c';
charArray[3] = 'k';
```

## Collections vs Arrays

Strings and arrays are immutable, you can't add stuff to it.

## Multidimensional Arrays

```c#
int[,] grid = new int[2, 4]; //2 rows, 4 columns
int[,,,] grid4d = new int[4, 3, 20, 30];
```

## Jagged Arrays

Jagged arrays are arrays of arrays. like multidimensional arrays, each row is not guaranteed to have the same number of columns.

```c#
//// Jagged arrays
string[][] animalGrid = new string[2][];
animalGrid[0] = new string[4];
animalGrid[0][0] = "Cat";
animalGrid[0][1] = "Elephant";
animalGrid[0][2] = "Mouse";
animalGrid[1] = new string[] { "Parrot", "Dog" };
```

## Lists

Lists are a kind of collection

```c#
// Lists
var beatles = new List<string>() ;
beatles.Add("Lennon");
beatles.Add("McCartney");

beatles.ForEach(x => Console.WriteLine(x));

var myArray = new int[] { 1, 2, 3, 4 };
var myList = new List<int>(myArray);
var myList2 = new List<int>() { 4, 3, 2, 1 };
```

They've got methods like .Count(), .Add(), .Remove(), &c,

## Strings

Are a reference type. Have many similar methods as arrays do. Plus things like .ToUpper(), .Trim(), &c. You can also iterate through them, access a specific index,&c.

Strings are immutable. 

### Aside on the Stack & Heap

When things are run it's off the stack. If we have a string on the stack, it's just holding a reference to the addresses of the chars on the heap. 

### Concatenation

```c#
$"Some text {a variable:p2} more text {another variable:f2}";
"Some text " + a variable + " more text " + another variable;
```

p2 and f2 are formatting for percentages with 2 decimal places and a float with 2 decimal places respectively.

### Parsing

Casting takes place at compile time, parsing takes place at runtime and actually instructs to interpret the data in a different way

TryParse() returns a boolean indicating whether the conversion has succeeded.

### Split method

Returns a string array of the substrings separated by a specified delimiter.

### StringBuilder

A class in System.Text, which contains methods for building and manipulating strings.

```c#
// StringBuilder
var sb = new StringBuilder();
var sb2 = new StringBuilder("Hello world");
sb2.Append(" and eng86");
sb2.AppendLine("something something");
```

.ToString(), an override of the inherited .ToString(), on StringBuilder converts to a string, unsurprisingly.