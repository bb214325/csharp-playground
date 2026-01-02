namespace CSharpPlayground.Features;

/// <summary>
/// C# 11 Features (Released with .NET 7 in November 2022)
/// </summary>
public class CSharp11Features
{
    /// <summary>
    /// Feature: Raw String Literals
    /// Multi-line strings with """ delimiters, no escape sequences needed
    /// </summary>
    public static void RawStringLiteralsExample()
    {
        Console.WriteLine("\n=== C# 11: Raw String Literals ===");
        
        // Single-line raw string
        string singleLine = """This is a "raw" string with "quotes"!""";
        Console.WriteLine(singleLine);
        
        // Multi-line raw string with proper indentation
        string json = """
            {
                "name": "Alice",
                "age": 30,
                "city": "Seattle"
            }
            """;
        Console.WriteLine("JSON:");
        Console.WriteLine(json);
        
        // Raw string interpolation
        string name = "Bob";
        int age = 25;
        string interpolated = $$"""
            Person Info:
            Name: {{name}}
            Age: {{age}}
            """;
        Console.WriteLine(interpolated);
    }

    /// <summary>
    /// Feature: Required Members
    /// Properties and fields can be marked as required
    /// </summary>
    public static void RequiredMembersExample()
    {
        Console.WriteLine("\n=== C# 11: Required Members ===");
        
        // This would cause compile error if Name wasn't set:
        // var user = new User { Email = "test@example.com" };
        
        var user = new User 
        { 
            Name = "Alice", 
            Email = "alice@example.com" 
        };
        Console.WriteLine($"User: {user.Name} ({user.Email})");
    }

    /// <summary>
    /// Feature: List Patterns
    /// Pattern matching for lists and arrays
    /// </summary>
    public static void ListPatternsExample()
    {
        Console.WriteLine("\n=== C# 11: List Patterns ===");
        
        CheckArray([1, 2, 3]);
        CheckArray([1, 2, 3, 4, 5]);
        CheckArray([1]);
        CheckArray([]);
    }

    private static void CheckArray(int[] numbers)
    {
        string result = numbers switch
        {
            [] => "Empty array",
            [var single] => $"Single element: {single}",
            [var first, var second, var third] => $"Three elements: {first}, {second}, {third}",
            [var first, .., var last] => $"Multiple elements, first: {first}, last: {last}",
            _ => "Unknown pattern"
        };
        Console.WriteLine(result);
    }

    /// <summary>
    /// Feature: Generic Attributes
    /// Attributes can now be generic
    /// </summary>
    public static void GenericAttributesExample()
    {
        Console.WriteLine("\n=== C# 11: Generic Attributes ===");
        
        var method = typeof(CSharp11Features).GetMethod(nameof(GenericAttributeMethod));
        var attr = method?.GetCustomAttributes(typeof(GenericAttribute<string>), false).FirstOrDefault();
        if (attr is GenericAttribute<string> genericAttr)
        {
            Console.WriteLine($"Attribute value: {genericAttr.Value}");
        }
    }

    [GenericAttribute<string>("test-value")]
    public static void GenericAttributeMethod() { }

    /// <summary>
    /// Feature: UTF-8 String Literals
    /// String literals can be encoded as UTF-8 bytes
    /// </summary>
    public static void Utf8StringLiteralsExample()
    {
        Console.WriteLine("\n=== C# 11: UTF-8 String Literals ===");
        
        ReadOnlySpan<byte> utf8Text = "Hello UTF-8"u8;
        Console.WriteLine($"UTF-8 bytes: {string.Join(" ", utf8Text.ToArray().Select(b => b.ToString("X2")))}");
    }

    /// <summary>
    /// Feature: Pattern Match Span<char> on a constant string
    /// </summary>
    public static void SpanPatternMatchingExample()
    {
        Console.WriteLine("\n=== C# 11: Span Pattern Matching ===");
        
        MatchSpan("hello".AsSpan());
        MatchSpan("world".AsSpan());
        MatchSpan("test".AsSpan());
    }

    private static void MatchSpan(ReadOnlySpan<char> span)
    {
        string result = span switch
        {
            "hello" => "Matched 'hello'",
            "world" => "Matched 'world'",
            _ => "No match"
        };
        Console.WriteLine(result);
    }
}

// Required members example
public class User
{
    public required string Name { get; init; }
    public required string Email { get; init; }
}

// Generic attribute example
[AttributeUsage(AttributeTargets.All)]
public class GenericAttribute<T>(T value) : Attribute
{
    public T Value { get; } = value;
}
