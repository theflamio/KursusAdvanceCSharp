using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace Opgaver_Samlinger_fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {


            Stopwatch sw1 = new Stopwatch();
            Stopwatch sw2 = new Stopwatch();

            sw1.Start();
            foreach (var item in Fibinacci(10000))
            {
                Console.WriteLine(item);
            }
            sw1.Stop();
            sw2.Start();
            foreach (var item in FibonacciYield(10000))
            {
                Console.WriteLine(item);
            }
            sw2.Stop();
            Console.WriteLine($" without yield = {sw1.Elapsed} with yield = {sw2.Elapsed}");
        }

        static IEnumerable<int> Fibinacci(int count)
        {
            List<int> fibonacciNumbers = new List<int>();

            int previous = 0;
            int next = 1;
            
            for (int i = 0; i <count; i++)
			{
                fibonacciNumbers.Add(previous);
                int res = previous  + next;
                previous = next;
                next = res;
            }      
            return fibonacciNumbers;
        }

        static IEnumerable<int> FibonacciYield(int count)
        {
            int previous = 0;
            int next = 1;

            for (int i = 0; i < count; i++)
            {
                int res = previous + next;
                yield return previous;
                previous = next;
                next = res;                
            }
        }
    }    
}
