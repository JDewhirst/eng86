# Loading & Joining Tables

OO vs Relational Approach

BY default a LINQ query will only load the data asked for. If you load an object representing an entry in the Orders table, associated objects (such as Customer) are not loaded.

The created Order object will have the CustomerId (foreign key) of the associated Customer, but the Customer property will be null

To be able to access the associated Customer object, use the LINQ method Include