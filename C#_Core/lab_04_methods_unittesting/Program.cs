using System;

namespace Methods
{
    public class Program
    {
        static void Main(string[] args)
        {
            //DoThis1();
            // var output = DoThis2();
            //var output = DoThis3(10, "Sparta Global");
            // var output = DoThat(10);
            //OrderPizza(true, true, true);
            // OrderPizza(pineapple: false, anchovies: false);

            //// Ref keyword demonstration
            //int number = 10;
            //Add(number);
            //Console.WriteLine(number);
            //Add(ref number);
            //Console.WriteLine(number);

            //// Out keyword
            //var result = DoAgain(10, "Sparta Global", out bool z);

            // Tuples
            //var myTuple = ("Frazer", "Green", 22);
            //(string, string, int) myTuple2 = ("Michael", "Wilcock", 23);
            //(string fName, string lName, int age) myTuple3 = ("Hamse", "Ahmed", 21);
            //Console.WriteLine(myTuple2.Item2);
            //Console.WriteLine(myTuple3.age);

            //// Returning a tuple
            //var result = DoThatAgain(10, "Sparta Global");
            //Console.WriteLine(result);
            //Console.WriteLine(result.xsquared);
            //var (square, greaterThan10) = DoThatAgain(5, "Heya");
            //Console.WriteLine(greaterThan10);
            //Console.WriteLine(square);

            //// Overloading
            //Console.WriteLine(Add(2,3));
            //Console.WriteLine(Add(4,5,6));

            // Return with out keyword/tuple excercise
            var result = TripleCalc(2, 3, 4, out int x);
            Console.WriteLine(result);
            Console.WriteLine(x);
            var result2 = TripleCalc(4, 5, 6);
            Console.WriteLine(result2);
            Console.WriteLine(result2.sum);
            Console.WriteLine(result2.product);

        }

        //public static void DoThis1()
        //{
        //    Console.WriteLine("I am doing something");
        //}

        //public static int DoThis2()
        //{
        //    Console.WriteLine("I am returning 100");
        //    return 100;
        //}

        //public static int DoThis3(int x, string y)
        //{
        //    Console.WriteLine(y);
        //    return x * x;
        //}

        //public static int DoThat(int x, string y = "Default")
        //{
        //    Console.WriteLine(y);
        //    return x * x;
        //}

        //public static void OrderPizza(bool anchovies, bool pineapple, bool mushrooms = false)
        //{
        //    if (anchovies && pineapple && mushrooms)
        //    {
        //        Console.WriteLine("Delicious");
        //    }
        //    else if (anchovies && !pineapple && mushrooms)
        //    {
        //        Console.WriteLine("I wanted pineapple");
        //    }
        //    else if (!anchovies && !pineapple && !mushrooms)
        //    {
        //        Console.WriteLine("Just bread");
        //    }
        //    else
        //    {
        //        Console.WriteLine("What the hell kind of pizza place is this ?");
        //    }
        //}

        //static void Add(int x)
        //{
        //    x++;
        //}

        //static void Add(ref int x)
        //{
        //    x++;
        //}

        //public static int DoAgain(int x, string y, out bool z)
        //{
        //    Console.WriteLine(y);
        //    z = (x > 10);
        //    return x * x;
        //}

        //public static (int xsquared, bool y_got_10) DoThatAgain(int x, string y)
        //{
        //    Console.WriteLine(y);
        //    var z = (x > 10);
        //    return (x * x, z);
        //}

        //public static int Add(int x, int y)
        //{
        //    return x + y;
        //}

        //public static int Add(int x, int y, int z)
        //{
        //    return x + y + z;
        //}

        // Return with out keyword/tuple excercise
        public static int TripleCalc(int a, int b, int c, out int sum)
        {
            sum = a + b + c;
            return a * b * c;
        }

        public static (int sum, int product) TripleCalc(int a, int b, int c)
        {
            int sum = a + b + c;
            int product = a * b * c;
            return (sum, product);
        }
    }
}
