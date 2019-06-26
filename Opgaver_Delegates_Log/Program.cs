using System;

namespace Opgaver_Delegates_Log
{
    public delegate void LogDelegate(string txt);
    class Program
    {
        static void Main(string[] args)
        {
            Machine m = new Machine();
            m.Log = Console.WriteLine;
            m.Log += AppendLog;
            m.Start();
            m.Stop();


            Console.WriteLine();

            Machine2 m2 = new Machine2();
            m2.Log = Console.WriteLine;
            m2.Log += AppendLog;
            m2.Start();
            m2.Stop();
        }

        static void AppendLog(string txt)
        {
            System.IO.File.AppendAllText(@"c:\log.txt", txt + "\r\n");
        }
    }

    class Machine
    {
        public LogDelegate Log { get; set; }

        public void Start()
        {
            Log?.Invoke(DateTime.Now.ToLongTimeString() + " Starter");
        }

        public void Stop()
        {
            Log?.Invoke(DateTime.Now.ToLongTimeString() + " Stopper");
        }
    }

    /*   Ved anvendelse af action må der ikke være en retur værdi og man slipper for at skulle lave en new som i delegate   */
    class Machine2
    {
        // Action (void)
        // Func (retur)
        // Predicate bool(T)

        public Action<string> Log { get; set; }

        public void Start()
        {
            Log?.Invoke(DateTime.Now.ToLongTimeString() + " Starter");
        }

        public void Stop()
        {
            Log?.Invoke(DateTime.Now.ToLongTimeString() + " Stopper");
        }
    }
}
