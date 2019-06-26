using System;

namespace Opgaver_Events_eventtargets_kreditMax
{
    class Program
    {
        static void Main(string[] args)
        {
            Kunde k = new Kunde() { KreditMax = -500 };
            k.KreditOverskredet += (s, e) => {
                Console.WriteLine($"Kredit overskredet - saldo = {e.saldo:N2}");
            };
            k.Køb(100);
            k.Køb(600);	// Her skal metoden bundet til KreditOverskredet blive kaldt automatisk
        }
    }

    public class Kunde
    {
        public event EventHandler<KreditOverskredetEventArgs> KreditOverskredet;
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
                if (KreditOverskredet != null)
                {
                    KreditOverskredet(this, new KreditOverskredetEventArgs() {saldo = Saldo});
                    // kald til event manglers
                    Console.r
                }
            }
        }
    }
    public class KreditOverskredetEventArgs : EventArgs
    {      
        public int saldo { get; set; }
    }
}
