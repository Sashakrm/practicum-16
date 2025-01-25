using System;

namespace ConsoleApp13
{
    class Programm
    {
        static void Main(string[] args)
        {
            Cicle();
            Console.Read();
        }

        static void Cicle()
        {
            for (int x = 1; x <= 5; x++)
            {
                for (int y = 5; y >= x; y--)
                {
                        Console.Write("1 ");
                
                }
                Console.WriteLine(" ");
            }
        }
    }
}

