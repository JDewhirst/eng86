﻿using System;
using System.Collections.Generic;

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

            //Person paul = new Person("Paul", "Mcartney") { Age = 80 };
            //Point3d pt3d = new Point3d(5, 8, 2);
            //DemoMethod(pt3d, paul);

            ///*Hunter h = new Hunter("Hossain", "Ghazal", "Leica") { Age = 22 };*/
            //Console.WriteLine(h.Age);
            //Console.WriteLine(h.Shoot());
            //Hunter h = new Hunter("Hossain", "Ghazal", "Leica") { Age = 22 };
            //Hunter h2 = new Hunter("Hossain", "Ghazal", "Leica") { Age = 22 };

            //Console.WriteLine($"{h} Equals {h2}? {h.Equals(h2)}");
            //Console.WriteLine($"{h} HashCode: {h.GetHashCode()}");
            //Console.WriteLine($"{h} ToString(): {h.ToString()}");
            //Console.WriteLine(h);

            //var rectangle1 = new Rectangle { Width = 10, Height = 10 };
            //var rectangle2 = new Rectangle { Width = 15, Height = 10 };

            //var shapeList = new List<Shape> { rectangle1, rectangle2 };
            //var totalArea = 0;

            //shapeList.ForEach(x => totalArea += x.CalculateArea());
            //Console.WriteLine(totalArea);

            Airplane a = new Airplane(200, 100, "JetsRUs") { NumPassengers = 150 };
            a.Ascend(500);
            Console.WriteLine(a.Move(3));
            Console.WriteLine(a);
            a.Descend(200);
            Console.WriteLine(a.Move());
            a.Move();
            Console.WriteLine(a);



        }

        //static void DemoMethod(Point3d pt, Person p)
        //{
        //    pt.y = 1000;
        //    p.Age = 92;
        //}
    }
}
