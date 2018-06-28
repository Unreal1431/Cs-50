using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication25
{
    class Program
    {
    
        static void Main(string[] args)
        {
            int piramyd = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i <= piramyd; i++)
            {

                Console.Write(new string(' ', piramyd - i));
                Console.Write(new string('*', i));
                Console.Write(' ');
                Console.Write(new string('*', i));
                Console.WriteLine();
            }

            Console.ReadKey();
        }

    }
}
