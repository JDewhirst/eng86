# Selection

## Conditional Statements

If this statement is true, otherwise do something else.

if - else if - else

```c#
var number = 15;
var result = "";

if (number % 5 ==0)
{
	result += "Nish";
} 
else if (number % 5 == 0)
{
	result += "Nash";
}

Console.WriteLine("Result");
```

Since the first condition has been met, the else if block is not executed.

## Switch Statements

All conditions are compared against *one* variable, not multiple variables or a range of values. Must specify all the cases you want and include a break statement at the end of each case.

```c#
switch(expression)
{
	case x:
		//code
		break;
	case y:
		// code
		break;
    default:
        // code
        break;

}
```



If no code is in a case, then it runs the code in the next case

## Switch or If ?

Switch: Can be more readable for discreet, integral values. More efficient, execution jumps straight to the corresponding case.

If: better for ranges, none-integral comparisons, compound conditions.

In release mode If and Switch statements produce different code, in debug mode they're the same.

## Conditional Operators

if(condition ) ? do this if true : do this if false.

