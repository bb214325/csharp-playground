# C# Playground

A personal learning repository showcasing the latest features of C# from versions 10 through 13.

## Overview

This project demonstrates modern C# language features introduced in recent versions:
- **C# 13** (Released with .NET 10, November 2024) - Latest features
- **C# 12** (Released with .NET 8, November 2023)
- **C# 11** (Released with .NET 7, November 2022)
- **C# 10** (Released with .NET 6, November 2021)

## Requirements

- .NET 10 SDK or later
- Any IDE or text editor (Visual Studio, VS Code, Rider, etc.)

## Getting Started

### Build and Run

```bash
cd CSharpPlayground
dotnet build
dotnet run
```

## Features Demonstrated

### C# 13 Features
- **params Collections** - Use params with any collection type (Span, IEnumerable, etc.)
- **New Escape Sequence (\e)** - Simplified ANSI escape codes
- **Lock Object Improvements** - Enhanced System.Threading.Lock type

### C# 12 Features
- **Primary Constructors** - Constructor parameters in class declaration
- **Collection Expressions** - Concise collection initialization with `[]`
- **Inline Arrays** - Fixed-size arrays as struct fields
- **Default Lambda Parameters** - Default values in lambda expressions
- **Alias Any Type** - using aliases for tuples, pointers, and more

### C# 11 Features
- **Raw String Literals** - Multi-line strings with `"""` delimiters
- **Required Members** - Enforce property initialization
- **List Patterns** - Pattern matching for lists and arrays
- **Generic Attributes** - Attributes with generic type parameters
- **UTF-8 String Literals** - Direct UTF-8 byte sequences with `u8` suffix
- **Span Pattern Matching** - Pattern match on ReadOnlySpan<char>

### C# 10 Features
- **File-scoped Namespaces** - Reduce indentation with single-line namespace
- **Global Using Directives** - Apply using statements project-wide
- **Record Structs** - Value-type records with immutability
- **Constant Interpolated Strings** - Use interpolation in const declarations
- **Extended Property Patterns** - Simplified nested property matching
- **Lambda Improvements** - Natural types and explicit return types
- **Caller Argument Expression** - Capture argument expressions at compile time

## Project Structure

```
CSharpPlayground/
├── Program.cs              # Main entry point with feature demos
├── CSharp13Features.cs     # C# 13 feature examples
├── CSharp12Features.cs     # C# 12 feature examples
├── CSharp11Features.cs     # C# 11 feature examples
├── CSharp10Features.cs     # C# 10 feature examples
└── CSharpPlayground.csproj # Project configuration
```

## Learning Resources

- [What's New in C# 13](https://learn.microsoft.com/en-us/dotnet/csharp/whats-new/csharp-13)
- [What's New in C# 12](https://learn.microsoft.com/en-us/dotnet/csharp/whats-new/csharp-12)
- [What's New in C# 11](https://learn.microsoft.com/en-us/dotnet/csharp/whats-new/csharp-11)
- [What's New in C# 10](https://learn.microsoft.com/en-us/dotnet/csharp/whats-new/csharp-10)

## License

This is a personal learning project - feel free to use and learn from it!