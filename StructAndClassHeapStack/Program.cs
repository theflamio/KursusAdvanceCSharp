using System;

namespace StructAndClassHeapStack
{
    class Program
    {
        static void Main(string[] args)
        {
            Person k1 = new Person();
            Person k2 = new Person();
            k1.Id = 1;
            k2.Id = 2;
            Console.WriteLine($"k1 Id = {k1.Id} k2 Id ={k2.Id}\n");
            k1 = k2;
            Console.WriteLine($"k1 = k2: k1 Id = {k1.Id} k2 Id ={k2.Id}\n");
            k1.Id = 3;
            Console.WriteLine($"k1.Id = 3: k1 Id = {k1.Id} k2 Id ={k2.Id}\n");

            Console.WriteLine("Den skriver at K1 har id værdi 3 og k2 har id værdi 2 " +
                "dette kan lade sig gøre da structs er værdibaseret i stack hukommelsen" +
                " og der bliver hukommelsen først slettet når vi går ud af score\n");

            myPerson p1 = new myPerson();
            myPerson p2 = new myPerson();
            p1.Id = 1;
            p1.Id = 2;
            Console.WriteLine($"p1 Id = {p1.Id} k2 Id ={p2.Id}\n");
            p1 = p2;
            Console.WriteLine($"p1 = p2: p1 Id = {p1.Id} p2 Id ={p2.Id}\n");
            p1.Id = 3;
            Console.WriteLine($"p1.Id = 3: p1 Id = {p1.Id} p2 Id ={p2.Id}\n");

            Console.WriteLine("Classes er reference baserset dvs, i det øjeblik at p1 peger på p2 så forsvinder p1 objektet" +
                " da garbage collectoren ser at der ikke længere er nogen refernce til objektet også bliver den fjernet!\n");

         }
    }

    class myPerson
    {
        public int Id;
    }

    public struct Person
    {
        public int Id;   
    }

}
