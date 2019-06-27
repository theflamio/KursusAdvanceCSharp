using System;
using System.Linq;

namespace Opgaver_Leg_Med_LINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\nSorter og udskriv efter navn og udskriv igen\n");

            var people = MCronberg.PersonRepositoryStatic.JustGetPeople().OrderBy(i => i.Name);
            foreach (var person in people)
                Console.WriteLine(person.Name);

            Console.WriteLine("\nSorter og udskriv efter gender og så navn\n");

            var people1 = MCronberg.PersonRepositoryStatic.JustGetPeople().OrderBy(i => i.Gender).ThenBy(i => i.Name);
            foreach (var person in people1)
                Console.WriteLine($"{person.Name} {person.Gender}");

            Console.WriteLine("\nFiltre og udskriv således, at der kun vises personer hvor height < 170\n");

            var people2 = MCronberg.PersonRepositoryStatic.JustGetPeople().Where(i => i.Height < 170);
            foreach (var person in people2)
                Console.WriteLine($"{person.Name} {person.Height}");

            Console.WriteLine("\nFiltre og udskriv således, at der kun vises personer hvor height = < 170, isHealthy = true\n");

            var people3 = MCronberg.PersonRepositoryStatic.JustGetPeople().Where(i => i.Height < 170).Where(i => i.IsHealthy = true);
            foreach (var person in people3)
                Console.WriteLine($"{person.Name} {person.IsHealthy}");

            Console.WriteLine("\nGruppér efter gender og udskriv hver gruppe (husk – der er tale om tilfældige navn/gender mv)\n");

            var people4 = MCronberg.PersonRepositoryStatic.JustGetPeople().GroupBy(i => i.Gender);
            foreach (var person in people4)
            {
                Console.WriteLine($"\n{person.Key}\n");
                foreach (var pers in person)
                {
                    Console.WriteLine($"\t{pers.Name.PadRight(20)} {pers.Gender}");
                }
            }               

            Console.WriteLine("\nSorter og udskriv navn – men der skal kun returneres et anonymt objekt med navn og height\n");

            var people5 = MCronberg.PersonRepositoryStatic.JustGetPeople().OrderBy(i => i.Name).Select(i => new { Navn = i.Name, Højde = i.Height });
            foreach (var person in people5)
            {
                Console.WriteLine($"{person.Navn} {person.Højde}");
            }

            Console.WriteLine("\nGrupper og sorter efter height således, at der skabes grupper fra 160-170, 170-180, 180-190, 190-200, 200-210. Den svær .. kig i løsningen og søg evt på nettet.\n");

            int[] range = { 160, 170, 180, 190, 200, 210 };
            var people6 = MCronberg.PersonRepositoryStatic.JustGetPeople().OrderBy(i => i.Height).GroupBy(i => range.FirstOrDefault(x => x > i.Height));
            foreach (var person in people6)
            {
                Console.WriteLine($"\n{person.Key}\n");
                foreach (var pers in person)
                {
                    Console.WriteLine($"\t{pers.Name.PadRight(20)} {pers.Height}");
                }
                
            }

            Console.WriteLine("\nGrupper og sorter efter height således, at der skabes grupper fra 160-170, 170-180, 180-190, 190-200, 200-210. Den svær .. kig i løsningen og søg evt på nettet.\n");

            var people7 = MCronberg.PersonRepositoryStatic.JustGetPeople().OrderBy(i => i.Height).Select(i => new {navn = i.Name , højde = i.Height, højdegruppe = i.Height / 10 }).GroupBy(i => i.højdegruppe);
            foreach (var person in people7)
            {
                Console.WriteLine($"\n{person.Key}0 {person.Key}9\n");
                foreach (var pers in person)
                {
                    Console.WriteLine($"\t{pers.navn.PadRight(20)} {pers.højde}");
                }

            }

            Console.WriteLine();
        }
    }
}
