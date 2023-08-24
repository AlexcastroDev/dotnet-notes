
namespace Stopwatch {
    class Program {
        static void Main() {
            string timeStr = "10s";
            int time = int.Parse(timeStr[..^1]); // same of timeStr.Substring(0, timeStr.Length - 1)
            Start(time);
        }

        static void Start(int time) {
            int currentTime = 0;
            while (currentTime != time) {
                Console.Clear();
                currentTime++;
                Console.WriteLine(currentTime);

                Thread.Sleep(500);
            }

            Console.Clear();
            Console.WriteLine("Stopwatch ended!");
            Thread.Sleep(1000);
        }
    }
}