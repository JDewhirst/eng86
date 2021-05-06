# Lambda Expressions

Review LINQ Query and Method syntax. Look at structure of L expressions. Look at alternatives to L expressions; method as parameter, anon methods. Express some LINQ q in method syntax with lambda syntax.

Lambda expressions are inline anonymous functions. `given this => return this`

A lambda expression is a method which

* has no name
* is declared at place of use
* can't be reused anywhere else
* the types of the parameters and return values are inferred from the context

## Anonymous Methods

A lambda expression is an evolution of anonymous methods, which people don't really use anymore. It's used there and then in a method that takes a method as a parameter, using the delegate keyword.

Statement lambdas `(input parameters) => { sequence of methods}`

## More CRUD operations & SQL queries using method syntax

Select statement in method syntax with where clause.

```c#
var custQuery = db.Customers.Where(c => c.City == "Berlin");
foreach (var item in custQuery)
{
    Console.WriteLine(item);
}
```

group by

```c#
var orderProductsByUnitsInStockQuery =
    db.Products.GroupBy(p => p.SupplierId)
    .Select(newGroup => new { 
        SupplierID = newGroup.Key,
        UnitsInStock = newGroup.Sum(c => c.UnitsInStock)
    });
foreach (var item in orderProductsByUnitsInStockQuery)
{
    Console.WriteLine(item);
}
```

order by

```c#
var customerOrderQuery = db.Products.OrderBy(p => p.QuantityPerUnit)
    .ThenByDescending(c => c.ReorderLevel);
foreach (var item in customerOrderQuery)
{
    Console.WriteLine($"{item.ProductName} || {item.QuantityPerUnit} || {item.ReorderLevel}");
}
```

or

```c#
var customerOrderQuery = db.Products.OrderBy(p => p.QuantityPerUnit)
    .ThenByDescending(c => c.ReorderLevel)
    .Select(x => new { name = x.ProductName, QPU = x.QuantityPerUnit, ReorderLevel = x.ReorderLevel });
foreach (var item in customerOrderQuery)
{
    Console.WriteLine($"{item}");
}
```

Create

```c#
var newCustLiam = new Customer
{
    CustomerId = "NAGLE",
    ContactName = "Liam Nagle",
    City = "Leicester",
    CompanyName = "Sparta Global"
};

db.Customers.Add(newCustLiam);
db.SaveChanges();
```

Read

```c#
var liam1 = db.Customers.Find("NAGLE");
var liam2 = db.Customers.Where(c => c.CustomerId == "NAGLE");
var liam3 = liam2.FirstOrDefault();
//liam2.ToList().ForEach(c => Console.WriteLine(c));
var liam4 = db.Customers.Where(c => c.CustomerId == "NAGLE").Select(c => c).FirstOrDefault();

Console.WriteLine(liam1);
liam2.ToList().ForEach(c => Console.WriteLine(c));
Console.WriteLine(liam3);
Console.WriteLine(liam4);
```

Update

```c#
db.Customers.Find("NAGLE").City = "Birmingham";
db.Customers.Where(c => c.CustomerId == "NAGLE").FirstOrDefault().City = "Birmingham";
db.Customers.Where(c => c.CustomerId == "NAGLE")
    .ToList().ForEach(c => c.City = "Birmingam");

db.SaveChanges()
    
// or
db.Customers.Remove(db.Customers.Find("NAGLE"));
db.SaveChanges();
```

