namespace CSharpPlayground.Features;

/// <summary>
/// C# 10 Features (Released with .NET 6 in November 2021)
/// </summary>
public class CSharp10Features
{
    /// <summary>
    /// Feature: File-scoped Namespaces
    /// Reduce indentation by using file-scoped namespace declaration
    /// (This file itself demonstrates this feature)
    /// </summary>
    public static void FileScopedNamespacesExample()
    {
        Console.WriteLine("\n=== C# 10: File-scoped Namespaces ===");
        Console.WriteLine("This file uses file-scoped namespace: namespace CSharpPlayground.Features;");
        Console.WriteLine("No need for braces, reduces indentation by one level!");
    }

    /// <summary>
    /// Feature: Global Using Directives
    /// Using statements can be marked as global and apply to all files
    /// (Enabled in the .csproj with ImplicitUsings)
    /// </summary>
    public static void GlobalUsingExample()
    {
        Console.WriteLine("\n=== C# 10: Global Using Directives ===");
        Console.WriteLine("Common namespaces like System, System.Linq are automatically available!");
        Console.WriteLine("No need to add 'using System;' at the top of each file.");
    }

    /// <summary>
    /// Feature: Record Structs
    /// Structs can now be declared as records
    /// </summary>
    public static void RecordStructsExample()
    {
        Console.WriteLine("\n=== C# 10: Record Structs ===");
        
        var point1 = new Point3D(1, 2, 3);
        var point2 = new Point3D(1, 2, 3);
        var point3 = point1 with { Z = 5 };
        
        Console.WriteLine($"Point1: {point1}");
        Console.WriteLine($"Point2: {point2}");
        Console.WriteLine($"Point1 == Point2: {point1 == point2}");
        Console.WriteLine($"Point3 (modified): {point3}");
    }

    /// <summary>
    /// Feature: Constant Interpolated Strings
    /// String interpolation can now be used in const declarations
    /// </summary>
    public static void ConstantInterpolatedStringsExample()
    {
        Console.WriteLine("\n=== C# 10: Constant Interpolated Strings ===");
        Console.WriteLine($"Greeting: {Constants.Greeting}");
        Console.WriteLine($"Full Greeting: {Constants.FullGreeting}");
    }

    /// <summary>
    /// Feature: Extended Property Patterns
    /// Simplified property pattern syntax
    /// </summary>
    public static void ExtendedPropertyPatternsExample()
    {
        Console.WriteLine("\n=== C# 10: Extended Property Patterns ===");
        
        var employee = new Employee("Alice", new Address("Seattle", "WA"));
        
        // Extended property pattern - no need for nested braces
        if (employee is { Address.City: "Seattle" })
        {
            Console.WriteLine($"{employee.Name} is from Seattle!");
        }
    }

    /// <summary>
    /// Feature: Lambda Improvements
    /// Lambdas can have attributes and explicit return types
    /// </summary>
    public static void LambdaImprovementsExample()
    {
        Console.WriteLine("\n=== C# 10: Lambda Improvements ===");
        
        // Lambda with explicit return type
        var parse = int (string s) => int.Parse(s);
        Console.WriteLine($"Parsed value: {parse("42")}");
        
        // Natural type for lambda expressions
        var lambda = (int x, int y) => x + y;
        Console.WriteLine($"Lambda result: {lambda(5, 3)}");
    }

    /// <summary>
    /// Feature: Caller Argument Expression
    /// Get the argument expression as a string at compile time
    /// </summary>
    public static void CallerArgumentExpressionExample()
    {
        Console.WriteLine("\n=== C# 10: Caller Argument Expression ===");
        
        int value = 42;
        ValidateArgument(value > 0, value);
        ValidateArgument(value < 100, value);
    }

    private static void ValidateArgument(
        bool condition, 
        object? value,
        [System.Runtime.CompilerServices.CallerArgumentExpression("condition")] string? expression = null)
    {
        Console.WriteLine($"Validating: {expression} (value: {value}) = {condition}");
    }
}

// Record struct example
public readonly record struct Point3D(int X, int Y, int Z);

// Constants with interpolation
public static class Constants
{
    private const string Prefix = "Hello";
    public const string Greeting = $"{Prefix}, World!";
    public const string FullGreeting = $"{Greeting} Welcome to C# 10!";
}

// Extended property patterns example
public record Employee(string Name, Address Address);
public record Address(string City, string State);
