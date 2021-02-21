using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter n: ");
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; ++i)
            {
                for (int j = 0; j < i+1; ++j)
                {
                    for (int k = 0; k < n - j-1; ++k)
                        Console.Write(" ");
                    if (j == 0)
                        Console.Write("*");
                    else
                        for (int l = 0; l < j + j + 1; ++l)
                            Console.Write("*");
                    Console.WriteLine();
                }

            }
        }
    }
}
