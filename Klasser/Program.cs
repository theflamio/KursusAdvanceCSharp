using System;

namespace Klasser
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }

    class myClass
    {
        // key propfull
        private int myVar;

        public int MyProperty
        {
            get { return myVar; }
            set { myVar = value; }
        }

        // key prop
        public int myProperty { get; private set; } = 10;

        // key ctor

        // default constructor
        public myClass()
        {

        }

        //custom constructor
        public myClass(int arg) : this(arg,"tom")
        {
            //tager imod et argument
        }

        // hoved custom construtor
        public myClass(int arg, string name)
        {
            //tager imod et argument
        }
    }

}
