using System;

namespace Opgaver_GeneriskTerning
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }

    public abstract class Terning
    {
        private static System.Random rnd = new Random();
        public int Værdi { get; private set; }
        public void Ryst()
        {
            Værdi = rnd.Next(1, 7);
        }
        public override string ToString()
        {
            return "[" + this.Værdi + "]";
        }
    }

    public class YatzyTerning : Terning
    {
        public YatzyTerning()
        {
            this.Ryst();
        }
    }
    public class LudoTerning : Terning
    {
        public override string ToString()
        {
            if (this.ErStjerne())
                return "[S]";
            if (this.ErGlobus())
                return "[G]";
            return base.ToString();
        }

        public LudoTerning()
        {
            this.Ryst();
        }

        public bool ErStjerne()
        {
            return this.Værdi == 5;
        }
        public bool ErGlobus()
        {
            return this.Værdi == 3;
        }
    }
}
