using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class Programa
{
    static void Main(string[] args)
    {
        for (int i = 1; i < 100; i++)
        {
            if (i % 3 == 0)
            {
                Console.WriteLine("primeiro: " + i);
            }
        }

        for (int x = 3; x < 100; x += 3)
        {
            Console.WriteLine("segundo: " + x);
        }
        Console.ReadLine();
    }
}