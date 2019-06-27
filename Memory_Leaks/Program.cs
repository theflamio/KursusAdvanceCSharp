using System;
using System.Collections.Generic;

namespace Memory_Leaks
{
    class Program
    {
        /* 
         * Brug visual studios indbygget memory snaps shot og se om du kan se hvad der skaber problemet.
         */

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
            }
        }
    }

    class MinApp
    {
        public event EventHandler Hjerteslag;
        public void OpretObjekt()
        {
            var o = new MitObjekt(this);
            o = null;
        }

        public void Tick()
        {
            if (Hjerteslag != null)
                Hjerteslag(this, new EventArgs());
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

        ~MitObjekt()
        {
            this.mor.Hjerteslag -= SkrivTick;
        }

    }

}
