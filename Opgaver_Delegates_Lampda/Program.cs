using System;
using System.Collections.Generic;

namespace Opgaver_Delegates_Lampda
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> a = new List<int>() { 5, 1, 51, 7, 1, 56, 36, 5 };

            /* forloop der skriver hvert element ud af listen */
            for (int i = 0; i < a.Count; i++)
            {
                Console.WriteLine(a[i]);
            }

            Console.WriteLine();

            foreach (var item in a)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine();

            a.ForEach((int i) => { Console.WriteLine(i);});

            Console.WriteLine();

            a.ForEach(i => Console.WriteLine(i));

            /* mest formateret sukker lampda der laver det samme som forloopet */

            Console.WriteLine();

            var res = FindIndexValue(51,a);
            Console.WriteLine(res);

            Console.WriteLine();

            var res2 = FindeValue(51);
            Console.WriteLine(res2);

            Console.WriteLine();

            Console.WriteLine(a.FindIndex((int i) => { return i == 51; }));

            Console.WriteLine();

            var res3 = a.FindIndex(i => i == 51);
            Console.WriteLine(res3);
        }

        public static int FindIndexValue(int tal, List<int> li)
        {
            foreach (var item in li)
            {
                if (item.Equals(tal))
                {
                    return li.IndexOf(item);
                }                
            }
            return 99;
        }

        public static bool FindeValue(int val)
        {
            return val == 51;
        }
    }
}
