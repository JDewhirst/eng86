# Using LINQ

Language Integrated Query. C# way of doing queries, same syntax for SQL and ...

Three steps

* Specify data source
* Define the query expression
* Execute the query

Can define and execute in one line.

## Query Syntax and Method Syntax

Query syntax looks like backwards SQL, SQL in execution order rather than SQL's syntax order.

Method syntax reads left to right in SQL's syntax order.

Both generate the same query of type IEnumerable<T>. Query syntax can be easier to read. Some functionality can only be done using only method syntax, Sum, Max, Min

## Deferred Execution

When you create a query it is not immediately executed. The query is executed when GetEnumerator() is (implicitly) called such as in a foreach loop.

You can also force the query to be immediately executed by: Calling ToList() or ToArray() on the query object, calling an aggregation function.

## Query Syntax

### LINQ to SQL

Most of LINQ, such as selection, is generic: can be used with any data source. Some is specific to the source type.

Anonymous types: contain public read only fields(?)

```c#
var x = new { CustomerName = customer.CompanyName, Country = customer.Country }
```

used in a query

```c#
var londonBerlinQuery =
                        from customer in db.Customers
                        where customer.City == "London" || customer.City == "Berlin"
                        select new { CustomerName = customer.CompanyName, Country = customer.Country };

                    foreach (var item in londonBerlinQuery)
                    {
                        Console.WriteLine($"{item.CustomerName} is from {item.Country}");
                    }
```

#### GROUP BY clause

```c#
var groupProductsByUnitInStockQuery =
    from p in db.Products
    group p by p.SupplierId into newGroup
    select new 
{
    SupplierID = newGroup.Key,
    UnitsOnStock = newGroup.Sum(c => c.UnitsInStock)
};

foreach (var item in groupProductsByUnitInStockQuery)
{
    Console.WriteLine(item);
}
```

### ORDER BY clause

```c#
var orderProductsByUnitPrice =
    from p in db.Products
    orderby p.UnitPrice descending
    select p;

orderProductsByUnitPrice.ToList().ForEach(p => Console.WriteLine($"{p.ProductId} - {p.UnitPrice}"));

```

### CRUD OPERATIONS

