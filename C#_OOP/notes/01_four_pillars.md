# The Four Pillars Of OOP

Abstraction, Encapsulation, Polymorphism, Inheritance.

OOP programming paradigm based on the concept of objects. Objects can contain data in the form of attributes or properties. And actions in the form of functions are methods. Contrast to procedural or functional programming.

## Abstraction

Only exposing the relevant information, features etc. Helps to manage complexity. Think of the problem in terms of things that can interact with each other. We're not interested in the details of how each thing works. You only need to know what it does, and how other things interact with it.

## Encapsulation

How can we represent a thing ? Abstraction is the concept, encapsulation is a mechanism for achieving it.

When encapsulating think; what information does it need to hold ? what methods does it need for other things to interact with it.

Black box: Only expose the interface (public methods) not what's inside, don't know how it works internally. Information hiding - we don't know how the data is stored.

Mechanism's; class (blueprint), object (concrete instance)

### Safari Game Example

How can we encapsulate a lion ? Lion has it's own class, or is an instance of Predator or some other thing. Its health would be public (it can be injured by other objects). It's speed might not be, it's hunger probably wouldn't be. 

Single responsibility. A class should only responsible for one thing. A hunter class should not also be responsible for weapons.

## Inheritance

Avoids writing the same code to describe similar things. Parent class encapsulates the common data and functionality. Sub classes add new functionality and/or data to deal with specialisms. Class B extends Class A.

### Using Inheritance to model the game world.

Vehicles -> Motorcycle, Bicycle, Jeep

Person -> Guide, Tourist, Poacher

### Guidelines

Base classes should be closed to change but open to extension. Don't go wild, avoid deep levels of inheritance. Make use of abstract classes and interfaces.

## Polymorphism

"Many forms", a way for thing to flexibly interact. Same interface, different behaviour. Ibex, Fish, Eagle, Jeep all implement the Moveable interface. Can call same method on all Moveable objects, and they have different response depending on their class.

Polymorphism allows:

* Customised behaviour, same interface
  * Move methods
* Close to modification, open to extension
* Single Responsibility
* High cohesion, low coupling
  * Separate a game object from the way it's rendered
  * Can change each independently

