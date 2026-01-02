namespace CSharpPlayground.Features;

/// <summary>
/// C# 13 Features (Released with .NET 10 in November 2024)
/// </summary>
public class CSharp13Features
{
    /// <summary>
    /// Feature: params collections - params can now be used with any collection type
    /// Previously limited to arrays, now works with Span, ReadOnlySpan, IEnumerable, etc.
    /// </summary>
    public static void ParamsCollectionsExample()
    {
        Console.WriteLine("\n=== C# 13: params Collections ===");
        
        // params with Span<T>
        PrintNumbers(1, 2, 3, 4, 5);
        
        // params with List<T>
        PrintItems("apple", "banana", "cherry");
    }
    
    private static void PrintNumbers(params Span<int> numbers)
    {
        Console.Write("Numbers: ");
        foreach (var num in numbers)
        {
            Console.Write($"{num} ");
        }
        Console.WriteLine();
    }
    
    private static void PrintItems(params IEnumerable<string> items)
    {
        Console.Write("Items: ");
        foreach (var item in items)
        {
            Console.Write($"{item} ");
        }
        Console.WriteLine();
    }

    /// <summary>
    /// Feature: New escape sequence \e for ESCAPE character (0x1B)
    /// Useful for ANSI escape codes without using \x1B or \u001B
    /// </summary>
    public static void EscapeSequenceExample()
    {
        Console.WriteLine("\n=== C# 13: New \\e Escape Sequence ===");
        
        // Using the new \e escape sequence for ANSI colors
        Console.WriteLine($"\e[32mThis text is green!\e[0m");
        Console.WriteLine($"\e[1;31mThis text is bold red!\e[0m");
        Console.WriteLine($"\e[33mThis text is yellow!\e[0m");
    }

    /// <summary>
    /// Feature: Lock object improvements
    /// New System.Threading.Lock type for better performance
    /// </summary>
    public static void LockObjectExample()
    {
        Console.WriteLine("\n=== C# 13: Lock Object Improvements ===");
        
        var lockObj = new Lock();
        int counter = 0;
        
        lock (lockObj)
        {
            counter++;
            Console.WriteLine($"Counter in lock: {counter}");
        }
    }
}
