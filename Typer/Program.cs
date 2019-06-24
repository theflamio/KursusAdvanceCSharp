using System;

namespace Typer
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime a = DateTime.Now; // instance member

            DateTime.DaysInMonth(2018, 10);// statisk member

            int x = 233;

            Convert.ToInt32(x); // converter til given type og laver fejl håndtering hvis typen man converter ikke kan være i den type man vil convertere over til! 

        }
    }
}
