﻿using System;
using System.Collections.Generic;

namespace Opgaver_GeneriskTyperOgMedlemmer_170_2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> lst1 = new List<int>() { 5, 1, 41, 5, 21, 2, 61, 5 };
            List<char> lst2 = new List<char>() { 'b', 'c', 'h', 'r' };
            List<string> lst3 = new List<string>() { "a", "", "c" };
            List<Hund> lst4 = new List<Hund>() { new Hund { AntalBen = 4, Navn = "F" }, new Hund { AntalBen = 3, Navn = "A" } };

            // Generisk

            Console.WriteLine(AntalMax(lst1, 20));

            Console.WriteLine(AntalMax(lst2, 'h'));

            Console.WriteLine(AntalMax(lst3, "b"));

            Console.WriteLine(AntalMax(lst4, new Hund { Navn = "A" }));
        }

        static int AntalMax<T>( IEnumerable<T> liste, T maxVærdi) where T : IComparable<T>
        {
            int antal = 0;
            foreach (T t in liste)
            {
                if (t.CompareTo(maxVærdi) > 0)
                    antal++;
            }
            return antal;
        }
    }
    class Hund : IComparable<Hund>
    {
        public int AntalBen { get; internal set; }
        public string Navn { get; internal set; }

        public int CompareTo(Hund other)
        {
            return this.Navn.CompareTo(other.Navn);
        }
    }

}
