using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace CSharpWithSQL
{
    class Program
    {
        static void Main(string[] args)
        {
            var customers = new List<Customer>();
            using (var connection = new SqlConnection(@"Data Source=(localdb)\ProjectsV13;Initial Catalog=Northwind;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False"))
            {
                connection.Open();
                Console.WriteLine(connection.State);

                //using (var command = new SqlCommand("SELECT * FROM CUSTOMERS", connection))
                //{
                //    SqlDataReader sqlReader = command.ExecuteReader();
                //    while (sqlReader.Read())
                //    {
                //        // Creating variables for a customer
                //        var customerID = sqlReader["CustomerID"].ToString();
                //        var contactName = sqlReader["ContactName"].ToString();
                //        var companyName = sqlReader["CompanyName"].ToString();
                //        var city = sqlReader["City"].ToString();
                //        var contactTitle = sqlReader["ContactTitle"].ToString();

                //        // new customer object
                //        var customer = new Customer
                //        {
                //            ContactTitle = contactTitle
                //            ,CustomerID = customerID
                //            ,ContactName = contactName
                //            ,City = city
                //            ,CompanyName = companyName
                //        };
                //        customers.Add(customer);
                //    }

                //    customers.ForEach(c => Console.WriteLine($"Customer {c.GetFullName()} has ID {c.CustomerID} and lives in {c.City}"));
                //}

                //var newCustomer = new Customer
                //{
                //    CustomerID = "MANDA",
                //    ContactName = "Nish Mandal",
                //    City = "Birmingham",
                //    CompanyName = "Sparta Global"
                //};

                //string sqlString = $"INSERT INTO CUSTOMERS(CustomerID, ContactName, CompanyName, City) VALUES ('{newCustomer.CustomerID}', '{newCustomer.ContactName}', '{newCustomer.CompanyName}', '{newCustomer.City}')";

                //using (var command2 = new SqlCommand(sqlString, connection))
                //{
                //    int affect = command2.ExecuteNonQuery();
                //}

                //string sqlUpdateString = $"UPDATE CUSTOMERS SET City = 'London' WHERE CUSTOMERID = 'MANDA'";
                //using (var command3 = new SqlCommand(sqlUpdateString, connection))
                //{
                //    int affected = command3.ExecuteNonQuery();
                //}

                // Delete

                //string sqlDeleteString = $"DELETE FROM CUSTOMERS WHERE CustomerID = 'MANDA'";
                //using (var command4 = new SqlCommand(sqlDeleteString, connection))
                //{
                //    int affected = command4.ExecuteNonQuery();
                //}

                //using (var updateCustomerCommand = new SqlCommand("UpdateCustomers", connection))
                //{
                //    updateCustomerCommand.CommandType = System.Data.CommandType.StoredProcedure;
                //    // add parameters
                //    updateCustomerCommand.Parameters.AddWithValue("ID", "MANDA");

                //    updateCustomerCommand.Parameters.AddWithValue("NewName", "Nish Kumar");
                //    int affected = updateCustomerCommand.ExecuteNonQuery();
                //}
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
}
