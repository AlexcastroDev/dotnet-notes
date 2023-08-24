using Models;

BaseModel bm = new()
{
    Id = 1
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



Console.WriteLine(bm.Id);
