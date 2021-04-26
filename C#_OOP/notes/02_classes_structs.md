# Classes & Structures

UML class diagrams. 

Introduction to classes: fields, methods, properties, constructors, overloading, object initialisers

VS Class Designer

Structs and their similarities/differences to classes

In C# the unit of encapsulation is the class or struct. Exposing; public methods and properties. Hide implementation details; private fields and methods, hidden implementation of Properties and Methods.

## UML Class diagrams

A way of representing classes and relationships between them, can be shown at different levels of detail. Access modifiers represented with + meaning public, - meaning private and ~ meaning protected.

<img src="\images\uml_class_diagrams.png" alt="image-20210426143910413" style="zoom:50%;" />

## Encapsulating

C# uses Properties to give public or protected access to data. IN other languages like Java, you would write getter and setter methods to expose private fields

This `public int Age { Get; Set;}` is an auto property. 

<img src="\images\visibility.png" alt="image-20210426145557200" style="zoom:50%;" />

## Backing field

`public int Age {get; set; }`

Get retrieves the value of a hidden backing field.

Set sets it to the value provided.

This can also be written explicitly

_age is a private backing field._

## Properties with Functionality

A property does not need to correspond directly to a backing field. We coul dimplement GetFullName() as a property rather than a method.

```c#
public string (FullName)
{
    get {return stuff }
```

## `init` key word is brand new.

Naming conventions Methods Pascal, variables camel, constants pascal, 

## Constructors

When an object is created with the new keyword, a special method called the constructor is called.

Space is found on the heap for the new object, and a reference to it is assigned to the variable

The constructor name must be exactly the same as the class

constructors are the only methods which do not have a return type.

If you do not write a constructor the compiler writes a default one for you, has no args and does not init fields, but it does create space on for the object and assigns a reference to it.

If you do write a constructor with params, you don't get a default one, if you still need a no arg constructor, must provide one yourself.

### Overloading Constructors

Same as overloading methods pretty much.

### Object initialisers

A way to initialise without invoking a constructor. 

` var hamse = new Person("Hamse", "Ahmed") { Age = 21 };`

`var shopList = new ShoppingList { Bread = 2, Milk = 10, Potato = 1 };`

Initialise as many or as few properties as you like.

## Structs

Similar to a class in that they are both data structures that encapsulate data and behaviour. They can both have member fiels, constructors, properties and methods. But you aren't allowed to define your own parameterless constructor. They can both be instantiated with keyword new, but structs can also be declared without new.

Structs are val types

Structs cannot inherit from another struct or class, and cannot be inherited from.

Supposed to only represent a single value. Consider the DateTime struct, which is a Struct.

If you provide a constructor is must initialise all the member variables(I think)

Struct instances are passed to methods by value

Class instances are passed to methods by reference

## Testing Classes & Structs

Same as for a static class, we just need to instantiate an instance of the class.