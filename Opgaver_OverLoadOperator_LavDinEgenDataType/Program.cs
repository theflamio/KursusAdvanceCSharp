using System;

namespace Opgaver_OverLoadOperator_LavDinEgenDataType
{
    class Program
    {
        static void Main(string[] args)
        {
            byte a = 8;
            Nibble n1 = new Nibble(a);
            Console.WriteLine(n1.Value);

            int b = 8;
            Nibble n2 = new Nibble(b);
            Console.WriteLine(n2.Value);

            string c = "1000";
            Nibble n3 = new Nibble(c);
            Console.WriteLine(n3.Value);

            Nibble n4 = new Nibble("0000");
            n4 = a;
            n4 = b;
            n4 = c;
            Console.WriteLine(n4.Value);

            byte d = n4;
            Console.WriteLine(d);
            int e = n4;
            Console.WriteLine(e);
            string f = n4;
            Console.WriteLine(f);

            Nibble n5 = new Nibble(8);
            Nibble n6 = new Nibble(9);
            Console.WriteLine(n5 > n6);
            Console.WriteLine(n5 < n6);
            Console.WriteLine(n5 == n6);
            Console.WriteLine(n5 != n6);
        }
    }

    class Nibble
    {
        private byte value;

        public readonly int Value;

        public Nibble(byte b)
        {
            CheckValue(b);            
        }

        public Nibble(int i)
        {

        }

        public Nibble(string s)
        {

        }

        public static implicit operator string(Nibble n)
        {
            value = n.value;
            return n.Navn;
        }

        public static bool operator >(Nibble p1, Nibble p2)
        {
            if (p1.value > p2.value)
                return true;
            return false;
        }

        public static bool operator <(Nibble p1, Nibble p2)
        {
            if (p1.value < p2.value)
                return true;
            return false;
        }

        public static bool operator ==(Nibble p1, Nibble p2)=> (p1.value == p2.value) && (p1.value == p2.value);

        public static bool operator !=(Nibble p1, Nibble p2)=> !(p1 == p2);


        public void CheckValue(int value)
        {
            if (15 < value || value < 0)
            {
                throw new Exception("value is not in range of 4 bit");
            }
        }
    }    
}
