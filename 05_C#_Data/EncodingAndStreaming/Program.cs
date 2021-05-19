//#define TEST

using System;
using System.Diagnostics;
using System.IO;

namespace EncodingAndStreaming
{
    class Program
    {
        static void Main(string[] args)
        {
            //File.WriteAllText("Hello.txt", "text");

            //// Logging - Trace and Debug class
            ///
            //Console.WriteLine($"This is being logged at {DateTime.Now}");
            //var twtl = new TextWriterTraceListener(File.Create("TraceOutput.txt"));
            //Trace.Listeners.Add(twtl);
            //for (int i = 0; i < 3; i++)
            //{
            //    Console.WriteLine(i);
            //    Debug.WriteLine($"Debug - the value of i is {i}");
            //    Trace.WriteLine($"Debug - the value of i is {i}");
            //    Debug.WriteLineIf( i == 2, $"\nReached max value of i: {i} at {DateTime.Now}");
            //    //Trace.Assert(i > 0, $"i is not greater than zero - {i}");

            //}
            //Trace.Flush();

            ////Conditional Compiling
            Console.WriteLine("Starting App");
#if DEBUG
            Console.WriteLine("This is debug code");
#endif
#if TEST
            System.Console.WriteLine("Testing the app");
#endif
            Console.WriteLine("Finishing App");


        }
    }
}
