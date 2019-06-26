using System;

namespace Opgaver_Delegates
{
    public delegate void MinDelegate(string txt);

    class Program
    {
        static void Main(string[] args)
        {
            MinDelegate d1 = new MinDelegate(MinSkrivTilConsole);

            d1.Invoke("Hello");
            d1("World");
            d1("Delegates");
        }

        static void MinSkrivTilConsole(string txt)
        {
            Console.WriteLine("**** " + txt + " ****");
        }
    }

    
}
