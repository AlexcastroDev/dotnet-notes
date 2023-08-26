# Introduction

This repository is a collection of notes about .NET and C# language.

I did not take not about everything, because I already know some things, but I took notes about the things that I did not know, I had doubts or i dont want to forget.



## .NET

### [Enviroment](./NET/enviroment.md)
### [Project Types](./NET/projects_types.md)
### [Projects Structure](./NET/projects_structure.md)

## C# Language

### [Namespaces](./csharp/namespace.md)
### [Using](./csharp/using.md)
### [Variables, Parse and Conversion](./csharp/variables.md)
### [Structs](./csharp/structs.md)
### [Acessors](./csharp/acessors.md)
### [Method Overloading](./csharp/method_overloading.md.md)

# C# and POO

The paradigms of programming and Object Oriented Programming contents will not be covered here, because I already know them.

# Objects

Here i can see that the objects are instances of classes, and the classes are the blueprints of the objects.

- Properties
- Methods
- Constructors
- Events

# Classes and objects

You can find some examples in `examples` folder.

# Others contents

I will skip notes about the following contents, because I already know them.

- Encapsulation
- Abstraction
- Inheritance
- Polymorphism



- Complex types
- Properties
- Methods
- Using and Dispose
- Static classes
- Interfaces
- Abstract classes
- Comparing objects
- Delegates
- Events
- Generics
- Lists

- Upcast and Downcast

Upcast is when you cast a derived class to a base class.

Downcast is when you cast a base class to a derived class.

Example of upcast is on `/examples/ProjectOne/Upcast.cs` and the example of downcast is on `/examples/ProjectOne/Downcast.cs`


- Sealed classes

dont allow to inherit from them

example:

```csharp
sealed class MyClass
{
    // Class members here.
}
```

- Partial class

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

- Access modifiers

We have private, protected, internal and public

private and public are very common.

Protected is used when you want to use the class only in the same assembly or in a derived class.

The internal is used when you want to use the class only in the same assembly.

# References

https://web.archive.org/web/20130305112130/http://msdn.microsoft.com/en-us/library/7c5ka91b(v=vs.80).aspx