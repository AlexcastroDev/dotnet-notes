# Partial class

A Partial class in C# is a class that can be split into two or more classes. The Partial modifier is used to create a partial class. We can create a class in two or more files using the partial keyword.

Examples:

```csharp
// File1.cs
partial class MyClass
{
    public void Method1()
    {
        Console.WriteLine("Method1");
    }
}

// File2.cs
partial class MyClass
{
    public void Method2()
    {
        Console.WriteLine("Method2");
    }
}
```
