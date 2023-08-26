namespace ProjectOne
{

    public class Acessors : IDisposable
    {
        public int MyProperty = 0;

        public void Dispose()
        {
            Console.WriteLine("End of Acessors");
        }
    }


    public class Payment : IPayment
    {
        public int MyProperty { get; set; }
    }
    public interface IPayment
    {
        int MyProperty { get; set; }
    }
}