# Introduction

## What is a using?

The using directive allows you to use types defined in a namespace without specifying the fully qualified namespace of that type. 

In its basic form, the using directive imports all the types from a single namespace, as shown in the following example:

```csharp
using System;
```

or

```csharp
using System.Collections.Generic; // this is needed to use List<T>

class Program {
    static void Main(string[] args) {
        List<int> numbers = new();
        numbers.Add(1);
        numbers.Add(2);
        numbers.Add(3);
        numbers.Add(4);
        numbers.Add(5);

        foreach (int number in numbers) {
            Console.WriteLine(number);
        }
    }
}
```



# References

https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/using-directive