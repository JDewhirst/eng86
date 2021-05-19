# Encoding & Streaming

Input and output to Console. Input and output to File. Logging in Visual Studio. Loggin to .txt. Conditional compilation. Text vs bin files.

## Simple Console & File I/O

Console input output not suitable for production code.

The simplest way to readwrite from files is to use static methods of System.IO>file.

These methods are simple to use. They are creating a stream, wrapping it in a write, doing the read operation, closing the stream and handling any exceptions are done for you.

## Logging

Simplest way is logging to a console. eg, `Console.WriteLine("This is being logged at {DateTime.Now}")`

We can also log using the output window of Visual Studio. To do so we need to use the System.Diagnostics namespace. Out persists even after the application closes. Particularly useful for non-console applications (for example, WPF, Test, Web)

```c#
Debug.WriteLine($"the value of i is {i}")
    Trace.WriteLineIf( Listboxcustomer.SelectedItem.ToString().Contains("blog"))
```

We can also direct the Trace and/or Debug output to file so we can view it later.

```c#
Console.WriteLine($"This is being logged at {DateTime.Now}");
var twtl = new TextWriterTraceListener(File.Create("TraceOutput.txt"));
Trace.Listeners.Add(twtl);
for (int i = 0; i < 3; i++)
{
    Console.WriteLine(i);
    Debug.WriteLine($"Debug - the value of i is {i}");
    Trace.WriteLine($"Debug - the value of i is {i}");
    Debug.WriteLineIf( i == 2, $"\nReached max value of i: {i} at {DateTime.Now}");
    //Trace.Assert(i > 0, $"i is not greater than zero - {i}");

}
Trace.Flush();
```

This will write the debug messages to the file TraceOutput.txt

### Difference between debug and trace

Use the debug class to make messages that monitor executin, sequence, detect malfunctions, or provide performance measurement info

By default the messages that the debug class produce appear in the output window of VS.

When you use this method to produce a message, each message each message appears on a separate line in the output window. Runs in both modes, debug only in debug mode.

Trace runs on a separate thread.  Debug goes through the code. Trace is monitoring how the application is running from alongside it.

## Conditional Compiling

We can set a flag which controls which code gets compiled. Useful if you want different actions in debug and release mode, for example using different resources.

```c#
            Console.WriteLine("Starting App");
#if DEBUG 
            Console.WriteLine("This is debug code");
#endif
            Console.WriteLine("Finishing App");
```

## More about files

nayuki.or/page/what-are-binary-and-text-files

Every file starts with a few bytes which identify the file type, called the file signature. May be followed by header information about the contents of the file.

## Character-based Encoding

ASCII is the most common type of computer encoding. It uses the numbers from 0 through 127 to represent: characters such as escape and space and others, letters and numbers a to z, A to Z, and 0 to 9, symbols such as !"£$%^&*()$$%^&

UTF-8 takes basic ASCII encoding so that it fits neatly in blocks of 8 bits, and allows room for 128 extra characters.

@ escapes from csharp keywords