# EF Core - Model First approach and migrations

We can either start with a database and create classes, or start with a model and generate a database from it.

## Entity Framework Migrations

`Add-Migration InitialCreate`

`Update-Database`

## EF Mapping conventions

A class named Customer will create the database table Customers.

The primary key of a class will be "Id" or "ClassNameId". It's autoincremented by default, one to many is the default.

If we don't want to map a certain attribute or property there is a keyword `NotMapped` which we can apply