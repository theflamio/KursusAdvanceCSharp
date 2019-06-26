using System;

namespace Opgaver_Events_KreditMax
{
    class Program
    {
        
        static void Main(string[] args)
        {
            Kunde k = new Kunde() { KreditMax = -500 };
            k.KreditOverskredet += (s, e) => {
                Console.WriteLine("Kredit overskredet");
            };
            k.Køb(100);
            k.Køb(600);	// Her skal metoden bundet til KreditOverskredet blive kaldt automatisk
        }
    }
    public class Kunde
    {
        public event EventHandler KreditOverskredet;
        // event mangler
        public string Navn { get; set; }
        public int Saldo { get; set; }
        public int KreditMax { get; set; }
        public void Køb(int værdi)
        {
            Console.WriteLine("Kunde {0} køber for {1}", Navn, værdi);
            this.Saldo -= værdi;
            if (Saldo < KreditMax)
            {
                // kald til event mangler
                KreditOverskredet?.Invoke(this, new EventArgs());                
            }
        }
    }
}
