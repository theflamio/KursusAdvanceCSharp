using System;
using System.Threading;
using System.Threading.Tasks;

namespace Opgaver_Async
{
    class Program
    {
        static async Task Main(string[] args)
        {
            System.Diagnostics.Stopwatch s = new System.Diagnostics.Stopwatch();
            s.Start();
            Console.WriteLine("Start");

            Task t1 = Task.Run(() =>
            {
                Console.WriteLine("Sleep");
                Thread.Sleep(500);
            });

            Task t2 = Task.Run(() =>
            {
                Console.WriteLine("Sleep");
                Thread.Sleep(500);
            });

            Task t3 = Task.Run(() =>
            {
                Console.WriteLine("Sleep");
                Thread.Sleep(500);
            });

            await Task.WhenAll(t1, t2, t3);
            Console.WriteLine("Slut");
            s.Stop();
            Console.WriteLine($"Tid: {s.ElapsedMilliseconds}");
        }
    }
}
