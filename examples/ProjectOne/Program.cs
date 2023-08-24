using Models;
using DatetimeTest;
using Money;

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
Monetize money = new(10.25m);

Console.WriteLine(bm.Id);
Console.WriteLine(DatetimeBolado.UTC());
Console.WriteLine(DatetimeBolado.GetDate());
DateTime dt1 = DateTime.Now;
Console.WriteLine(DatetimeBolado.FormatDate(dt1));
Console.WriteLine(money.ToString());

var ListOfChars = new List<char> { 'a', 'b', 'c', 'd', 'e' };
var ListOfInts = new List<int> { 1, 2, 3, 4, 5 };

ListOfChars.ForEach(Console.WriteLine);
ListOfInts.ForEach(Console.WriteLine);

var ListOfStrings = new List<string> { "a", "b", "c", "d", "e" };

ListOfStrings[0] = "A";
ListOfStrings[1] = "B";
ListOfStrings[2] = "C";
ListOfStrings[3] = "D";
ListOfStrings[4] = "E";

ListOfStrings.ForEach(Console.WriteLine);

ListOfStrings.ForEach((string s) => {
    Console.WriteLine(s);
    Console.WriteLine(s);
});

var first = new int[5];
var second = new int[5];

first[0] = 1;
second[0] = 2;

Console.WriteLine(first[0]); // 1
Console.WriteLine(second[0]); // 2
Console.WriteLine("--------------");

first[0] = second[0]; // set 1 => 2

second[0] = 3; // set 2 => 3

Console.WriteLine(first[0]); // 2
Console.WriteLine(second[0]); // 3
Console.WriteLine("--------------");

first.CopyTo(second, 0); // set 3 => 2 (first)

Console.WriteLine(first[0]); // 2
Console.WriteLine(second[0]); // 2
Console.WriteLine("--------------");

first[0] = 4; // set 2 => 4 (first)

Console.WriteLine(first[0]); // 4
Console.WriteLine(second[0]); // 2


try {
    first[10] = 1;
} catch {
    Console.WriteLine("Error");
}