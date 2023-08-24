# Introduction

## Memory Heap

- The memory heap is a region of memory that is used for dynamic memory allocation.
- It is a large region of memory that is shared by all threads in the application.
- It is managed by the CLR.
- It is used to store objects.
- It is also known as the managed heap.


## Stack

- The stack is a region of memory that is used for static memory allocation.
- It is a small region of memory that is used to store local variables and parameters.
- It is managed by the CLR.
- It is used to store value types.
- It is also known as the managed stack.

## Garbage Collector

- The garbage collector is a service that automatically manages the allocation and release of memory for your application.

- This is done by:
    - Tracking objects that are no longer being used by the application.
    - Reclaiming the memory that was allocated to those objects.
    - Making the memory available for future allocations.

- The garbage collector is a part of the CLR.

# Value types

- Also known as built-in types.
- Structs and Enums are also value types.
- Garbage collector does not access the stack.
- When assign a value type to another variable, the value is copied.

Examples

```csharp
int x = 25;
int y = x; // Copy the value of x to y
Console.WriteLine(x); // 25
Console.WriteLine(y); // 25

x = 30;
Console.WriteLine(x); // 30
Console.WriteLine(y); // 25
```

# Reference types

- Also known as complex types.
- Does not store the value itself, but a reference to a memory location.
- The garbage collector can access the heap.
- When assign a variable:
    - The reference is created
    - The pointer is the same
    - It's not independent

- Classes, Objects, arrays...


Examples

```csharp
int[] x = new int[1] { 25 };
int[] y = x; // Copy the reference of x to y

Console.WriteLine(x[0]); // 25
Console.WriteLine(y[0]); // 25

x[0] = 30;
Console.WriteLine(x[0]); // 30
Console.WriteLine(y[0]); // 30
```