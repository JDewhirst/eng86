using System;

namespace lab_02_datatypes_part1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Integer Overflow and Underflow
            // checked keyword example
            //checked
            //{
            //    int a = Int32.MaxValue;
            //    int b = a + 1;

            //    Console.WriteLine(a);
            //    Console.WriteLine(b);
            //}

            //// Floating point precision demonstration
            //float sum = 0;
            //for (int i = 0; i < 1000; i++)
            //{
            //    sum += 1 / 3.0f;
            //}

            //Console.WriteLine("1/3 added 1000 times: " + sum);
            //Console.WriteLine("1/3 multiplied by 1000: " + 1/3.0f * 1000);


            //char c = 'c';
            //// Implicit casting
            //int x = c;
            //// explicit casting
            //char d = (char)x;

            //// no data loss - float is smaller than double
            //float x = 3.14f;
            //double y = x;

            //// will not implicitly convert double to float, need to cast explicitly
            //double z = 3.14;
            //float e = (float)z;


            //var convertExample = System.Convert.ToChar(1);
            //Console.WriteLine(convertExample);

            //// Converting signed to unsigned int
            //int i = -255;
            //uint j = (uint)i;

            //// Booleans
            ///
            //bool likeBananas = true;
            //Console.WriteLine(likeBananas);
            //var x = System.Convert.ToInt32(likeBananas);
            //Console.WriteLine(x);

            //// Rounding Floats
            //double pi = 3.141592;
            //pi = Math.Round(pi, 3);

            //// var keyword
            //var x = (1, "nish"); // tuple
            //var y = new List<int>{ 1, 2, 3 };
            //var z = new int[3] { 1, 2, 3 };

        }
    }
}
