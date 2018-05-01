using System;


namespace CsharpTutorial
{
    class Program
    {
        static int Main(string[] args)
        {
         

            DumpEnv(args);

            return 0;
        }

        private static void DumpEnv(string[] someargs)
        {
            Console.WriteLine("Hello {0} {1}", someargs[0], someargs[1]);
            string[] MyArgs = Environment.GetCommandLineArgs();

            Console.WriteLine(string.Join(",   ", MyArgs));
        }
    }
}
