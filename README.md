# C# Playground - Latest Features

This repository demonstrates the latest features in C# (versions 10, 11, and 12).

## Latest C# Features Overview

### C# 12 Features (Released with .NET 8)
- **Primary Constructors** - Simplified constructor syntax for classes and structs
- **Collection Expressions** - Concise syntax for creating collections with `[...]`
- **Inline Arrays** - Stack-allocated fixed-size arrays
- **Optional Parameters in Lambda Expressions** - Default values for lambda parameters
- **Ref Readonly Parameters** - Pass by reference without allowing modification
- **Alias Any Type** - Use `using` alias for any type including tuples and arrays
- **Experimental Attribute** - Mark APIs as experimental

### C# 11 Features (Released with .NET 7)
- **Raw String Literals** - Multi-line strings with `"""` syntax
- **Required Members** - Enforce property initialization with `required` keyword
- **Generic Attributes** - Attributes can be generic
- **UTF-8 String Literals** - `u8` suffix for UTF-8 byte arrays
- **Pattern Matching Enhancements** - List patterns
- **File-Scoped Types** - Types visible only in the declaring file
- **Auto-Default Structs** - Automatic initialization of struct fields
- **Newlines in String Interpolation** - Break interpolated strings across lines

### C# 10 Features (Released with .NET 6)
- **Global Using Directives** - Import namespaces for entire project
- **File-Scoped Namespaces** - Reduce indentation with `namespace X;`
- **Record Structs** - Value type records
- **Constant Interpolated Strings** - String interpolation in const
- **Extended Property Patterns** - Nested property matching
- **Lambda Improvements** - Natural type for lambdas, explicit return types
- **CallerArgumentExpression** - Capture argument expressions

## Project Structure

```
CSharpFeatures/
├── CSharpFeatures.csproj
├── Program.cs
├── Features/
│   ├── CSharp12Features.cs
│   ├── CSharp11Features.cs
│   └── CSharp10Features.cs
└── FEATURES.md (detailed documentation)
```

## Running the Examples

```bash
cd CSharpFeatures
dotnet run
```

## Requirements

- .NET 8.0 SDK or later
- C# 12 compiler support