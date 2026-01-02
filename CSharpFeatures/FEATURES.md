# C# Latest Features - Detailed Documentation

This document provides detailed explanations of the latest features in C# versions 10, 11, and 12.

## Table of Contents
- [C# 12 Features (.NET 8)](#c-12-features-net-8)
- [C# 11 Features (.NET 7)](#c-11-features-net-7)
- [C# 10 Features (.NET 6)](#c-10-features-net-6)

---

## C# 12 Features (.NET 8)

Released in November 2023 with .NET 8, C# 12 brings powerful features for cleaner, more expressive code.

### 1. Primary Constructors

Primary constructors allow you to define constructor parameters directly in the class or struct declaration, eliminating boilerplate code.

**Benefits:**
- Reduces code verbosity
- Makes intent clearer
- Available for both classes and structs

**Example:**
```csharp
// Before C# 12
public class Person
{
    private readonly string _name;
    private readonly int _age;
    
    public Person(string name, int age)
    {
        _name = name;
        _age = age;
    }
}

// With C# 12
public class Person(string name, int age)
{
    public string Name { get; } = name;
    public int Age { get; } = age;
}
```

### 2. Collection Expressions

Collection expressions provide a concise syntax for creating and initializing collections using `[...]` syntax.

**Benefits:**
- Consistent syntax across collection types
- Spread operator support with `..`
- More readable code

**Example:**
```csharp
// Create arrays
int[] numbers = [1, 2, 3, 4, 5];

// Create lists
List<string> names = ["Alice", "Bob", "Charlie"];

// Spread operator
int[] more = [..numbers, 6, 7, 8];

// Combining collections
string[] all = [..names, "David", "Eve"];
```

### 3. Ref Readonly Parameters

Pass large structs by reference without allowing modifications, improving performance while maintaining safety.

**Benefits:**
- Performance optimization for large value types
- Prevents accidental modifications
- Clear intent

**Example:**
```csharp
public readonly struct LargeData
{
    public int[] Values { get; init; }
}

public int Process(ref readonly LargeData data)
{
    // Can read but cannot modify
    return data.Values.Sum();
}
```

### 4. Alias Any Type

Use `using` directives to create aliases for any type, including tuples, arrays, and pointers.

**Benefits:**
- Improves code readability
- Works with complex types
- Simplifies long type names

**Example:**
```csharp
using Coordinate = (double Latitude, double Longitude);
using IntArray = int[];
using Matrix = double[][];

Coordinate location = (40.7128, -74.0060);
IntArray numbers = [1, 2, 3, 4, 5];
```

### 5. Default Lambda Parameters

Lambda expressions can now have default parameter values, just like regular methods.

**Benefits:**
- More flexible lambda expressions
- Reduces overload need
- Familiar syntax

**Example:**
```csharp
var greet = (string name = "Guest") => $"Hello, {name}!";
Console.WriteLine(greet());        // Hello, Guest!
Console.WriteLine(greet("Alice")); // Hello, Alice!
```

---

## C# 11 Features (.NET 7)

Released in November 2022 with .NET 7, C# 11 focuses on improved string handling and pattern matching.

### 1. Raw String Literals

Multi-line string literals with `"""` syntax that preserve formatting and don't require escaping.

**Benefits:**
- No escape sequences needed
- Preserves formatting
- Perfect for JSON, XML, SQL
- Interpolation support

**Example:**
```csharp
string json = """
    {
        "name": "Alice",
        "age": 30,
        "city": "New York"
    }
    """;
    
string sql = """
    SELECT id, name, email
    FROM users
    WHERE active = true
    """;
```

### 2. Required Members

Force object initializer to set specific properties with the `required` keyword.

**Benefits:**
- Compile-time safety
- Explicit initialization requirements
- Better API design

**Example:**
```csharp
public class User
{
    public required int Id { get; init; }
    public required string Username { get; init; }
    public required string Email { get; init; }
    public string? PhoneNumber { get; init; } // Optional
}

// Must initialize all required properties
var user = new User 
{ 
    Id = 1, 
    Username = "alice",
    Email = "alice@example.com" 
};
```

### 3. Generic Attributes

Attributes can now be generic, allowing type-safe metadata.

**Benefits:**
- Type-safe attribute parameters
- Reduces code duplication
- Better tooling support

**Example:**
```csharp
[AttributeUsage(AttributeTargets.Class)]
public class TypeIdAttribute<T> : Attribute
{
    public Type Type { get; } = typeof(T);
}

[TypeId<string>]
public class MyClass { }
```

### 4. UTF-8 String Literals

Create UTF-8 byte arrays directly with the `u8` suffix.

**Benefits:**
- More efficient for UTF-8 scenarios
- No runtime conversion needed
- Direct `ReadOnlySpan<byte>` creation

**Example:**
```csharp
ReadOnlySpan<byte> utf8 = "Hello, UTF-8!"u8;
byte[] bytes = "Another example"u8.ToArray();
```

### 5. List Patterns

Pattern matching on lists and arrays with support for slices and ranges.

**Benefits:**
- Expressive sequence matching
- Supports any enumerable
- Slice patterns with `..`

**Example:**
```csharp
int[] numbers = [1, 2, 3, 4, 5];

string result = numbers switch
{
    [] => "Empty",
    [var single] => $"One: {single}",
    [var first, var second] => $"Two: {first}, {second}",
    [var first, .., var last] => $"Many: {first}...{last}",
    _ => "Other"
};
```

### 6. Newlines in String Interpolation

Break long interpolated strings across multiple lines for better readability.

**Benefits:**
- Improves code formatting
- Better readability
- No runtime impact

**Example:**
```csharp
var person = GetPerson();
string message = $"Name: {
    person.FirstName
} {
    person.LastName
}, Age: {
    person.Age
}";
```

---

## C# 10 Features (.NET 6)

Released in November 2021 with .NET 6, C# 10 introduced significant improvements for cleaner code.

### 1. Global Using Directives

Import namespaces once for the entire project with `global using`.

**Benefits:**
- Reduces repetitive using statements
- Cleaner files
- Central management

**Example:**
```csharp
// In GlobalUsings.cs or any .cs file
global using System;
global using System.Collections.Generic;
global using System.Linq;
global using System.Text;

// Available in all files in the project
```

### 2. File-Scoped Namespaces

Declare namespace for entire file with reduced indentation using `namespace Name;`.

**Benefits:**
- One less indentation level
- Cleaner, more readable code
- Modern style

**Example:**
```csharp
// Before C# 10
namespace MyApp.Services
{
    public class MyService
    {
        // Code
    }
}

// With C# 10
namespace MyApp.Services;

public class MyService
{
    // Code - one less indent level
}
```

### 3. Record Structs

Value-type records with value equality and immutability support.

**Benefits:**
- Value semantics
- Equality comparison by value
- `with` expressions
- Performance (stack allocation)

**Example:**
```csharp
public record struct Point(int X, int Y);

var p1 = new Point(10, 20);
var p2 = new Point(10, 20);
Console.WriteLine(p1 == p2); // True - value equality

var p3 = p1 with { Y = 30 }; // Non-destructive mutation
```

### 4. Constant Interpolated Strings

Use string interpolation in `const` declarations when all parts are constant.

**Benefits:**
- Cleaner constant definitions
- Compile-time evaluation
- Better readability

**Example:**
```csharp
const string FirstName = "John";
const string LastName = "Doe";
const string FullName = $"{FirstName} {LastName}";
```

### 5. Extended Property Patterns

Access nested properties directly in pattern matching.

**Benefits:**
- More concise patterns
- Better readability
- Deep property access

**Example:**
```csharp
public record Order(Customer Customer, decimal Amount);
public record Customer(string Name, Address Address);
public record Address(string City, string State);

string result = order switch
{
    { Customer.Address.State: "NY", Amount: > 100 } => "NY Big Order",
    { Customer.Address.State: "CA" } => "California Order",
    _ => "Other"
};
```

### 6. Lambda Improvements

Natural type inference and explicit return types for lambda expressions.

**Benefits:**
- Better type inference
- Can declare lambda variables with `var`
- Explicit return types possible
- Attributes on lambda parameters

**Example:**
```csharp
// Natural type inference
var parse = (string s) => int.Parse(s);

// Explicit return type
var multiply = int (int x, int y) => x * y;

// Attributes
var validate = ([NotNull] string input) => input.ToUpper();
```

### 7. CallerArgumentExpression

Capture the expression passed as an argument, useful for validation and diagnostics.

**Benefits:**
- Better error messages
- Improved debugging
- Cleaner assertion methods

**Example:**
```csharp
public void Assert(
    bool condition,
    [CallerArgumentExpression(nameof(condition))] string? expr = null)
{
    if (!condition)
        throw new ArgumentException($"Assertion failed: {expr}");
}

// Usage
Assert(value > 0); // Error message includes "value > 0"
```

---

## Summary

C# continues to evolve with features that make code more concise, readable, and maintainable:

- **C# 12** focuses on syntax improvements (primary constructors, collection expressions)
- **C# 11** enhances string handling and pattern matching
- **C# 10** reduces boilerplate and improves code organization

These features work together to create a modern, expressive language that balances power with simplicity.

## Resources

- [Official C# Documentation](https://docs.microsoft.com/en-us/dotnet/csharp/)
- [What's new in C# 12](https://docs.microsoft.com/en-us/dotnet/csharp/whats-new/csharp-12)
- [What's new in C# 11](https://docs.microsoft.com/en-us/dotnet/csharp/whats-new/csharp-11)
- [What's new in C# 10](https://docs.microsoft.com/en-us/dotnet/csharp/whats-new/csharp-10)
