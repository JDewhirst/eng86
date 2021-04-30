# Polymorphism

ToString methods example.

Runtime polymorphism. Objects of derived classes are treated as objects of base classes when used as method parameters. At runtime it recognises that the derived class has overridden a method in the base class, and uses that.

Possible to cast a derived type to the types it's derived from. Hunter -> Person, not Person -> Hunter.

## Why Need Interfaces ?

Move() in a game. Most game objects cane move but they do it in different ways. However the only base class that Person, Hunter, Airplane and Vehicle have in common is the Object class. And it doesn't have a Move() method.

The solution is to define an Interface IMovable which contains a Move() method. Then modify the Person and Vehicle to implement it. Then derived classes can optionally override it.

```c#
namespace SafariPark.Interfaces
{
    interface IMoveable
    {
        string Move();
        string Move(int times);
    }
}
```

You can put a method body into interface methods (since 2019) which gives a default implementation.