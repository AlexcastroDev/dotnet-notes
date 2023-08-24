namespace Calculator
{
    class Program
    {
        static void Main()
        {
            // Start the program with Clear();
            Console.Clear();
            Console.WriteLine("Welcome Hell Yeaah!");

            OpenMenu();
        }

        static void OpenMenu() {
            Console.Clear();
            Console.WriteLine("What you want?");
            Console.WriteLine("1 - Sum");
            Console.WriteLine("2 - Subtraction");
            Console.WriteLine("3 - Multiplication");
            Console.WriteLine("4 - Division");
            Console.WriteLine("0 - Exit");

            Console.WriteLine("----------");

            Console.WriteLine("Select:");
            short res = short.Parse(Console.ReadLine() ?? "0");

            switch (res) {
                case 0: System.Environment.Exit(0); break;
                case 1: Sum(); break;
                default: OpenMenu(); break;
            }
        }

        static void Sum() {
            Console.WriteLine("Please enter your first number:");
            float firstNumber = float.Parse(Console.ReadLine() ?? "0");

            Console.WriteLine("Please enter your second number:");
            float secondNumber = float.Parse(Console.ReadLine() ?? "0");

            float result = firstNumber + secondNumber;
            Console.WriteLine($"The result is {result}");

            Console.ReadKey();
            OpenMenu();
        }
    }
}