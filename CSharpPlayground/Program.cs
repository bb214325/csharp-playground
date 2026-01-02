using CSharpPlayground.Features;

Console.WriteLine("╔══════════════════════════════════════════════════════════════╗");
Console.WriteLine("║       Welcome to C# Playground - Latest Features Demo       ║");
Console.WriteLine("║          Demonstrating C# 10, 11, 12, and 13 Features       ║");
Console.WriteLine("╚══════════════════════════════════════════════════════════════╝");

// C# 13 Features (Latest - .NET 10)
Console.WriteLine("\n" + new string('=', 60));
Console.WriteLine("  C# 13 FEATURES (.NET 10 - Latest)");
Console.WriteLine(new string('=', 60));
CSharp13Features.ParamsCollectionsExample();
CSharp13Features.EscapeSequenceExample();
CSharp13Features.LockObjectExample();

// C# 12 Features (.NET 8)
Console.WriteLine("\n" + new string('=', 60));
Console.WriteLine("  C# 12 FEATURES (.NET 8)");
Console.WriteLine(new string('=', 60));
CSharp12Features.PrimaryConstructorsExample();
CSharp12Features.CollectionExpressionsExample();
CSharp12Features.InlineArraysExample();
CSharp12Features.DefaultLambdaParametersExample();
CSharp12Features.AliasAnyTypeExample();

// C# 11 Features (.NET 7)
Console.WriteLine("\n" + new string('=', 60));
Console.WriteLine("  C# 11 FEATURES (.NET 7)");
Console.WriteLine(new string('=', 60));
CSharp11Features.RawStringLiteralsExample();
CSharp11Features.RequiredMembersExample();
CSharp11Features.ListPatternsExample();
CSharp11Features.GenericAttributesExample();
CSharp11Features.Utf8StringLiteralsExample();
CSharp11Features.SpanPatternMatchingExample();

// C# 10 Features (.NET 6)
Console.WriteLine("\n" + new string('=', 60));
Console.WriteLine("  C# 10 FEATURES (.NET 6)");
Console.WriteLine(new string('=', 60));
CSharp10Features.FileScopedNamespacesExample();
CSharp10Features.GlobalUsingExample();
CSharp10Features.RecordStructsExample();
CSharp10Features.ConstantInterpolatedStringsExample();
CSharp10Features.ExtendedPropertyPatternsExample();
CSharp10Features.LambdaImprovementsExample();
CSharp10Features.CallerArgumentExpressionExample();

Console.WriteLine("\n" + new string('=', 60));
Console.WriteLine("  Demo Complete! Happy Learning C#! 🎉");
Console.WriteLine(new string('=', 60));
