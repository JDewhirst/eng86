# Exceptions

## Types of Errors

**Syntax errors**, caught by compiler

**Runtime errors**, something that occurs while running that can't be dealt with; input data in the wrong format, file cannot be opened, try to access an array address that doesn't exist

logic errors, wrong assumptions, wrong conditions used in selection or loops, incorrect calculations.

"An exception is an event, which occurs during the execution of a program, that disrupts the normal flow of the program's executions"

## Handling Exceptions

When an exception is thrown, the runtime system looks for an exception handler. It could be in the same method, in the method which called the method.

### Try Catch

```c#
try{ /code which may cause exception}
catch (Exception e)
{ // the catch block where the exceptions are handled
}
finally 
{// optional final block which always executes whether or not an exception occurred
}
```

Example

```c#
try
{
	_theBeatles[4] = "Brian"; // throws out of range exception
}
catch (Exception)
{
	Console.WriteLine("Sorry, you cannot join the Beatles");
}
```

## Exception Types

C# library exceptions are all subclasses of SystemException, which is a subclass of Exception.

* SystemException
  * Arithmetic Exception
    * DivideByZeroException
    * &c
    * &c
  * Argument Exception
    * &c
  * &c

Can access the data and ToString method of the exception, as well as a message. 

```c#
try
{
	_theBeatles[4] = "Brian"; // throws out of range exception
}
catch (Exception e)
{
	Console.WriteLine(e.Data);
    Console.WriteLine(e.ToString());
    Console.WriteLine(e.Message);
}
```

## Throwing Exceptions

If we catch an exception, it will not reach methods higher up the call stack unless we rethrow it.

Sometimes we can to catch the exception, do something and rethrow it.

## Turning Overflow Exceptions On/Off



## Testing that an exception is thrown

<img src="C:\Users\jackd\AppData\Roaming\Typora\typora-user-images\image-20210422121733956.png" alt="image-20210422121733956" style="zoom:50%;" />