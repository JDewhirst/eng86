using System;

namespace SafariPark
{
    class Program
    {
        static void Main(string[] args)
        {
            //Person cathy = new Person("Cathy", "French");
            //Console.WriteLine(cathy.GetFullName());

            //cathy.Age = -1;
            //Console.WriteLine("Cath's Age:s " + cathy.Age);
            //cathy.Age = 26;
            //Console.WriteLine("Cath's Age:s " + cathy.Age);

            //Person nish; // declaring nish before they're constructed. value will be null
            //nish = new Person("Nish", "Mandal");
            //Console.WriteLine(nish.GetFullName());

            ////var sparta = new Spartan("Nish", "Mandal", 30);
            //var spartan = new Spartan { FirstName = "Nish", LastName = "Mandal Age = 30" };
            //var age = spartan.Age;

            //var rouz = new Person();
            //var callum = new Person("Callum", "Harding");
            //var michael = new Person("Michael", "Wilcock", 22);

            //var hamse = new Person("Hamse", "Ahmed") { Age = 21 };

            //var shopList = new ShoppingList { Bread = 2, Milk = 10, Potato = 1 };

            //// Structs
            //Point3d p;

            Person paul = new Person("Paul", "Mcartney") { Age = 80 };
            Point3d pt3d = new Point3d(5, 8, 2);
            DemoMethod(pt3d, paul);

        }

        static void DemoMethod(Point3d pt, Person p)
        {
            pt.y = 1000;
            p.Age = 92;
        }
    }
}
