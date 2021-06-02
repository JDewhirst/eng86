# Refactoring

Improving the structure of existing code; not fixing bugs, or changing or extending functionality.

Do it to

* Make things easier to read and understand
* Eliminate duplicated or redundant code
* Easier to extend or maintain
* Without refactoring the design of the program will decay
* As people modify code the code loses it's structure; changes to realize short-term goals, changes made without a full comprehension of the design of the code

## Before refactoring

* Cover the code with unit tests
* Make sure they all pass
* Commit your code: add a label or make a new branch
* Now you can confidently change your code knowing that you can go back to a previous version

## When to refactor

Rule of 3 (Don Roberts)

* The first time you do something, you just do it.
* The second time you do something, you wince at the duplication, but you do the duplicate thing anyway
* The third time you do something similar, you refactor.

Indicators to refactor

* When a program is hard to read
* When duplication exists
* Before adding new functionality - refactor the existing code first
* When adding new behaviour is not possible without making major changes to the existing code
* On code reviews
* When the code smells

##  When not to Refactor

* Close to a deadline
* Need a complete rewrite; sometimes it's better to burn it down and start from scratch

# Code Smells

Refers to recognisable bad code traits

## Inappropriate Names

* Method names should say what the method does
* Field, property, parameter, and variable names should be meaningful
* So should class names
* Your code will be easier to understand and require less commenting
* Comments need to be maintained along with the code otherwise they are useless and misleading

## Dead code

## Duplicate code

The same code in different places. find a way to unify them usually by extracting methods. if you have several classes with similar code, can you extract a superclass ? This is the most important smell, apparently. Duplicate code is easy to write but hard to maintain

## Long Methods

If the method is doing more than one thing split it up. Use meaningful method names. Less need for comments if method names are self-explanatory.

## Data Clumps

When the same group of members keep appearing together. Make a class to encapsulate them. For example _houseNo, _street, _town. Make an address class.

## Large Classes

When a class does too much it violates the Single Responsibility Principle. Each class should have only one responsibility, which is entirely encapsulated within the class. Should it be split into two associated classes ?

## Long Method Parameter Lists

Long parameter lists are an indication of bloat. They're hard to read and understand and it's easy to call them with the parameters in the wrong order ? Is it possible to pass an object instead ? For example an Address object instead of number, street, city, postcode. Encapsulate it, could the data be held as an object attribute (field) rather than passed to the method, particularly relevant to private methods. For constructors can you use Object Initial rath than a long parameter list ?

## Feature Envy

When one class is calling another excessively and passes lots of parameters or uses lots of returned data.

This is a sign the functionality might belong to the other class. Where should the functionality to create and return a string representing an address go ? 

Extract the method and move it to the other class.

## Repeated switch or if/else statements

If you have the same one more than once, consider using polymorphism instead. Should the current class be part of a class hierarchy ?