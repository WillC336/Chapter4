using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int y = 1; y <= 10; y++)
            {
                for (int x = 1; x <= 10; x++)
                {
                    Console.Write(y * x + "\t");
                }
                Console.Write("\n");
            }

            Console.ReadLine();
        }
    }
}
