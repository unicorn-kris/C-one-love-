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
            while (k < 1000) {
                sum += k;
                k += 5;
            }
            Console.WriteLine(sum);
        }
    }
}
