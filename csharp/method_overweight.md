# Introduction

In C#, Method overloading allows you to define multiple methods in a class with the same name but different parameter lists. This enables you to provide different ways to call a method based on the input arguments.

```csharp
class Calculator
{
    public int Add(int a, int b)
    {
        return a + b;
    }

    public double Add(double a, double b)
    {
        return a + b;
    }
}
```

In this example, the Calculator class has two Add methods with different parameter types (integers and doubles). Depending on the types of arguments you pass, the appropriate method will be called.

Method overloading is used to improve code readability and provide more convenient ways to work with different data types without needing to come up with unique method names for each variation.

## Why not a only function that receives int or double ?

Readability and Intuitive Usage: Overloaded methods allow you to provide a more intuitive interface to users of your class or API. Users can call the method with the data types they are comfortable with, without needing to explicitly cast or convert their arguments.

Type Safety: By having separate method signatures for int and double arguments, you can catch potential type-related errors at compile time. If you only had one method that accepted a generic numeric type, you might end up with runtime errors due to unintended type conversions.

Avoiding Implicit Conversions: If you had a single method accepting a generic numeric type, the C# compiler might perform implicit conversions between int and double, potentially leading to precision loss or unexpected behavior.

Specific Logic: Sometimes, the logic inside methods might need to differ based on the specific data type being used. For example, calculations involving int values might be faster or have different rounding behavior compared to calculations involving double values.


Imagine this CAOS:

```csharp
class Calculator
{
    public double Add(object a, object b)
    {
        if (a is int intA && b is int intB)
        {
            return intA + intB;
        }

        if (a is double doubleA && b is double doubleB)
        {
            return doubleA + doubleB;
        }

        throw new ArgumentException("Unsupported argument types");
    }
}
```

This is a bad practice, because you are using a lot of if's and you are not using the power of the language.

## Overloading Constructors

You can also overload constructors in the same way as methods. This allows you to provide different ways to initialize an object based on the input arguments.

```csharp
class Person
{
    public string Name { get; set; }
    public int Age { get; set; }

    public Person(string name)
    {
        Name = name;
    }

    public Person(string name, int age)
    {
        Name = name;
        Age = age;
    }
}
```

In this example, the Person class has two constructors with different parameter lists. Depending on the arguments you pass, the appropriate constructor will be called.

## Overloading Operators

You can also overload operators in the same way as methods. This allows you to provide custom implementations for operators such as +, -, *, /, and so on.

```csharp

class Vector
{
    public int X { get; set; }
    public int Y { get; set; }

    public Vector(int x, int y)
    {
        X = x;
        Y = y;
    }

    public static Vector operator +(Vector a, Vector b)
    {
        return new Vector(a.X + b.X, a.Y + b.Y);
    }
}
```

In this example, the Vector class overloads the + operator to add two vectors together. This allows you to use the + operator to add two Vector objects.

```csharp
var a = new Vector(1, 2);
var b = new Vector(3, 4);
var c = a + b;
```

## Overloading Indexers

You can also overload indexers in the same way as methods. This allows you to provide different ways to access elements in a class based on the input arguments.

```csharp
class Vector
{
    public int X { get; set; }
    public int Y { get; set; }

    public Vector(int x, int y)
    {
        X = x;
        Y = y;
    }

    public int this[int i]
    {
        get
        {
            if (i == 0)
            {
                return X;
            }
            else if (i == 1)
            {
                return Y;
            }
            else
            {
                throw new IndexOutOfRangeException();
            }
        }
        set
        {
            if (i == 0)
            {
                X = value;
            }
            else if (i == 1)
            {
                Y = value;
            }
            else
            {
                throw new IndexOutOfRangeException();
            }
        }
    }
}
```

In this example, the Vector class overloads the indexer to allow you to access the X and Y properties using the indexer syntax.

```csharp
var vector = new Vector(1, 2);

Console.WriteLine(vector[0]); // 1
Console.WriteLine(vector[1]); // 2

vector[0] = 3;
vector[1] = 4;

Console.WriteLine(vector[0]); // 3
Console.WriteLine(vector[1]); // 4
```