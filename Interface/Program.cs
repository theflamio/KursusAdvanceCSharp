using System;

namespace InterfaceTest
{
    class Program
    {
        static void Main(string[] args)
        {
            /* opgave 110-1 eget interface */
            IDbFunktioner[] ar = new IDbFunktioner[4];
            ar[0] = new Hund();
            ar[1] = new Ubåd();
            ar[2] = new Ubåd();
            ar[3] = new Ubåd();

            foreach (var item in ar)
            {
                item.Gem();
            }
        }
    }
    class Hund : IDbFunktioner
    {

        public string Navn { get; set; }

        public void Gem()
        {
            Console.WriteLine("Gemmer Hund");
        }
    }

    class Ubåd : IDbFunktioner
    {

        public int Nummer { get; set; }
        public double Tubine { get; set; }

        public void Gem()
        {
            Console.WriteLine("Gemmer Ubåd");
        }
    }

    interface IDbFunktioner
    {
        void Gem();
    }
}
