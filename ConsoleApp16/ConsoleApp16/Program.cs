using System;

class program
{
    static void Main(string[] args)
    {
        Cicle();
        Console.Read();
    }

    static void Cicle()
    {
        int x = 8;
        for (int y = 0; y <= x; y++)
        {
            Console.Write(new string(' ', y));
            Console.WriteLine("#");
        }
    }
}