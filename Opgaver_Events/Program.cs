using System;

namespace Opgaver_Events
{
    class Program
    {
        static void Main(string[] args)
        {
            System.IO.FileSystemWatcher w = new System.IO.FileSystemWatcher(@"c:\temp", "*.txt");
            w.EnableRaisingEvents = true;
            // bind en metode til w.Changed

            w.Created += (s, e) => Console.WriteLine("Fil oprettet");
            w.Deleted += (s, e) => Console.WriteLine("Fil Deleted");
            w.Changed += (s, e) => Console.WriteLine("Fil Changed");

            do {} while (true);
        }
    }
}
