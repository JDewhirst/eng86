# C# Operators

BODMAS - obviously

## C# Operators by Precedence

* Primary: x++, x--, a[], x.y, new type-of
* unary: +x, -x, !x, ~x ,++x ,(T)x
* multiplicative: x*y, x/y, x%y
* additive: x+y, x-y
* bitwise shift: x<<y, x>>y
* relation and type-testing: x<y, x<=y, is as
* equality: ==, !=
* logical: x&y, x^y, x|y, x&&y, x||y
* conditional: x ? y : z
* assignment: x = y,

## Increment & Decrement Operators

x++,  increments x *after* using x in the expression

++x, increments x *before* using x in the expression

## Other Unary

-x - negative x

+x - positive x

!x - logical negation

## Arithmetic

The division operator.  int/int will return an int. If mixing ints and floats it will return a float

## Relational Operators

Operands can be any integral or floating-point type. The result is a boolean (true or false).

== equal to, != not equal to, < less than, > greater than, <=  less than or equal to, >= greater than or equal to.

If either operand is NaN the result is false (for all except !=)

## Logical Operators

Binary logical operators can have to boolean operands, and return a boolean result.

x && y returns false if x is false without checking y

x || y returns true if x is true without checking y

These are 'shortcircuiting'

## Bitwise Operators

The logical operators also work as bitwise operators on integers.

5&1
0001
0101
0001 = 1

5|1
0001
0101
0101 = 1

5^1 : XOR 
0001
0101
0100 = 4

### Bitshifts

In C# bitwise operators are only defined for int, uint
x << y left shift. Equivalent to $$x*2^y$$
x >> y right shift. Equivalent to $$x/2^y$$
0100 << 1 = 1000 = 8
0100 >> 1 = 0010 = 2

## Assignment Operators

x=y ; //evaluate expression y and story the result in x