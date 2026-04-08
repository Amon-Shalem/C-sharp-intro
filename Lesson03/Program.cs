// #define DEBUG
// #undef DEBUG

namespace Lesson03;

public static class Program
{
    public static void Main(string[] args)
    {
        //輸出
        /*Console.WriteLine("Hello, world!");
        Console.Write("Hello, world!");
        Console.Write("Hello, world!\n");*/

        #region MyRegion
        //輸入
        //單個字符
        // Console.WriteLine(Console.Read());
        
        // Gets the console key represented by the current ConsoleKeyInfo object.
        // Console.WriteLine(Console.ReadKey().Key);
        
        // Gets the Unicode character represented by the current ConsoleKeyInfo object.
        // Console.WriteLine(Console.ReadKey().KeyChar);

        // Gets a bitwise combination of ConsoleModifiers values that specifies one or more modifier keys pressed simultaneously with the console key
        // Console.WriteLine(Console.ReadKey().Modifiers);
        
        // Reads the next line of characters from the standard input stream
        // Console.WriteLine(Console.ReadLine());
        
        #endregion
// #if DEBUG
//         Console.WriteLine("DEBUG");
// #else
//         Console.Write("Hello");
// #endif

// #warning 这是一个警告
// #error 这是一个错误

// #line 100 "program1.cs"
//         throw new Exception("這是第100行");
// #pragma warning disable CS0219
//         int unusedInt = 14;
// #pragma warning restore CS0219
//         int unused = 14;

// #nullable enable
//         
// #nullable disable
//         string? canBeNull = null;
//         string cannotBeNull = "Hello";
//         cannotBeNull = null;



    }
}