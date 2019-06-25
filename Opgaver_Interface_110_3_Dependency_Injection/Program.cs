using System;

namespace Opgaver_Interface_110_3_Dependency_Injection
{
    class Program
    {
        static void Main(string[] args)
        {
            ITilfældighedsGenerator m = new TilfældighedsGeneratorMock(3);
            Console.WriteLine(m.FindTalTilTerning());
            ITilfældighedsGenerator f = new TilfældighedsGeneratorFramework();
            Console.WriteLine(f.FindTalTilTerning());
        }        
    }

    interface ITilfældighedsGenerator
    {
        int FindTalTilTerning();
    }

    class TilfældighedsGeneratorFramework : ITilfældighedsGenerator
    {
        private static Random rand = new Random();

        public int FindTalTilTerning()
        {
            
            return rand.Next(1, 6);
        }
    }

    class TilfældighedsGeneratorMock : ITilfældighedsGenerator
    {
        private int _tal;

        public TilfældighedsGeneratorMock(int tal)
        {
            _tal = tal;
        }
        private int tal;


        public int FindTalTilTerning()
        {

            if ((_tal >= 1) && (_tal <= 6))
            {
                return _tal;
            }
            Console.WriteLine("Number has to be between 1 and 6: returning 1");
            return 1;
        }
    }
}
