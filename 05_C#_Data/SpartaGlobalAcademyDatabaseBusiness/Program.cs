using System;
using SpartaGlobalAcademyDatabase;
using System.Linq;
using System.Collections.Generic;


namespace SpartaGlobalAcademyDatabaseBusiness
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var db = new SpartaGlobalAcademyContext())
            {
                // CRUD 
                // R
                var traineesquery =
                    from trainee in db.Trainees
                    select trainee;
                foreach (var item in traineesquery)
                {
                    Console.WriteLine(item);
                }

            }
        }
    }
}
