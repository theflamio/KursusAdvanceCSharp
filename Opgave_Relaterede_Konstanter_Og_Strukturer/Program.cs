using System;

namespace Opgave_Relaterede_Konstanter_Og_Strukturer
{
    class Program
    {
        static void Main(string[] args)
        {
            card s1 = new card();
            s1.cardValue = 2;
            s1.colour = colour.Pikes;
            Console.WriteLine($"{s1.colour} {s1.cardValue}");

            card s2 = new card();
            s2.cardValue = 10;
            s2.colour = colour.Hearts;
            Console.WriteLine($"{s2.colour} {s2.cardValue}");
        }
    }

    public enum colour
    {
        Hearts,
        Pikes,
        Tiles,
        Clovers
    }

    public struct card
    {
        public int cardValue;

        public colour colour;
    }
}
