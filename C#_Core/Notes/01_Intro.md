# Programming Language's Generally

Differences and similarities between programming languages

Introduce .NET

C# is Object Oriented. Everything is packaged into classes (or interfaces) and only certain methods and properties of those classes are available to access outside of the class.

The biggest differences between programming languages occur at compile time.

For example in C# the type of a variable must be declared at compile time, whereas in Python that is not necessary.

We must also declare the size of arrays at compile time in C#. In javascript you may add to an array beyond it's initial size.

# C# Information

Simple, object oriented, and type-safe programming language. It's strongly typed.

Object oriented languages allow for each of the pillars of OOP.

## Timeline

1972 - C

1979 - "C with classes"

1985 - C++

1995 - Java 1.0 - Has memory management

2002 - C# 1.0 with .NET framework 1.0 released - similar to Java

2007 - C# 3.0 - new features including LINQ (basically allow queries like SQL)

2012- C# 5.0 - asynchronous programming support

Nov 2020 - C# 9.0 and .NET 5 released

Since C#9 and .NET 5 are so new, when looking up information bear this in mind, you're going to find a lot of older stuff.

## .NET

.NET programs run in a virtual machine

C#, Visual Basic Code, F# Code, and Managed C++

all use the .NET framework class library

* and compile into a common intermediate language

* and run on a common language runtime

.NET Framework is Windows only. .NET core is cross-platform

.NET Core is also opensource

.NET 5 is superseding all of this and is cross-platform.

Just In Time compiler - reuses code for methods that've already been compiled 

### .NET Development frameworks

Five things in the slides.

## Cases

Classes and methods typically in pascal case : PascalCase

C# Variables are written in camelCase : string firstName

_camelCase : for private member variables

snake_case

kebab-case 

## Main

The main method is the entry point. There can only be one entry point in any C# program, as you might expect. If you have more than one main in your code you must specify which one is being used when compiling.

Cleaning a solution deletes all compiled files and so on. 

## Nish implores everyone to debug a bunch instead of bugging him later

You can launch powershell through VS

Creating console application from visual studio powershell.

```powershell
dotnet new console
```







