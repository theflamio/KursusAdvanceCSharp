using System;
using System.Collections;
using System.Collections.Generic;

namespace Opgaver_AdvanceType_400_3
{
    class Program
    {
        /* Icomparable interface https://docs.microsoft.com/en-us/dotnet/api/system.icomparable?view=netframework-4.8 */
        /* IEnumerable interface https://docs.microsoft.com/en-us/dotnet/api/system.collections.ienumerable?view=netframework-4.8 */
        static void Main(string[] args)
        {
            Garage g = new Garage();
            g.BilInd(new Bil() { Model = "a", Mærke = "x", NummerPlade = "xx", Årgang = 2000 });
            g.BilInd(new Bil() { Model = "b", Mærke = "y", NummerPlade = "yy", Årgang = 2019 });
            g.BilInd(new Bil() { Model = "c", Mærke = "z", NummerPlade = "ww", Årgang = 1978 });
            foreach (var item in g)
                Console.WriteLine(item);
            g.Sorter();
            foreach (var item in g)
                Console.WriteLine(item);
            Console.WriteLine();
            var b = g.BilUd("ww");
            Console.WriteLine(b);
            Console.WriteLine();
            foreach (var item in g)
                Console.WriteLine(item);
        }
    }
    /* IEnumerable gør der muligt at kører en foreach over et object som indeholder en lister */
    class Garage : IEnumerable<Bil>
    {
        private List<Bil> _biler;

        public Garage()
        {
            _biler = new List<Bil>();
        }

        public void BilInd(Bil b)
        {
            _biler.Add(b);
        }

        public Bil BilUd(string nummerPlade)
        {
            /* Lampda udtryk https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/statements-expressions-operators/lambda-expressions */
            Bil b = _biler.Find(i => i.NummerPlade == nummerPlade);

            if (b == null)

                throw new ApplicationException("Bil findes ikke");

            _biler.Remove(b);

            return b;
        }
        
        public IEnumerator<Bil> GetEnumerator()
        {
            return ((IEnumerable<Bil>)_biler).GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return ((IEnumerable<Bil>)_biler).GetEnumerator();
        }

        public void Sorter()

        {
            _biler.Sort();
        }
    }
    /* IComparable gør der muligt at samligne 2 forskellige referancers data af samme klasse */
    class Bil : IComparable<Bil>
    {
        public string Mærke { get; set; }

        public string Model { get; set; }

        public int Årgang { get; set; }

        public string NummerPlade { get; set; }
        
        public int CompareTo(Bil other)
        {
            return this.Årgang.CompareTo(other.Årgang);
        }

        public override string ToString()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this);
        }
    }
}
