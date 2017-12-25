using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace Pyramid
{

    class Program
    {
        static void pyramid(int n)
        {
           
            for (int z = 1; z < n; z++)
            Console.Write(" ");
            Console.Write("*");
            Console.WriteLine("");
            if (n > 1)
                for (int i = 1; i < n; i++)
                {
                    for (int j = i + 1; j < n; j++)
                    {
                        Console.Write(" ");
                    }
                    for (int k = n - i; k < n; k++)
                    {
                        Console.Write("*");
                    }
                    Console.Write(" ");
                    for (int k = n - i; k < n; k++)
                    {
                        Console.Write("*");
                    }
                    Console.WriteLine("");
                }
        }
        static void Main(string[] args)
        {
            int write = 1;
            while (write != 0)
            {
                write = int.Parse(Console.ReadLine());
                pyramid(write);
            }
        }
    }
}