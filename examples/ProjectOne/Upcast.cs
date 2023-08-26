class Animal
{
    public string Name { get; set; }
}

class Dog : Animal
{
    public void Bark()
    {
        Console.WriteLine("Bark!");
    }
}

class ProgramUpcast
{
    static void Main(string[] args)
    {
        Dog dog = new()
        {
            Name = "Rex"
        };

        Animal animal = dog; // Upcast

        Console.WriteLine(animal.Name); // Rex
    }
}