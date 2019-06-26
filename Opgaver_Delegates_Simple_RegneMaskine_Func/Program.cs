using System;

namespace Opgaver_Delegates_Simple_RegneMaskine_Func
{
    class Program
    {
        static void Main(string[] args)
        {
            int res = beregner(1, 1, plus); // lægger sammen
            console.writeline(res);
            res = beregner(1, 1, minus);	// trækker fra
            console.writeline(res);
            res = beregner(10, 2, divider); // lægger sammen
            console.writeline(res);
            res = beregner(5, 5, gange);	// trækker fra
            console.writeline(res);

            //var f = FindTilfældigFunktion();
            //int res4 = f(5, 5);
            //Console.WriteLine(res4);
        }

        //private static Beregn FindTilfældigFunktion()
        //{
        //    Random rnd = new Random();
        //    int funcNumber = rnd.Next(1, 5);

        //    switch (funcNumber)
        //    {
        //        case 1:
        //            return Plus;
        //            break;
        //        case 2:
        //            return Minus;
        //            break;
        //        case 3:
        //            return Divider;
        //            break;
        //        case 4:
        //            return Gange;
        //            break;
        //        default:
        //            return Plus;
        //            break;
        //    }
        //}

        public static int Plus(int a, int b)
        {
            return a + b;
        }
        public static int Minus(int a, int b)
        {
            return a - b;
        }

        public static int Divider(int a, int b)
        {
            return a / b;
        }

        public static int Gange(int a, int b)
        {
            return a * b;
        }

        public static int Beregner(int a, int b, Func<int,int,int> b1)
        {
            return b1(a, b);
        }
    }
}
