using System;

namespace Consoleapp14
{
    class Program
    {
        static void Main(string[] args)
        {
            Cicle();
            Console.Read();
        }

        static void Cicle()
        {
            int x,y;
            for (x = 1; x <= 4; x++)
            {
                for (y = 1; y <= 7; y++)
                {
                    Console.Write("#");
                }
                Console.WriteLine(" ");
                Console.WriteLine(" ");
            }
        }
    }
}
