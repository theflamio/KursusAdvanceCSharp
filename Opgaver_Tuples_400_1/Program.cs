using System;

namespace Opgaver_Tuples_400_1
{
    class Program
    {
        static void Main(string[] args)
        {
            /* System.ValueTuple ligger på stakken mens System.Tuple gemmes på heapen 
               det betyder at man kun kan ændre i værdierne på den tuple der gemmes på stakken og det er værd at tænke over !!! */

            (double sum, double gns) resultat = FindSumOgGsn(25, 4);
            Console.WriteLine($"Sum: {resultat.sum:n2}");
            Console.WriteLine($"Gns: {resultat.gns:n2}");
        }

        static (double Sum,double Gsn) FindSumOgGsn(double first, double second)
        {
            double sum = first + second;
            double gsn = (first + second) / 2;
            return (sum,gsn);
        }
    }
}
