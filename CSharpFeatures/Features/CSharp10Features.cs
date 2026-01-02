// Global using directives example (C# 10)
global using System.Text;

namespace CSharpFeatures.Features;

/// <summary>
/// Demonstrates C# 10 features released with .NET 6
/// </summary>
public class CSharp10Features
{
    public static void DemonstrateAll()
    {
        Console.WriteLine("=== C# 10 Features ===\n");
        
        DemonstrateFileScopedNamespaces();
        DemonstrateGlobalUsings();
        DemonstrateRecordStructs();
        DemonstrateConstantInterpolatedStrings();
        DemonstrateExtendedPropertyPatterns();
        DemonstrateLambdaImprovements();
        DemonstrateCallerArgumentExpression();
    }
    
    /// <summary>
    /// File-Scoped Namespaces - Reduce indentation
    /// </summary>
    private static void DemonstrateFileScopedNamespaces()
    {
        Console.WriteLine("1. File-Scoped Namespaces:");
        Console.WriteLine("   This file uses file-scoped namespace: 'namespace CSharpFeatures.Features;'");
        Console.WriteLine("   Reduces one level of indentation\n");
    }
    
    /// <summary>
    /// Global Using Directives - Import namespaces project-wide
    /// </summary>
    private static void DemonstrateGlobalUsings()
    {
        Console.WriteLine("2. Global Using Directives:");
        Console.WriteLine("   'global using System.Text;' at top of file");
        
        // StringBuilder is available without explicit using
        var sb = new StringBuilder("Global usings work! ");
        sb.Append("No need for 'using System.Text;' in each file.");
        Console.WriteLine($"   {sb}\n");
    }
    
    /// <summary>
    /// Record Structs - Value type records
    /// </summary>
    private static void DemonstrateRecordStructs()
    {
        Console.WriteLine("3. Record Structs:");
        
        var point1 = new PointRecord(10, 20);
        var point2 = new PointRecord(10, 20);
        var point3 = new PointRecord(15, 25);
        
        Console.WriteLine($"   point1: {point1}");
        Console.WriteLine($"   point1 == point2: {point1 == point2}");
        Console.WriteLine($"   point1 == point3: {point1 == point3}");
        
        // With expression
        var point4 = point1 with { Y = 30 };
        Console.WriteLine($"   point1 with {{ Y = 30 }}: {point4}\n");
    }
    
    /// <summary>
    /// Constant Interpolated Strings - String interpolation in const
    /// </summary>
    private static void DemonstrateConstantInterpolatedStrings()
    {
        Console.WriteLine("4. Constant Interpolated Strings:");
        const string Language = "C#";
        const string Version = "10";
        const string Message = $"{Language} {Version} Features";
        Console.WriteLine($"   Constant message: {Message}\n");
    }
    
    /// <summary>
    /// Extended Property Patterns - Nested property matching
    /// </summary>
    private static void DemonstrateExtendedPropertyPatterns()
    {
        Console.WriteLine("5. Extended Property Patterns:");
        
        var order1 = new Order(
            new Customer("Alice", new Address("New York", "NY")), 
            150.00m
        );
        var order2 = new Order(
            new Customer("Bob", new Address("Los Angeles", "CA")), 
            250.00m
        );
        
        CheckOrder(order1);
        CheckOrder(order2);
        Console.WriteLine();
    }
    
    private static void CheckOrder(Order order)
    {
        string result = order switch
        {
            { Customer.Address.State: "NY", Amount: > 100 } => 
                "NY order over $100 - free shipping!",
            { Customer.Address.State: "CA" } => 
                "California order",
            _ => "Regular order"
        };
        Console.WriteLine($"   {order.Customer.Name}: {result}");
    }
    
    /// <summary>
    /// Lambda Improvements - Natural types and explicit return types
    /// </summary>
    private static void DemonstrateLambdaImprovements()
    {
        Console.WriteLine("6. Lambda Improvements:");
        
        // Natural type inference
        var parse = (string s) => int.Parse(s);
        Console.WriteLine($"   Parse '42': {parse("42")}");
        
        // Explicit return type
        var multiply = int (int x, int y) => x * y;
        Console.WriteLine($"   5 * 6 = {multiply(5, 6)}\n");
    }
    
    /// <summary>
    /// CallerArgumentExpression - Capture argument expressions
    /// </summary>
    private static void DemonstrateCallerArgumentExpression()
    {
        Console.WriteLine("7. CallerArgumentExpression:");
        
        int value = 42;
        ValidateArgument(value > 0);
        
        string? text = null;
        try
        {
            ValidateArgument(text != null);
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine($"   Caught: {ex.Message}");
        }
        Console.WriteLine();
    }
    
    private static void ValidateArgument(
        bool condition,
        [System.Runtime.CompilerServices.CallerArgumentExpression(nameof(condition))] 
        string? message = null)
    {
        if (!condition)
        {
            throw new ArgumentException($"Validation failed: {message}");
        }
        Console.WriteLine($"   Validation passed: {message}");
    }
}

// Record struct example
public record struct PointRecord(int X, int Y);

// Extended property patterns example
public record Customer(string Name, Address Address);
public record Address(string City, string State);
public record Order(Customer Customer, decimal Amount);
