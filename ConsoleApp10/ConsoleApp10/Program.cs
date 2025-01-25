using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp10
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
            for (int x = 1; x <= 4; x++)
            {
                for (int a = 1; a <= 10; a++)
                {
                    Console.Write($"{a} ");
                }
                Console.WriteLine(" ");
            }
        }
    }
}
