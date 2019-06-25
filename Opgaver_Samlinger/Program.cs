using System;
using System.Collections.Generic;

namespace Opgaver_Samlinger
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Lister 97-1 */
            /* https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1?view=netframework-4.8 */

            List<Person> person = new List<Person>();
            person.Add(new Person() {Id = 1, Navn = "Børge"});
            person.Add(new Person() { Id = 2, Navn = "Bent" });
            person.Add(new Person() { Id = 3, Navn = "Bo" });

            foreach (var p in person)
            {
                Console.WriteLine($" ID = {p.Id} NAVN = {p.Navn}");
            }

            /* Stack 97-2 */
            /* https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.stack-1?view=netframework-4.8 */

            Bunke b = new Bunke();
            b.TilføjKort(new Kort() { Kulør = "Spar", Værdi = 2 });
            b.TilføjKort(new Kort() { Kulør = "Hjerter", Værdi = 14 });
            b.TilføjKort(new Kort() { Kulør = "Ruder", Værdi = 3 });
            b.Vis();

            var k = b.FjernKort();
            Console.WriteLine();
            Console.WriteLine(k);
            Console.WriteLine();

            b.Vis();

        }

        class Person
        {
            public int Id { get; set; }
            public string Navn { get; set; }
        }

        public class Kort
        {
            public string Kulør { get; set; }
            public int Værdi { get; set; }
            public override string ToString()
            {
                return this.Kulør + " " + this.Værdi;
            }
        }

        public class Bunke 
        {

            private Stack<Kort> bunke = new Stack<Kort>();

            public void TilføjKort(Kort k)
            {
                bunke.Push(k);
            }

            public void Vis()
            {
                foreach (var item in bunke)
                {
                    Console.WriteLine(item);
                }
            }

            public Kort FjernKort()
            {
                if (bunke.Count > 0)
                {
                    return bunke.Pop();
                }
                return null;
                
            }
        }
    }
}
