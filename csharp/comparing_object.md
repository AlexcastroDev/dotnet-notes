# Comparing objects

You can compare objects using the `Equals` method, but you can also use the `==` operator.

The better way is using IEquateable interface.

```csharp
public class Person : IEquatable<Person>
{
    public string Name { get; set; }

    public Person(string name)
    {
        Name = name;
    }
}
```