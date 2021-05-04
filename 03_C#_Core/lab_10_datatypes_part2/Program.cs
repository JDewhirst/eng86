using System;
using System.Diagnostics;

namespace lab_10_datatypes_part2
{
    class Program
    {
        private readonly string fName;
        private readonly string lName = "Nish";
        private const int age = 31;

        public Program(string firstname)
        {
            fName = firstname;
        }

        static void Main(string[] args)
        {
            //// Date
            //var d = new DateTime();
            //var d1 = DateTime.Today;

            //var d2 = new DateTime(2020, 7, 12, 10, 5, 18);
            //d2 = d2.AddDays(1);
            //d2 = d2.AddMonths(2);

            //// arithmetic on date times 
            //var date = DateTime.Today;
            //var birthDate = new DateTime(1989, 11, 02);
            //var age = date - birthDate;
            //Console.WriteLine((int)age.Days / 365.25);

            //// Formatting
            //var output = DateTime.Now.ToString("dd-MM-yyyy");
            //var output2 = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
            //var output3 = DateTime.Now.ToString("yy-dd-MM");

            //// TimeSpan and Ticks
            //// 1 hour time span
            //var timespan = new TimeSpan(1, 0, 0);
            //// add timespan to time now
            //var date = DateTime.Now + timespan;
            //// add 1 tick to our date
            //var tick = new TimeSpan(1);
            //date = date + tick;

            //// Stopwatch
            //var s = new Stopwatch();
            //s.Start();
            //int total = 0;

            //for (int i = 0; i < Int32.MaxValue; i++)
            //{
            //    total += i;
            //}
            //s.Stop();
            //Console.WriteLine(s.Elapsed);
            //Console.WriteLine(s.ElapsedMilliseconds);
            //Console.WriteLine(s.ElapsedTicks);

            //// Enums
            //Suit theSuit = Suit.HEARTS;
            //Console.WriteLine(Suits(theSuit));

            //var monday = (int)DayOfWeek.Monday;
            //Console.WriteLine(monday);

            //var tuesday = (DayOfWeek)2;
            //Console.WriteLine(tuesday);

            //// Defaults
            //int dog;
            //float cat;
            //bool thing;
            //char c;
            //DateTime dt;
            //string aString;
            //int[] myArray;

            // Nullable Types
            //bool? hasPassed;
            //int? hasPassed = null;

            //if (hasPassed.HasValue)
            //{
            //    Console.WriteLine("Congrats");
            //}
            //else
            //{
            //    Console.WriteLine("No value");
            //}

            //int? nullableScore = null;
            //int score = nullableScore ?? -9999;
            //int score1 = nullableScore.GetValueOrDefault(-1);
            //int score2 = nullableScore.GetValueOrDefault();

            //// Const, readonly and Dynamics
            //const int dozen = 12;
            //// dozen = 13;

            // Random
            //var rng = new Random(); //seed with current time
            //var rngSeeded = new Random(42);
            //var between1And10 = rngSeeded.Next(1, 11);

            //var rollThedice = new Random();
            //var dice1 = rollThedice.Next(6);
            //var dice2 = rollThedice.Next(6);

        }

        public enum Suit
        {
            HEARTS, CLUBS, DIAMONDS, SPADES
        }

        public static string Suits(Suit suit)
        {
            switch (suit)
            {
                case Suit.HEARTS:
                    return "You have stole in";
                case Suit.CLUBS:
                    return "The best one in town";
                case Suit.DIAMONDS:
                    return "My best mate";
                case Suit.SPADES:
                    return "Dig deep";
                default:
                    return "Not a suit";
            }
        }
    }
}
