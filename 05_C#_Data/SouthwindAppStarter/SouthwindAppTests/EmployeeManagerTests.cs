using NUnit.Framework;
using SouthwindApp;
using SouthwindAppBusiness;
using System.Linq;

namespace SouthwindAppTests
{
    public class Tests
    {
        EmployeeManager _employeeManager;
        [SetUp]
        public void Setup()
        {
            _employeeManager = new EmployeeManager();
            // remove test entry in DB if present
            using (var db = new SouthwindContext())
            {
                var selectedEmployee =
                from e in db.Employees
                where e.EmployeeId == "MANDA"
                select e;

                db.Employees.RemoveRange(selectedEmployee);
                db.SaveChanges();
            }
        }
        [Test]
        public void WhenANewEmployeeIsAdded_TheNumberOfEmployeesIncreasesBy1()
        {
            using (var db = new SouthwindContext())
            {
                var numEmployees = db.Employees.Count();
                _employeeManager.CreateEmployee("MANDA", "Nish Mandal", "BRUM10", "Birmingham");
                var result = db.Employees.Count();
                Assert.AreEqual(1, result - numEmployees);
            }
        }

        [Test]
        public void WhenAEmployeeIsRemoved_TheyAreNoLongerInTheDatabase()
        {
            using (var db = new SouthwindContext())
            {
                var newEmployee = new Employee() { EmployeeId = "MANDA", EmployeeName = "Nish Mandal", PostalCode = "BRUM10", City = "Birmingham" };
                db.Employees.Add(newEmployee);
                db.SaveChanges();
                _employeeManager.DeleteEmployee("MANDA");
                var MANDACount = db.Employees.Where(e => e.EmployeeId == "MANDA").Count();
                Assert.AreEqual(0, MANDACount);
            }
        }


        [TearDown]
        public void TearDown()
        {
            using (var db = new SouthwindContext())
            {
                var selectedEmployees =
                from e in db.Employees
                where e.EmployeeId == "MANDA"
                select e;

                db.Employees.RemoveRange(selectedEmployees);
                db.SaveChanges();
            }
        }
    }
}