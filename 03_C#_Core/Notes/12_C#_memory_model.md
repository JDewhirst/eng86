# C# Memory Model

Three levels of scope. Class scope, method scope, block scope.

## Stack

The stack is last in first out. Local variables are popped off the stack when they go out of scope.

The heap is a larger area of memory which holds the data belonging to reference types. When a new reference is created the system finds space for it on the heap.

## Heap

Unlike the stack the heap does not have size restrictions on variable size. Values in it are also accessible to [???], unlike the stack which is totally local.

## References to References

Most objects on the heap are of complex types containing value and reference members: string[] is an array of references to string objects

## Garbage Collector

Finds all the dead objects on the heap and deletes them.

Reference variable can go out of scope or be reassigned.

1. Identify objects that are no longer refenced
2. Frees this memory
3. Moves the live objects closer to each other to optimise space (Compaction)

## Pass by value, Pass by reference

The arguments in method calls are copied into the method's memory space as local parameters. If it's a reference the reference address is copied, if it is a value type the value is copied.

It's more efficient to copy a reference for reference types, since the address is generally *much* shorter than the actual data.

When providing a reference type as a method argument it *can* be changed by the method. 

When providing a value type as a method argument it *cannot* be changed by the method, unless the ref parameter keyword is used (this is not common practice.)