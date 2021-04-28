using System;
using System.Collections.Generic;

namespace SafariPark
{
    class Program
    {
        static void Main(string[] args)
        {

            {//Person cathy = new Person("Cathy", "French");
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

                //Airplane a = new Airplane(200, 100, "JetsRUs") { NumPassengers = 150 };
                //a.Ascend(500);
                //Console.WriteLine(a.Move(3));
                //Console.WriteLine(a);
                //a.Descend(200);
                //Console.WriteLine(a.Move());
                //a.Move();
                //Console.WriteLine(a);

                //var gameObjects = new List<Object>()
                //{ 
                //    new Person ("Nish", "Mandal"),
                //    new Airplane (400, 200, "Virgin"),
                //    new Vehicle (12, 20),
                //    new Hunter ("Tim", "Burton", "Nikon")
                //};

                //gameObjects.ForEach(x => Console.WriteLine(x));

                //var liam = new Person("Liam", "Gallagher");
                //SpartaWrite(liam);

                //var billoddie = new Hunter("Bill", "Oddie", "Nokia");
                //SpartaWrite(billoddie);
                //SpartaWrite((Person)billoddie);

                //// IMoveable Implementation
                //var movableObjects = new List<IMoveable>()
                //{
                //    new Person("John", "Smith")
                //    , new Hunter("Bill", "Oddie", "Nikon")
                //    , new Airplane (400, 200, "Virgin")
                //    , new Vehicle (12, 20),
                //};
                //movableObjects.ForEach(x => Console.WriteLine(x.Move()));

                //// <Weapon>/<IShootable> demonstration

                //var weaponList = new List<IShootable>()
                //{
                //      new WaterPistol("Nerf Super Soaker Zipfire")
                //     , new LaserGun("General Atomics AER9")
                //     , new Hunter("John", "Wayne", new Camera("Nikon") )
                //     , new Hunter("Richard", "Deckard", new Camera("Pentax") )
                //     , new Camera("Fujifilm")
                //};
                //weaponList.ForEach(x => Console.WriteLine(x.Shoot()));
            }

            //var gazelle = new Gazelle(10);
            //Console.WriteLine(gazelle.Move());
            //Console.WriteLine($"Position {gazelle.Position}");
            //Console.WriteLine(gazelle.Move(10));
            //Console.WriteLine($"Position {gazelle.Position}");

            //Console.WriteLine(gazelle);
            //Console.WriteLine(gazelle.FightOrFlight(1));

            //When you shoot the distance between yourself and the creature along with the volume of the item decide whether it startles or not.
            //If it's startled check if it's charging or bolting
            //If it's chargin it moves towards you, if it's bolting it runs away. Once it's X distance from you it has a chance to escape. 
            // You can either move/fire/switch device. 

            // Weapons
            var weaponList = new List<IShootable>()
            {
                  new WaterPistol("Nerf Super Soaker Zipfire")
                 , new LaserGun("General Atomics AER9")
                 , new Camera("Fujifilm")
            };

            Console.WriteLine("What is your first name ?");
            string fName = Console.ReadLine();
            Console.WriteLine("What is your last name ?");
            string lName = Console.ReadLine();

            Hunter player = new Hunter(fName, lName, weaponList[0]);

            bool gameOn = true;

            while (gameOn)
            {
                string command;
                Console.WriteLine($"Would you like to 1. Move, 2. Shoot, 3. Change tool ? 4. Exit game");
                command = Console.ReadLine();
                switch (command)
                {
                    case "1":
                        //Console.WriteLine("Left (L) or Right (R) ?");
                        //command = Console.ReadLine();
                        //if (command == "L")
                        //{
                        Console.WriteLine(player.Move());
                        //}
                        break;
                    case "2":
                        Console.WriteLine(player.Shoot());
                        break;
                    case "3":
                        weaponList.ForEach(x => Console.WriteLine( x.ToString() ) ) ;
                        int weapon = int.Parse(Console.ReadLine());
                        player.Shooter = weaponList[weapon];
                        break;
                    case "4":
                        Console.WriteLine("Are you sure ? (Y/N)");
                        string exit = Console.ReadLine();
                        gameOn = exit == "Y" ? false : true;
                        break;
                    default:
                        Console.WriteLine("Not a valid command");
                        break;
                }
            }

        }

        //static void SpartaWrite(Object obj)
        //{
        //    Console.WriteLine(obj);
        //    if (obj is Hunter)
        //    {
        //        var hunterObj = (Hunter)obj;
        //        Console.WriteLine(hunterObj.Shoot());
        //    }
        //}

        //static void DemoMethod(Point3d pt, Person p)
        //{
        //    pt.y = 1000;
        //    p.Age = 92;
        //}

    }
}
