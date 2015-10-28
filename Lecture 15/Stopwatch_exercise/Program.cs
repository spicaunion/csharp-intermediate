using System;
using System.Threading;

namespace Stopwatch_exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            var sw = new Stopwatch();
            sw.Start();
            Thread.Sleep(3000);
            Console.WriteLine(sw.Duration.TotalSeconds);
            Thread.Sleep(2000);
            sw.Stop();
            Console.WriteLine(sw.Duration.TotalSeconds);
            Console.ReadKey();
        }
    }
}
