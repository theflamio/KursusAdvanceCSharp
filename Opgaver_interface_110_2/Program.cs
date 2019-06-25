using System;

namespace Opgaver_interface_110_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Hund[] hunde = new Hund[4];
            hunde[0] = new Hund() { Alder = 10, Navn = "Bulder" };
            hunde[1] = new Hund() { Alder = 5, Navn = "Lady" };
            hunde[2] = new Hund() { Alder = 7, Navn = "Andy" };
            hunde[3] = new Hund() { Alder = 3, Navn = "Rolf" };
            Array.Sort(hunde);
            foreach (var item in hunde)
            {
                Console.WriteLine(item.Navn);
            }
        }

        class Hund : IComparable<Hund>
        {
            public string Navn { get; set; }
            public int Alder { get; set; }

            public int CompareTo(Hund other)
            {
                // Samligne referancen af navnet her med en anden
                return this.Navn.CompareTo(other.Navn);
            }
        }
    }
}
