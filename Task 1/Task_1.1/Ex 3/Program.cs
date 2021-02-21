using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter n: ");
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; ++i)
            {
                for (int j = 0; j < n - i - 1; ++j)
                    Console.Write(" ");
                if (i == 0)
                     Console.Write("*");
                else
                    for (int k = 0; k < i+i+1; ++k)
                        Console.Write("*");
                Console.WriteLine();
            }
        }
    }
}
