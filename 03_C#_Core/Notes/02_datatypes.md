# C# Variables, Data Types, and Casting

Strongly typed and weakly typed languages

What are primitive types ?

## What's a variable ?

A variable in C# has a specific type, which determines it's size, what can be stored in it.

C# naming conventions, variables start with a letter or underscore. Convention to use PascalCase for most types, camelCase for method parameters and local variables.

Comments - DAMP.  Descriptive And Meaningful Names. Favour readability over brevity.

 DRY Don't Repeat Yourself

### Value Type vs Reference Type

Value types are stored in the stack

Reference types stored in the heap. Arrays are reference types. Array cells point at the location of the variable of that cell in the stack. Classes, interfaces, objects, strings.

### Data Types

Every type has defined: size, allowed operations/methods

## Strongly vs Weakly Typed

**Strongly typed** means, the variable will not be automatically converted from one type to another after compilation. **Weakly typed** is the opposite: Perl can use a string like `"123"` in a numeric context, by automatically converting it into the int `123`. A strongly typed language like python will not do this. 

C# is strongly typed, *most of the time*. There is a keyword dynamic which allows you to break type safety.

### Strongly Typed

**Static:** Type is known at compile time, space occupied is known, which operations are allowed is known. Allows compile-time type checking.

**Type Safe:** Prevents values of one type being substituted for another incompatible type.

**Memory Safe: **Prevents access to invalid memory. Though C# can have unsafe blocks

## Primitive Types

Integers, floats, booleans, etc.

### Integers Types

**System.Numerics.BigInteger** is a structure that can be used to represent a signed integer of any size

Refresher on how binary works.

Hexadecimal. Base 16: 0,1,2,3,4,5,6,7,8,9,A,B,C,D,E,F. A = 10, B = 11, &c. Often put a 'h' in the representation to avoid confusion

Converting decimal into Hexadecimal. Divide by 16, take the remainder, divide it by 16.

**Signed bytes:** One bit is devoted to sign. There is some weirdness with how binary representations flip between 



```c#
        int a = Int32.MaxValue;
        int b = a + 1;
```
This rolls over giving you

a = 2147483647
b =-2147483648

The checked keyword will throw an exception for us if there is an integer over or underflow. We can also set this as a property in the project in VS so we don't have to put everything in checked blocks.

### Floating Point Types

Floating points types have MinValue and MaxValue constants.

Floats and double also have associated NaN, NegativeInfinity and PositiveInfinity constants.

Some fractions cannot be represented exactly, obviously due their irrationality.

### Character types

Size: 2 bytes Unicode UTF-16

In C# always use single quotes for char literals. Double quotes for strings.

Each character has a ushort integral equivalent. Each character has an integer to represent it. The ASCII table is 7 bit, fits nicely into UTF-8 [image/link here]

## Casting

### Safely casting

Implict casting char > int > long > float > double

Explicit casing double > float > long > int > char

### Between Numerical Types

C# VS will not implicitly cast a double to a float, since there may be data loss. You must explicitly cast it.

Casting from an unsigned to a signed integer type can be messy. Probably best not to do, since  at the halfway point the binary representations change.

### Between Char & Integer Types

The cast returns the unicode value of the char if converting char to integer, or vice versa, giving the char associated with unicode value given by the int.

You can also use System.Convert.ToChar() to convert an integer to a character.

### Boolean Types

Booleans are internally represented as a struct.

You need to use methods of the convert class to convert bools.

### Rounding Floats & Decimals

Math.Round(decimal, number of decimal places)

```c#
double pi = 3.141592;
pi = Math.Round(pi, 3);
```

Returns 3.142

## The var Keyword

The C# keyword var can be used when declaring a variable, instead of a specific type. You can only do this if the variable type can be determined at compile time. This *does not* break type safety, the type is still fixed when assigned during compilation.







