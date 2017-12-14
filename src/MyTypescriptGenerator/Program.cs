using System;

namespace MyTypescriptGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args[0] != null)
                Console.WriteLine(args[0]);

            if (args[1] != null)
                Console.WriteLine(args[1]);
        }
    }
}
