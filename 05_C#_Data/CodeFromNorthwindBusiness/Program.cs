using CodeFromNorthwind;
using System;
using System.Linq;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace CodeFromNorthwindBusiness
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var db = new NorthwindContext())
            {
                //// Lesson 1
                {

                    //foreach (var c in db.Customers)
                    //{
                    //    Console.WriteLine(c);
                    //}

                    //var newCustomer = new Customer
                    //{ 
                    //    CustomerId = "FRENC"
                    //    , ContactName = "Cathy French"
                    //    , CompanyName = "Sparta Global"
                    //};

                    //db.Customers.Add(newCustomer);
                    //db.SaveChanges();

                    ////// UPDATE
                    //// Select a customer
                    //var selectedCustomer = db.Customers.Where(c => c.CustomerId == "FRENC").FirstOrDefault();

                    //// Change city of selected customer
                    //selectedCustomer.City = "Ottawa";
                    //// Save changes to db
                    //db.SaveChanges();

                    ////// DELETE
                    //db.Customers.Remove(selectedCustomer);
                    //db.SaveChanges();
                }

                //// Lesson 2
                {
                    //// Deferred query
                    //var query1 =
                    //     from c in db.Customers
                    //     where c.City == "London"
                    //     select c;

                    //// forcing query execution
                    //var queryList = query1.ToList();

                    //foreach (var item in query1)
                    //{
                    //    Console.WriteLine(item);
                    //}

                    //// WHERE clause

                    //var londonBerlinQuery =
                    //    from customer in db.Customers
                    //    where customer.City == "London" || customer.City == "Berlin"
                    //    select customer;

                    //foreach (var item in londonBerlinQuery)
                    //{
                    //    Console.WriteLine(item);
                    //}

                    //// SELECT clause
                    //var londonBerlinQuery =
                    //    from customer in db.Customers
                    //    where customer.City == "London" || customer.City == "Berlin"
                    //    select new { CustomerName = customer.CompanyName, Country = customer.Country };

                    //foreach (var item in londonBerlinQuery)
                    //{
                    //    Console.WriteLine($"{item.CustomerName} is from {item.Country}");
                    //}

                    ////GROUP BY clause

                    //var groupProductsByUnitInStockQuery =
                    //    from p in db.Products
                    //    group p by p.SupplierId into newGroup
                    //    orderby newGroup.Sum(c => c.UnitsInStock) descending
                    //    select new
                    //    {
                    //        SupplierID = newGroup.Key,
                    //        UnitsOnStock = newGroup.Sum(c => c.UnitsInStock)
                    //    };

                    //foreach (var item in groupProductsByUnitInStockQuery)
                    //{
                    //    Console.WriteLine(item);
                    //}

                    //// ORDER BY
                    //var orderProductsByUnitPrice =
                    //    from p in db.Products
                    //    orderby p.UnitPrice descending
                    //    select p;

                    //orderProductsByUnitPrice.ToList().ForEach(p => Console.WriteLine($"{p.ProductId} - {p.UnitPrice}"));

                    ////// CRUD Operations

                    //// CREATE
                    //var newCustomer = new Customer
                    //{
                    //    CustomerId = "HARDI"
                    //    ,
                    //    ContactName = "Callum Harding"
                    //    ,
                    //    CompanyName = "Sparta Global"
                    //};

                    //db.Customers.Add(newCustomer);
                    //db.SaveChanges();

                    //// UPDATE
                    //var selectedCustomer =
                    //    from c in db.Customers
                    //    where c.CustomerId == "HARDI"
                    //    select c;

                    //foreach (var item in selectedCustomer)
                    //{
                    //    item.City = "Paris";
                    //}
                    //db.SaveChanges();

                    //// REMOVE
                    //var selectedCustomer =
                    //    from c in db.Customers
                    //    where c.CustomerId == "HARDI"
                    //    select c;

                    //foreach (var item in selectedCustomer)
                    //{
                    //    db.Customers.Remove(item);
                    //}
                    //db.SaveChanges();

                    // method syntax way
                    //db.Remove((from c in db.Customers
                    //           where c.CustomerId == "HARDI"
                    //           select c).FirstOrDefault());
                    //db.SaveChanges()
                }

                ///// Day 2
                {

                    ///
                    //var nish = db.Customers.Find("MANDA");
                    //var newOrder = new Order { OrderDate = DateTime.Now, ShipCountry = "Egypt", Customer = nish };
                    //db.Orders.Add(newOrder);
                    //db.SaveChanges();

                    //var nishQuery = db.Orders.Include(o => o.Customer).Where(c => c.CustomerId == "MANDA");
                    //nishQuery.ToList().ForEach(n => Console.WriteLine($"{n.Customer.ContactName} made this order: {n.OrderId}"));

                    //// Method syntax
                    //var nums = new List<int> { 3, 7, 1, 2, 8, 3, 0, 4, 5 };
                    //var evenNums = nums.Count(isEven);
                    //var evenCount = nums.Count(delegate (int n) { return n % 2 == 0; });
                    //Console.WriteLine(evenNums);

                    // those ^ are equivalent to this >
                    //int countEven = 0;
                    //foreach (var x in nums)
                    //{
                    //    if (isEven(x)) countEven++;
                    //}

                    //List<Person> people = new List<Person>
                    //{
                    //    new Person { Name = "Hossain", Age = 40}
                    //    , new Person { Name = "Michael", Age = 55}
                    //    , new Person { Name = "Nish", Age = 20}
                    //};

                    //int numYounglings = people.Count(isYoung);
                    //Console.WriteLine(numYounglings);

                    //int numYoungTwo = people.Count(n => n.Age < 30);
                    //Console.WriteLine(numYoungTwo);

                    //var totalAge = people.Sum(x => x.Age);
                    //Console.WriteLine(totalAge);

                    //var oldPeopleTotalAge = people.Sum(x => x.Age > 30 ? x.Age : 0);
                    //Console.WriteLine(oldPeopleTotalAge);

                    // where clause in method syntax
                    //var custQuery = db.Customers.Where(c => c.City == "Berlin");
                    //foreach (var item in custQuery)
                    //{
                    //    Console.WriteLine(item);
                    //}

                    // Group by
                    //var orderProductsByUnitsInStockQuery =
                    //    db.Products.GroupBy(p => p.SupplierId)
                    //    .Select(newGroup => new { 
                    //        SupplierID = newGroup.Key,
                    //        UnitsInStock = newGroup.Sum(c => c.UnitsInStock)
                    //    });
                    //foreach (var item in orderProductsByUnitsInStockQuery)
                    //{
                    //    Console.WriteLine(item);
                    //}

                    // order by
                    //var customerOrderQuery = db.Products.OrderBy(p => p.QuantityPerUnit)
                    //    .ThenByDescending(c => c.ReorderLevel)
                    //    .Select(x => new { name = x.ProductName, QPU = x.QuantityPerUnit, ReorderLevel = x.ReorderLevel });
                    //foreach (var item in customerOrderQuery)
                    //{
                    //    Console.WriteLine($"{item}");
                    //}

                    //// CRUD Operations
                    //Create
                    //var newCustLiam = new Customer
                    //{
                    //    CustomerId = "NAGLE",
                    //    ContactName = "Liam Nagle",
                    //    City = "Leicester",
                    //    CompanyName = "Sparta Global"
                    //};

                    //db.Customers.Add(newCustLiam);
                    //db.SaveChanges();

                    //Read
                    //var liam1 = db.Customers.Find("NAGLE");
                    //var liam2 = db.Customers.Where(c => c.CustomerId == "NAGLE");
                    //var liam3 = liam2.FirstOrDefault();
                    ////liam2.ToList().ForEach(c => Console.WriteLine(c));
                    //var liam4 = db.Customers.Where(c => c.CustomerId == "NAGLE").Select(c => c).FirstOrDefault();

                    //Console.WriteLine(liam1);
                    //liam2.ToList().ForEach(c => Console.WriteLine(c));
                    //Console.WriteLine(liam3);
                    //Console.WriteLine(liam4);

                    // Update
                    //db.Customers.Find("NAGLE").City = "Birmingham";
                    //db.Customers.Where(c => c.CustomerId == "NAGLE").FirstOrDefault().City = "Birmingham";
                    //db.Customers.Where(c => c.CustomerId == "NAGLE")
                    //    .ToList().ForEach(c => c.City = "Birmingham");

                    //db.SaveChanges();

                    // Delete
                    //var customerToDelete1 = db.Customers.Find("NAGLE");
                    //var customerToDelete2 = db.Customers.Where(c => c.CustomerId == "NAGLE");
                    //db.Customers.RemoveRange(customerToDelete1);

                    //db.Customers.Remove(db.Customers.Find("NAGLE"));
                    //db.SaveChanges();

                    //// Loading & Joining Tables
                    // Include & ThenInclude keywords
                    var orderQueryWithCust =
                        db.Orders.Include(o => o.Customer).Include(o => o.OrderDetails).ThenInclude(od => od.Product);

                    foreach (var o in orderQueryWithCust)
                    {
                        Console.WriteLine($"Order {o.OrderId} was made by {o.Customer.CompanyName}");
                        foreach (var od in o.OrderDetails)
                        {
                            Console.WriteLine($"            Product: {od.Product.ProductName} - Quantity {od.Quantity}");
                        }
                    }

                }
            }

            static bool isYoung(Person P)
            {
                return P.Age < 30;
            }

            static bool isEven(int x)
            {
                return x % 2 == 0;
            }
        }
    }

    public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
    }
}
