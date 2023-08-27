# Introduction to Lists in C#

## What is a list?

A list is a collection of objects, and it can be used to store a list of objects of the same type.

## How to create a list?

```csharp
List<string> names = new List<string>();
```

All List are IEnumerable or IList, so you can use foreach to iterate over the list.

```csharp
foreach (string name in names)
{
    Console.WriteLine(name);
}
```

To create a list of Payments:

```csharp
IList<Payment> payments = new List<Payment>();
payments.Add(new Payment());
```


## How to add items to a list?

```csharp
names.Add("Maria");
names.Add("Alex");
names.Add("Bob");
names.Add("Anna");
```

## How to add items to a list in a specific position?

```csharp
names.Insert(2, "Marco");
```

## How to find the first or last position of an item in a list?

```csharp
int pos1 = names.FindIndex(x => x[0] == 'A');
int pos2 = names.FindLastIndex(x => x[0] == 'A');
```

## How to find the first or last item in a list?

```csharp
string first = names.Find(x => x[0] == 'A');
string last = names.FindLast(x => x[0] == 'A');
```

## How to find all items in a list?

```csharp
List<string> list = names.FindAll(x => x.Length == 5);
```

## How to remove an item from a list?

```csharp
names.Remove("Alex");
```

## How to remove an item from a specific position in a list?

```csharp
names.RemoveAt(3);
```

## How to remove all items from a list?

```csharp
names.Clear();
```

## How to find the size of a list?

```csharp
int size = names.Count;
```

