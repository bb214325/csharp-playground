namespace CSharpFeatures.Features;

/// <summary>
/// Demonstrates C# 11 features released with .NET 7
/// </summary>
public class CSharp11Features
{
    public static void DemonstrateAll()
    {
        Console.WriteLine("=== C# 11 Features ===\n");
        
        DemonstrateRawStringLiterals();
        DemonstrateRequiredMembers();
        DemonstrateGenericAttributes();
        DemonstrateUtf8StringLiterals();
        DemonstrateListPatterns();
        DemonstrateNewlinesInStringInterpolation();
    }
    
    /// <summary>
    /// Raw String Literals - Multi-line strings with """ syntax
    /// </summary>
    private static void DemonstrateRawStringLiterals()
    {
        Console.WriteLine("1. Raw String Literals:");
        
        string json = """
            {
                "name": "Alice",
                "age": 30,
                "city": "New York"
            }
            """;
        Console.WriteLine($"   JSON:\n{json}\n");
        
        string code = """
            public class Example
            {
                public void Method() 
                {
                    Console.WriteLine("Hello!");
                }
            }
            """;
        Console.WriteLine($"   Code:\n{code}\n");
    }
    
    /// <summary>
    /// Required Members - Enforce property initialization
    /// </summary>
    private static void DemonstrateRequiredMembers()
    {
        Console.WriteLine("2. Required Members:");
        
        // Must initialize required properties
        var user = new User 
        { 
            Id = 1, 
            Username = "alice123",
            Email = "alice@example.com"
        };
        Console.WriteLine($"   {user}\n");
    }
    
    /// <summary>
    /// Generic Attributes - Attributes can now be generic
    /// </summary>
    private static void DemonstrateGenericAttributes()
    {
        Console.WriteLine("3. Generic Attributes:");
        Console.WriteLine("   GenericAttributeExample class has TypeId<string> attribute");
        var type = typeof(GenericAttributeExample);
        var attr = type.GetCustomAttributes(typeof(TypeIdAttribute<>), false).FirstOrDefault();
        Console.WriteLine($"   Attribute found: {attr != null}\n");
    }
    
    /// <summary>
    /// UTF-8 String Literals - Direct UTF-8 byte array creation
    /// </summary>
    private static void DemonstrateUtf8StringLiterals()
    {
        Console.WriteLine("4. UTF-8 String Literals:");
        
        ReadOnlySpan<byte> utf8Text = "Hello, UTF-8!"u8;
        Console.WriteLine($"   UTF-8 bytes length: {utf8Text.Length}");
        Console.WriteLine($"   First byte: {utf8Text[0]} ('{(char)utf8Text[0]}')\n");
    }
    
    /// <summary>
    /// List Patterns - Pattern matching on lists and arrays
    /// </summary>
    private static void DemonstrateListPatterns()
    {
        Console.WriteLine("5. List Patterns:");
        
        CheckArray([1, 2, 3]);
        CheckArray([1, 2, 3, 4, 5]);
        CheckArray([1]);
        CheckArray([]);
        Console.WriteLine();
    }
    
    private static void CheckArray(int[] numbers)
    {
        string result = numbers switch
        {
            [] => "Empty array",
            [var single] => $"Single element: {single}",
            [var first, var second, var third] => $"Three elements: {first}, {second}, {third}",
            [var first, .., var last] => $"First: {first}, Last: {last}",
            _ => "Other"
        };
        Console.WriteLine($"   {result}");
    }
    
    /// <summary>
    /// Newlines in String Interpolation - Break long interpolated strings
    /// </summary>
    private static void DemonstrateNewlinesInStringInterpolation()
    {
        Console.WriteLine("6. Newlines in String Interpolation:");
        
        var person = new { FirstName = "John", LastName = "Doe", Age = 35 };
        string message = $"Person: {
            person.FirstName
        } {
            person.LastName
        }, Age: {
            person.Age
        }";
        Console.WriteLine($"   {message}\n");
    }
}

// Required members example
public class User
{
    public required int Id { get; init; }
    public required string Username { get; init; }
    public required string Email { get; init; }
    public string? PhoneNumber { get; init; }
    
    public override string ToString() => 
        $"User #{Id}: {Username} ({Email})";
}

// Generic attribute
[AttributeUsage(AttributeTargets.Class)]
public class TypeIdAttribute<T> : Attribute
{
    public Type Type { get; } = typeof(T);
}

// Example class with generic attribute
[TypeId<string>]
public class GenericAttributeExample
{
}
