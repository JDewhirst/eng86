using System;

namespace Selection
{
    public class Program
    {
        static void Main(string[] args)
        {
            //var number = 15;
            //var result = "";

            //if (number % 5 ==0)
            //{
            //    result += "Nish";
            //} 
            //else if (number % 5 == 0)
            //{
            //    result += "Nash";
            //}

            //Console.WriteLine("Result");

            //// nested if
            //var number = 10;
            //var result = "";

            //if (number % 5 == 0)
            //{
            //    result += "Nish";
            //    if (number % 3 == 0)
            //    {
            //        result += "Nash";
            //    }
            //    else
            //    {
            //        result += "Nosh";
            //    }
            //}

            //Console.WriteLine("Result");

            //DaysOfWeek(7);
            //Console.WriteLine(Priority(2));
            Console.WriteLine(PassFailTernary(88));

            int mark = 65;
            int numStars = mark > 60 ? 3 : 1;
        }

        public static string PassFailTernary(int mark)
        {
            return (mark >= 40) ? "Pass" : "Fail";

        }

        public static string Priority(int level)
        {
            string priority = "Code ";

            switch (level)
            {
                case 3:
                    priority += "Red";
                    break;
                case 2:
                case 1:
                    priority += "Amber";
                    break;
                case 0:
                    priority += "Green";
                    break;
                default:
                    priority = "Error";
                    break;
            }

            return priority;
        }

        public static void DaysOfWeek(int day)
        {
            switch (day)
            {
                case 1:
                    Console.WriteLine("Monday");
                    break;
                case 2:
                    Console.WriteLine("Tuesday");
                    break;
                case 3:
                    Console.WriteLine("Wednesday");
                    break;
                case 4:
                    Console.WriteLine("Thursday");
                    break;
                case 5:
                    Console.WriteLine("Friday");
                    break;
                case 6:
                    Console.WriteLine("Saturday");
                    break;
                case 7:
                    Console.WriteLine("Sunday");
                    break;
                default:
                    Console.WriteLine("Not Valid");
                    break;
            }
        }

        public static string PassFail(int mark)
        {
            var grade = "Fail";
            if (mark >= 40)
            {
                grade = "Pass";
            }
            return grade;
        }

        public static string Grade(int mark)
        {
            var grade = "Pass";
            if (mark >= 40)
            {
                if (mark >= 75)
                {
                    grade += " with Distinction";
                }
                else if (mark >= 60)
                {
                    grade += " with Merit";
                }
            }
            else
            {
                grade = "Fail";
            }
            return grade;
        }
    }
}
