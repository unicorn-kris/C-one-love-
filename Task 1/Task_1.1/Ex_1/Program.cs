using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a: ");
            int a = int.Parse(Console.ReadLine());
            if (a <= 0)
                Console.WriteLine("Error. a<=0");
            else
            {
                Console.WriteLine("Enter b: ");
                int b = int.Parse(Console.ReadLine());
                if (b <= 0)
                    Console.WriteLine("Error. b<=0");
                if (a > 0 && b > 0)
                {
                    int resultS = a * b;
                    Console.WriteLine($"S =  {resultS}");
                }
            }
        }
    }
}
