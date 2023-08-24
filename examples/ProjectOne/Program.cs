using Models;
using DatetimeTest;

BaseModel bm = new()
{
    Id = Guid.NewGuid(),
};



// struct Product {
//     public int Id;
//     public string Name;
//     public float Price;

//     public Product(int id, string name, float price) {
//         Id = id;
//         Name = name;
//         Price = price;
//     }

//     public float priceInDolar(float dolar) {
//         return Price * dolar;
//     }
// }

// Product p = new(1, "Product 1", 10.5f);

var dt = new DatetimeBolado();

Console.WriteLine(bm.Id);
Console.WriteLine(DatetimeBolado.UTC());
Console.WriteLine(DatetimeBolado.GetDate());
DateTime dt1 = DateTime.Now;
Console.WriteLine(DatetimeBolado.FormatDate(dt1));
