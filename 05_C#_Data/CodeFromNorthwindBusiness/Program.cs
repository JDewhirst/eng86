using CodeFromNorthwind;
using System;
using System.Linq;

namespace CodeFromNorthwindBusiness
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var db = new NorthwindContext())
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
        }
    }
}
