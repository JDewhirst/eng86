# The Solid Principles

S - Single Responsibility principle.

O - Open/Closed

L - Liskov Substitution

I - Interface Segregation

D - Dependency Inversion 

## Single Responsibility Principle

>  "There should never be more than one reason for a class to change."

In other words, every class should have only one responsibility.

The class members should be cohesive. The fields and properties should hold information about the thing. The methods should manipulate or return this information. The class should have only one reason to change.

### Example: Our Hunter Class

Our first implementation of Hunter included a _camera field to represent a camera and a Shoot() method that returns a message about the camera. If we wanted to add more functionality to the camera (focus, set exposure, etc) we would have to change the *Hunter*, but why is the Hunter in charge of the camera anyway ? So move the camera functionality to a separate class.

Because everything is only responsible for itself it's then easier to reuse in other contexts. In the first implementation if I wanted to implement a camera on some other class, say a tourist, I would have to build that functionality again within the Tourist. If camera is its own class I do not need to do this.

## The Open–Closed Principle

> "Software entities ... should be open for extension, but closed for modification."

The weapon class is abstract and once defined should not be changed, it may already be used in lots of places. New functionality can be added via a derived class.

### Example

Exception classes and their subclasses in the System namespaces. However we can customise an instance of an existing Exception class by providing a message in its constructor. For more functionality we can subclass an existing exception.

## The Liskov Substitution principle

>  "Functions that use pointers or references to base classes must be able to use objects of derived classes without knowing it".

Subtypes must be substitutable for their base types without breaking the application.

Consider an interface.

```c#
public interface IMoveable
{
    string Move();
	string Move(int times);
}
```

We expect any class which implements it to implement these methods. But what if we to create a Hare class that implements IMoveable but refuses to move multiple times ? If we override `Move(times)` we're violating this principle, because we expect the method to have the same effect every time no matter where we call it, the purpose of that method is to move the thing. The answer is to split the interface, the next principle.

## The Interface Segregation principle

> "Many client-specific interfaces are better than one general-purpose interface."

Interface in this context means the public methods and Properties of a code module. Having small interfaces that describe only one type of behaviour helps enforce the Substitution principle.

```c#
IMoveable : ISingleMovable, IMultipleMoveable
```

[Announcing .NET Core 3.0 | .NET Blog (microsoft.com)](https://devblogs.microsoft.com/dotnet/announcing-net-core-3-0/)

## The Dependency Inversion principle

> "Depend upon abstractions, [not] concretions."

High level modules should not depend on low level modules. 

High level: Business rules, processes, guts of the application

Low level: Plumbing code, particularly for IO. Interaction with GUI, files, database, API calls.

### Safari Example

We originally defined that a Hunter has a Camera. We could have impl this rel by constructing a new Cam instance inside the Hunter constructor.

```c#
public Hunter(string fName, string lName, string cameraBrand) : bas(fName, lName)
{
    Shooter = new Camera(cameraBrand);
}
```

This violates SRP and DIP. It's hard to test Hunter and Camera separately. Also the dependency is hidden, you can construct a Hunter without realising you're also constructing a Camera

We instead made the method dependent on an abstraction, the IShootable interface, and passed an IShootable instance into the constructor. Now we have more flexibility. The dependency is apparent in the constructor. This is called Dependency Injection.

## SOLID relationships

Single Responsibility and Interface Segregation encourage small cohesive types. Which can then be extended sing Open/Closed. Interface Segregation aids Liskov Substitution and Dependency Inversion. Dependency Inversion enable Open/Closed.

# Design Patterns

More OO Principles and Techniques. GRASP (General Responsibility Assignment Software Patterns), Design Patterns. DRY, YAGNI (You Aint Gonna Need It), KISS. 

### PDD - Pain-Driven Development. 

Don't go wild trying to be SOLID all at once from the beginning. Use simple techniques until they start to cause pain, repeated code, inflexible design. *Then* refactor to solve the problem, refactor, safe to do if the existing code is covered by tests.