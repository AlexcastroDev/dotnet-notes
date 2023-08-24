# Introduction

## What is a namespace?

A namespace is a way to organize code in a logical manner. It is a collection of classes, interfaces, structs, enums and delegates. It is a way to group related code together.

## Why use namespaces?

Namespaces are used to organize code in a logical manner. It is a way to group related code together. 

## How to use namespaces?

I created a simple BaseModel, that you can find in main/examples/ProjectOne/Models/BaseModel.cs

So, in the Program.cs file, I can use the BaseModel like this:

```csharp
using Models; // This is the namespace

BaseModel bm = new()
{
    Id = 1
};

Console.WriteLine(bm.Id);
``````

Why not new BaseModel()?

Because I am using C# 9.0, and I can use the new feature Target-typed new expressions. You can find more information about this feature in the [Microsoft Docs](https://docs.microsoft.com/en-us/dotnet/csharp/whats-new/csharp-9#target-typed-new-expressions).