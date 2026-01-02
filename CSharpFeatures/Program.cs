using CSharpFeatures.Features;

Console.WriteLine("╔════════════════════════════════════════════════════════════════╗");
Console.WriteLine("║        C# Latest Features Demonstration                        ║");
Console.WriteLine("║        C# 10, 11, and 12 Features                             ║");
Console.WriteLine("╚════════════════════════════════════════════════════════════════╝");
Console.WriteLine();

try
{
    // Demonstrate C# 12 Features
    CSharp12Features.DemonstrateAll();
    
    Console.WriteLine("════════════════════════════════════════════════════════════════\n");
    
    // Demonstrate C# 11 Features
    CSharp11Features.DemonstrateAll();
    
    Console.WriteLine("════════════════════════════════════════════════════════════════\n");
    
    // Demonstrate C# 10 Features
    CSharp10Features.DemonstrateAll();
    
    Console.WriteLine("════════════════════════════════════════════════════════════════");
    Console.WriteLine("\n✓ All features demonstrated successfully!");
    Console.WriteLine("\nFor detailed documentation, see FEATURES.md");
}
catch (Exception ex)
{
    Console.WriteLine($"\n✗ Error: {ex.Message}");
    Console.WriteLine(ex.StackTrace);
    return 1;
}

return 0;

