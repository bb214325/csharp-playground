// Type aliases (C# 12 feature)
using Coordinate = (double Latitude, double Longitude);
using IntArray = int[];

namespace CSharpFeatures.Features;

/// <summary>
/// Demonstrates C# 12 features released with .NET 8
/// </summary>
public class CSharp12Features
{
    public static void DemonstrateAll()
    {
        Console.WriteLine("=== C# 12 Features ===\n");
        
        DemonstratePrimaryConstructors();
        DemonstrateCollectionExpressions();
        DemonstrateRefReadonlyParameters();
        DemonstrateAliasAnyType();
        DemonstrateDefaultLambdaParameters();
    }
    
    /// <summary>
    /// Primary Constructors - Simplified constructor syntax
    /// </summary>
    private static void DemonstratePrimaryConstructors()
    {
        Console.WriteLine("1. Primary Constructors:");
        var person = new Person("Alice", 30);
        Console.WriteLine($"   {person}");
        
        var point = new Point(10, 20);
        Console.WriteLine($"   Point: {point}\n");
    }
    
    /// <summary>
    /// Collection Expressions - Concise syntax with [...]
    /// </summary>
    private static void DemonstrateCollectionExpressions()
    {
        Console.WriteLine("2. Collection Expressions:");
        
        // Create arrays
        int[] numbers = [1, 2, 3, 4, 5];
        Console.WriteLine($"   Array: [{string.Join(", ", numbers)}]");
        
        // Create lists
        List<string> names = ["Alice", "Bob", "Charlie"];
        Console.WriteLine($"   List: [{string.Join(", ", names)}]");
        
        // Spread operator
        int[] moreNumbers = [..numbers, 6, 7, 8];
        Console.WriteLine($"   With spread: [{string.Join(", ", moreNumbers)}]");
        
        // Combining collections
        string[] combined = [..names, "David", "Eve"];
        Console.WriteLine($"   Combined: [{string.Join(", ", combined)}]\n");
    }
    
    /// <summary>
    /// Ref Readonly Parameters - Pass by reference without allowing modification
    /// </summary>
    private static void DemonstrateRefReadonlyParameters()
    {
        Console.WriteLine("3. Ref Readonly Parameters:");
        var largeStruct = new LargeStruct(1000);
        int sum = CalculateSum(in largeStruct);
        Console.WriteLine($"   Sum of large struct values: {sum}\n");
    }
    
    private static int CalculateSum(ref readonly LargeStruct data)
    {
        // Can read but cannot modify the parameter
        return data.Value * 2;
    }
    
    /// <summary>
    /// Alias Any Type - Use 'using' for any type including tuples
    /// </summary>
    private static void DemonstrateAliasAnyType()
    {
        Console.WriteLine("4. Alias Any Type:");
        Coordinate coord = (10.5, 20.3);
        Console.WriteLine($"   Coordinate: ({coord.Latitude}, {coord.Longitude})");
        
        IntArray numbers = [1, 2, 3, 4, 5];
        Console.WriteLine($"   IntArray: [{string.Join(", ", numbers)}]\n");
    }
    
    /// <summary>
    /// Default Lambda Parameters - Lambda expressions can have default values
    /// </summary>
    private static void DemonstrateDefaultLambdaParameters()
    {
        Console.WriteLine("5. Default Lambda Parameters:");
        
        var greet = (string name = "Guest") => $"Hello, {name}!";
        Console.WriteLine($"   {greet()}");
        Console.WriteLine($"   {greet("Alice")}\n");
        
        var multiply = (int x, int y = 10) => x * y;
        Console.WriteLine($"   5 * 10 = {multiply(5)}");
        Console.WriteLine($"   5 * 3 = {multiply(5, 3)}\n");
    }
}

// Primary Constructor example for class
public class Person(string name, int age)
{
    public string Name { get; } = name;
    public int Age { get; } = age;
    
    public override string ToString() => $"Person: {Name}, Age: {Age}";
}

// Primary Constructor example for struct
public readonly struct Point(int x, int y)
{
    public int X { get; } = x;
    public int Y { get; } = y;
    
    public override string ToString() => $"({X}, {Y})";
}

public readonly struct LargeStruct(int value)
{
    public int Value { get; } = value;
}
