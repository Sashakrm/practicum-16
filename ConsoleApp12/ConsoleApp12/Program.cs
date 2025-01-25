using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp12
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
            int a = 5;
            for (int x = 1; x <= 5; x++)
            {
                for (int y = 1; y <= x; y++)
                {
                    Console.Write("5 ");
                }
                Console.WriteLine(" ");
            }
        }
    }
}