using System;
using System.Text;

namespace Opgave_Simple_Variabler2
{
    class Program
    {
        static void Main(string[] args)
        {
            /* DateTime*/

            //DateTime d1 = DateTime.Now;
            //Console.WriteLine($"Maskine tid nu {d1}\n");
            //d1.AddDays(10);
            //Console.WriteLine($"Maskine tid nu {d1}\n");
            //d1.AddMinutes(20);
            //Console.WriteLine($"Maskine tid nu {d1}\n");
            //d1.AddMonths(-1);
            //Console.WriteLine($"Maskine tid nu {d1}\n");
            //DateTime d2 = new DateTime(2019, 6, 1);
            //DateTime d3 = new DateTime(2019, 7, 1);
            //Console.WriteLine($"d3 = {d3} d2 = {d2}\n");
            //TimeSpan t1 = d3.Subtract(d2);
            //Console.WriteLine($"d3 - d2:  d3 = {t1.Days}\n");

            //TimeSpan t2 = new TimeSpan(16, 0, 0);
            //Console.WriteLine($"t2 hours = {t2}\n");

            //TimeSpan t3 = new TimeSpan(0, 30, 0);
            //Console.WriteLine($"t3 = {t3}\n");

            //TimeSpan t4 = new TimeSpan();
            //t4 = t2.Subtract(t3);
            //Console.WriteLine($"t4 = t2 - t3 = {t4}\n");

            //TimeSpan t5 = new TimeSpan();
            //t5 = t2.Add(t3);
            //Console.WriteLine($"t5 = t2 + t3 = {t5}\n");

            /* Brug af stenge */

            StringBuilder sb = new StringBuilder("");

            string forNavn = "Malte";
            string efterNavn = "Løkke";
            string samletNavn = "";
            string storNavn = "";
            string lilleNavn = "";
            string delNavn = "";

            samletNavn = forNavn + " " + efterNavn;
            Console.WriteLine(samletNavn);
            lilleNavn = samletNavn.ToLower();
            Console.WriteLine(lilleNavn);
            storNavn = samletNavn.ToUpper();
            Console.WriteLine(storNavn);
            delNavn = samletNavn.Substring(6, 5);
            Console.WriteLine(delNavn);




        }
    }
}
