using System;

namespace Nullable_Metoder
{
    class Program
    {
        // Mulighed for at værdibaserede variabler kan få værdien null

        static void Main(string[] args)
        {
            int val = 1;
            Console.WriteLine($"{HentFraDb(val)}\n");
            val = 2;
            Console.WriteLine($"{HentFraDb(val)}\n");
            val = 3;
            Console.WriteLine($"{HentFraDb(val)}\n");
        }

        static bool? HentFraDb(int value)
        {
            if(value == 1)
            {
                return true;
            }
            else if (value == 2)
            {
                return false;
            }
            return null;            
        }        
    }
}
