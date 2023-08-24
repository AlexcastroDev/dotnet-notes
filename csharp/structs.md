# Introduction

The Struct definition are:

- Structure Data type
- Just a scructure
- A value type
- Store just the type value
- Create from new keyword

Example
    
```csharp
struct Person
{
    public string Name;
    public int Age;
}

Person person = new Person();
person.Name = "John";
person.Age = 30;
```

or

```csharp

Person person = new()
{
    Name = "John",
    Age = 30
};
```

## The anatomy of a struct

```csharp

struct Product
{
    public string Id;
    public float Price;

    public float PriceInDolar(float dolar) {
        return Price * dolar;
    }
}


Product product = new()
{
    Id = "1",
    Price = 10
};
```

## Method constructor

```csharp

struct Product
{
    public Product(string id, string Title, float price) {
        Id = id;
        Title = title;
        Price = price;
    }
}

Product product = new("1", "Product 1", 10);
```