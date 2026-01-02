// Type alias for tuple - demonstrating C# 12's ability to alias any type
using Point = (int X, int Y);

namespace CSharpPlayground.Features;

/// <summary>
/// C# 12 Features (Released with .NET 8 in November 2023)
/// </summary>
public class CSharp12Features
{
    /// <summary>
    /// Feature: Primary Constructors for classes
    /// Declare constructor parameters directly in the class declaration
    /// </summary>
    public static void PrimaryConstructorsExample()
    {
        Console.WriteLine("\n=== C# 12: Primary Constructors ===");
        
        var person = new Person("Alice", 30);
        person.Introduce();
        
        var product = new Product("Laptop", 999.99m);
        Console.WriteLine(product);
    }

    /// <summary>
    /// Feature: Collection Expressions
    /// New concise syntax for creating collections
    /// </summary>
    public static void CollectionExpressionsExample()
    {
        Console.WriteLine("\n=== C# 12: Collection Expressions ===");
        
        // Using collection expressions with []
        int[] numbers = [1, 2, 3, 4, 5];
        List<string> fruits = ["apple", "banana", "cherry"];
        
        Console.WriteLine($"Numbers: {string.Join(", ", numbers)}");
        Console.WriteLine($"Fruits: {string.Join(", ", fruits)}");
        
        // Spread operator in collection expressions
        int[] moreNumbers = [..numbers, 6, 7, 8];
        Console.WriteLine($"More numbers: {string.Join(", ", moreNumbers)}");
    }

    /// <summary>
    /// Feature: Inline Arrays
    /// Fixed-size arrays as struct fields
    /// </summary>
    public static void InlineArraysExample()
    {
        Console.WriteLine("\n=== C# 12: Inline Arrays ===");
        
        var buffer = new Buffer10();
        for (int i = 0; i < 10; i++)
        {
            buffer[i] = i * 10;
        }
        
        Console.Write("Buffer values: ");
        for (int i = 0; i < 10; i++)
        {
            Console.Write($"{buffer[i]} ");
        }
        Console.WriteLine();
    }

    /// <summary>
    /// Feature: Default Lambda Parameters
    /// Lambda expressions can now have default parameter values
    /// </summary>
    public static void DefaultLambdaParametersExample()
    {
        Console.WriteLine("\n=== C# 12: Default Lambda Parameters ===");
        
        var greet = (string name = "World") => $"Hello, {name}!";
        
        Console.WriteLine(greet());           // Uses default
        Console.WriteLine(greet("Alice"));    // Uses provided value
    }

    /// <summary>
    /// Feature: Alias any type
    /// using alias can now refer to any type including tuples, pointers, etc.
    /// </summary>
    public static void AliasAnyTypeExample()
    {
        Console.WriteLine("\n=== C# 12: Alias Any Type ===");
        
        // Alias defined at the top of the file (see using statements)
        Point point = (10, 20);
        Console.WriteLine($"Point: X={point.Item1}, Y={point.Item2}");
    }
}

// Primary constructor example
public class Person(string name, int age)
{
    public void Introduce()
    {
        Console.WriteLine($"Hi, I'm {name} and I'm {age} years old.");
    }
}

// Primary constructor with validation
public class Product(string name, decimal price)
{
    public string Name { get; } = name ?? throw new ArgumentNullException(nameof(name));
    public decimal Price { get; } = price >= 0 ? price : throw new ArgumentException("Price must be non-negative");

    public override string ToString() => $"Product: {Name}, Price: ${Price}";
}

// Inline array example
[System.Runtime.CompilerServices.InlineArray(10)]
public struct Buffer10
{
    private int _element0;
}
