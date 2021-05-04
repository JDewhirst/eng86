# Introduction

Connecting Visual Studio to a SQL server database

'Using' statement

Implementing CRUD operations in a C# program

Defining and using stored procedures

Classes correspond to tables, properties correspond to columns.

## Reading data from a table

```c#
static void Main(string[] args)
{
    var customers = new List<Customer>();
    using (var connection = new SqlConnection(@"Data Source=(localdb)\ProjectsV13;Initial Catalog=Northwind;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False"))
    {
        connection.Open();
        Console.WriteLine(connection.State);
        using (var command = new SqlCommand("SELECT * FROM CUSTOMERS", connection))
        {
            SqlDataReader sqlReader = command.ExecuteReader();
            while (sqlReader.Read())
            {
                // Creating variables for a customer
                var customerID = sqlReader["CustomerID"].ToString();
                var contactName = sqlReader["ContactName"].ToString();
                var companyName = sqlReader["CompanyName"].ToString();
                var city = sqlReader["City"].ToString();
                var contactTitle = sqlReader["ContactTitle"].ToString();

                // new customer object
                var customer = new Customer
                {
                    ContactTitle = contactTitle
                        ,CustomerID = customerID
                        ,ContactName = contactName
                        ,City = city
                        ,CompanyName = companyName
                };
                customers.Add(customer);
            }

            customers.ForEach(c => Console.WriteLine($"Customer {c.GetFullName()} has ID {c.CustomerID} and lives in {c.City}"));
        }
    }
}
}

public class Customer
{
    public string CustomerID { get; set; }
    public string CompanyName { get; set; }
    public string ContactName { get; set; }
    public string ContactTitle { get; set; }
    public string City { get; set; }

    public string GetFullName()
    {
        return $"{ContactTitle} {ContactName}";
    }
}
```

Christ that's a lot of effort to just read one table.

## CRUD

Create, Read, Update, Delete

## Using statement

The scope of connection is limited to the using block. When connection goes out of scope at the end of the block Dispose() is called. using can only be used with classes that implement IDisposable.

## Stored Procedures

???

# Entity Framework

.NET. Is an object-relational mapper that enables .NET devs to work with a database using .NET objects. 

The newest version, Entity Framework Core, runs in .NET Core.

This framework maps C# objects to relational database tables. Can use same c# code with different database engines which use different flavours of SQL. Uses LINQ for queries. Unlike SQL strings get full Visual Studio and debugging support.

## Approaches

Start with a database and create classes to match it. Or start with a data model and generate a database from it.

## Reverse Engineering

Creating a model from an existing database, also known as scaffolding

### Partial class

 At compile time all the partial classes of the same name and namespace are collated. This just let's us spread a class out among a bunch of files

## DbContext file -NorthwindContext.cs

NorthwindContext is a subclass of DbContext, used to query the database and group together changes that are saved to the database as a unit.

It has public propertis, `public virtual DbSet<customer> Customer {get; set;}` A DbSet contains all the entites of a given type that can be queried from the database.

Overrides two DbContext methods; OnConfiguring, OnReading

DbSet class represents an entity set that can be used for CRUD operations. The context class is derived from DbContext must include the DbSet type properties.

## VERY IMPORTANT

Remember `db.SaveChanges()`

```c#
using (var db = new NorthwindContext())
{
    //foreach (var c in db.Customers)
    //{
    //    Console.WriteLine(c);
    //}

    var newCustomer = new Customer
    { 
        CustomerId = "FRENC"
            , ContactName = "Cathy French"
            , CompanyName = "Sparta Global"
    };
    db.Customers.Add(newCustomer);
    db.SaveChanges();

}
```

