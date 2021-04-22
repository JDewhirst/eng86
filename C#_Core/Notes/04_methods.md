# Methods

Methods; Signature and body, parameters and return values. Static keyword. Method overloading. Returning values from a method with the out keyword. Tuples as return values. Optional parameters. Named parameters.

Unit tests; Adding a test project, the test environment, test setup, test parameters.

## Methods

Code blocks that only run when they're called. You can pass data, known as parameters, into a method. Methods are used to perform certain actions, also known as functions.

Methods are useful for reusable code, define it once and use it many times.

### Parts of a Method

Method signature and method body.

The method signature contains it's; visibility (access modifier), return type, name parameter.

The body is what is within the code block.

In C# all methods must be declared in a something something

### Parameters & Arguments

All optional parameters should come at the end of a method's arguments list.

If you have two methods DoThat(int x, string y = "Default") and DoThat(int x) which method end's up getting used if we call DoThat(10) ? It will use DoThat(int x). It will always call the method where the parameters match.

#### Named Parameters

When a method has a long parameter list, it's difficult to specify all the arguments in the correct order.

If you get the order wrong it will still compile, but obviously the output can be wrong. Named parameters get around this.

If using a mixture of named and unnamed parameters you must still get the order right.
Syntax OrderPizza(pineapple: false, anchovies: false);

### Ref keyword

Add(ref number); Passes in the memory address of number and actually changes it. As opposed to Add(number); which assigns number to some variable in the local scope of the Add method.

Things that are reference types, when you do pass them into a method it is always passing the reference. For example passing an array into a method and then working on it will change the values in the array in the global scope.

### Returning Multiple Things

#### Out keyword

Can designate one or more parameters to be the 'out' parameter. This is primarily used for returning multiple values

```c#
var result = DoAgain(10, out bool z);
```

This will assign result to whatever the body of the method says. It will also return a bool z. So we've been able to return more than one thing from the DoAgain() method.

#### Tuples

Mix different data types together, tuples are a value type. They are not structs, classes, arrays, etc.

```c#
var myTuple = ("Frazer", "Green", 22);
(string, string, int) myTuple2 = ("Michael", "Wilcock", 23);
(string fName, string lName, int age) myTuple3 = ("Hamse", "Ahmed", 21);
           Console.WriteLine(myTuple2.Item2);
Console.WriteLine(myTuple3.age);
```

Returning tuples from a method

```c#
var result = DoThatAgain(10, "Sparta Global");
Console.WriteLine(result);
Console.WriteLine(result.xsquared);
var (square, greaterThan10) = DoThatAgain(5, "Heya");
Console.WriteLine(greaterThan10);
Console.WriteLine(square);

// method
public static (int xsquared, bool y_got_10) DoThatAgain(int x, string y)
{
    Console.WriteLine(y);
    var z = (x > 10);
    return (x * x, z);
}
```



