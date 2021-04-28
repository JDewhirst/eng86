# Inheritance

Objectives: Implementation in C#, Member visibility, Object class, virtual and override keywords, abstract method and classes, sealed classes, exercise create an Airplane class.

Parent class encapsulates common data and functionality. Subclass add new func and/or data to deal with sepcialisms. Children extend parents.

## Exercise - Hunter type to extend Person type

```c#
public class Hunter : Person
{
    private string _camera;

    public Hunter(string fName, string lName, string camera = "") : base(fName, lName)
    {
        _camera = camera;
    }

    public string Shoot()
    {
        return $"{GetFullName()} has taken a photo with their {_camera}." ;
    }
}
```

When the derived class constructor is called it immediately calls the base class constructor. Once the base class constructor returns, the body of the derived class runs. The derived class can access public fields, properties and methods of its base class.

The protected keyword can make things visible only to a class and its subclasses

A class cannot access any members of its derived classes. Higher level code has no knowledge of lower level code.

## Abstract Classes

A class that can only be derived from. For example there might be a mammal class, but there is no sensible implementation of an object which is only a mammal and not some other child class.

Abstract classes can have concrete methods as well as abstract methods.

Non-abstract classes cannot have abstract methods.

## Sealed 

Sealed method - prevents a method that ovverrides a base class virtual or abstract method from being overridden again in a derived class. Can also be applied to a whole class.