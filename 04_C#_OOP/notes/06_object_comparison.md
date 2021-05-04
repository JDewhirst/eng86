# Comparing Objects

```c#
var bob1 = new Person("Bob", "Builder");
var bob2 = bob1;
var areSame = bob1.Equals(bob2);
```

areSame is equal. bob2 refers to bob1, same value, same memory address etc.

```c#
var bob1 = new Person("Bob", "Builder");
var bob2 = bob1;
var bob3 = new Person("Bob", "Builder");
var areSame = bob1.Equals(bob3);
```

areSame is false. bob3 is in a different location.

## Hash Codes, What Are They ?

If you override the `Equals()` you should also override the `GetHashCode()` 

Further reading. IEquatable, Icomparable interfaces. List<T> Sort() method.

