﻿using System;
using System.Collections.Generic;
using System.Linq;
using myEx;

namespace Opgaver_LINQ_Med_Custom_Extensions
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> lst1 = new List<int>() { 5, 4, 2, 3, 7, 10, 2 };
            foreach (var item in lst1.HverAnden())
                Console.WriteLine(item);
            Console.WriteLine();

            // Oprindelig Where
            var res = lst1.Where(i => i < 5).Take(2);
            foreach (var item in res)
            {
                Console.WriteLine(item);
            }
            // Overload Where
            foreach (var item in lst1.Where(i => i < 5, 2))
            {
                Console.WriteLine(item);
            }         
        }        
    }  
}

namespace myEx
{
    public static class Ex
    {
        public static IEnumerable<T> HverAnden<T>(this IEnumerable<T> source)
        {
            return source.Where((Value,Index) => Index % 2 == 0);
        }

        public static IEnumerable<T> Where<T>(this IEnumerable<T> source, Func<T, bool> where, int take)
        {
            return source.Where(where).Take(take);
        }
    }
}
