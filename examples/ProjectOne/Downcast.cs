class ProgramDowncast
{
    static void Main(string[] args)
    {
        Animal animal = new()
        {
            Name = "Rex"
        };

        Dog dog = (Dog)animal; // Downcast

        dog.Bark(); // Bark!
    }
}