using System;
using System.Collections;
using System.Collections.Generic;

namespace Opgaver_Generisk_klasse
{
    class Program
    {
        static void Main(string[] args)
        {

            Personer1 p1 = new Personer1(); // tager imod alt sålænge det er noget der er nedarvet fra person
            p1.TilFøjperson(new Kursist());
            p1.TilFøjperson(new Instruktør());
            p1.TilFøjperson(new Hund());

            Personer2<Person> p2 = new Personer2<Person>();// tager imod alt ! som er nedarvet fra person
            p2.TilFøjperson(new Kursist());
            p2.TilFøjperson(new Instruktør());
            p2.TilFøjperson(new Hund());

            Personer2<Kursist> p3 = new Personer2<Kursist>();// tager imod alt ! som er nedarvet fra person
            p3.TilFøjperson(new Kursist());
            p3.TilFøjperson(new Instruktør());
            p3.TilFøjperson(new Hund());

            Personer3<Kursist> p4 = new Personer3<Kursist>();
            p4.TilFøjperson(new Kursist());//sikkere sig at det rigtige objekt kommer over
            p4.TilFøjperson(new Instruktør());
            p4.TilFøjperson(new Hund());

            Personer3<Instruktør> p5 = new Personer3<Instruktør>();
            p5.TilFøjperson(new Kursist());
            p5.TilFøjperson(new Instruktør());//sikkere sig at det rigtige objekt kommer over
            p5.TilFøjperson(new Hund());
        }
    }

    class Person{ }

    class Instruktør : Person { }

    class Kursist : Person { }

    class Personer1 
    {
        public Personer1()
        {
            p = new List<Person>();
        }
        private List<Person> p;


        public void TilFøjperson(Person person)
        {
            p.Add(person);
        }
    }

    class Personer2<T>
    {
        private List<T> p;
        public Personer2()
        {
            p = new List<T>();
        }

        public void TilFøjperson(T t)
        {
            p.Add(t);
        }

    }

    class Personer3<T> where T : Person 
    {
        private List<T> p;
        public Personer3()
        {
            p = new List<T>();
        }

        public void TilFøjperson(T t)
        {
            p.Add(t);
        }

    }

    class Personer4<T> where T : Instruktør

    {
        private List<T> p;
        public Personer4()
        {
            p = new List<T>();
        }

        public void TilFøjperson(T t)
        {
            p.Add(t);
        }

    }

    class Hund
    {

    }
}
