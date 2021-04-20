using System;

namespace lab_01_helloworld
{
    class Program
    {
        static void Main(string[] args)
        {
            //int x = 100;
            //x += 10;
            //for (int i = 0; i <= 10; i++)
            //{
            //    Console.WriteLine(i);
            //    x += i;
            //}
            Console.WriteLine("Hello, command line demo");
            foreach (var item in args)
            {
                Console.WriteLine(item);
            }
        }
    }
}
