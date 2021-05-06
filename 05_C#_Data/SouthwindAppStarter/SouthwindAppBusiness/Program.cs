using System;
using System.Collections.Generic;
using SouthwindApp;

namespace SouthwindAppBusiness
{
    class Program
    {
        static void Main(string[] args)
        {
            var _crudManager = new CRUDManager();
            //_crudManager.CreateEmployee("WAYNE", "Bruce Wayne", "GO4 114M", "Gotham");
            //_crudManager.CreateEmployee("DEWHI", "Jack Dewhirst", "HU5 5QG", "Hull");

            var employeeList = _crudManager.RetrieveAllEmployees();
            employeeList.ForEach(e => Console.WriteLine(e));
        }
    }
}
