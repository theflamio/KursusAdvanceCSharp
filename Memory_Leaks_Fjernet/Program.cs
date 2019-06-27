using System;
using System.Collections.Generic;

namespace Memory_Leaks_Fjernet
{
    class Program
    {
        static void Main(string[] args)
        {
            MinApp app = new MinApp();

            for (int x = 0; x < 100; x++)
            {
                for (int i = 0; i < 10000; i++)
                {
                    app.OpretObjekt();
                }
                System.Threading.Thread.Sleep(200);
                app.FjernReferencer();
            }
        }
    }

    class MinApp
    {

        public event EventHandler Hjerteslag;
        public List<MitObjekt> lst = new List<MitObjekt>();
        public void OpretObjekt()
        {
            lst.Add(new MitObjekt(this));
        }

        public void Tick()
        {
            if (Hjerteslag != null)
                Hjerteslag(this, new EventArgs());
        }

        public void FjernReferencer()
        {
            foreach (var item in lst)
            {
                item.FjernEvent();
            }
        }

    }

    class MitObjekt
    {

        private MinApp mor;
        public MitObjekt(MinApp mor)
        {
            this.mor = mor;
            this.mor.Hjerteslag += SkrivTick;
        }

        private void SkrivTick(object s, EventArgs e)
        {
            Console.WriteLine("Tick");
        }

        public void FjernEvent()
        {
            this.mor.Hjerteslag -= SkrivTick;
        }

    }

}
