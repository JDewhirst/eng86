using CodeFromNorthwind;
using System;
using System.Linq;
using System.Collections.Generic;

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
            }
        }
    }
}
