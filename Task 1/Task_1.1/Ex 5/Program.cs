using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_5
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            int j = 3, k = 5;
            while (j < 1000)
            {
                if (j % 5 != 0)
                    sum += j;
                j += 3;
            }
            while (k < 1000)
            {
                sum += k;
                k += 5;
            }
            Console.WriteLine($"Cycle result {sum}");
            sum = 0;
            int a0 = 3;
            int b0 = 5;
            int aN = (1000 / 3) * 3;
            int a = 1000 / 3;
            int bN = (1000 / 5) * 5 - 5;
            int b = 1000 / 5 - 1;
            int c0 = 15;
            int cN = (1000 / 15) * 15;
            int c = 1000 / 15;
            int result = ((a0 + aN) / 2) * a + ((b0 + bN) / 2) * b - (c0 + cN) * (c/2);
            Console.WriteLine($"Formula (arithmetical progression) result {result}");
        }
    }
}
