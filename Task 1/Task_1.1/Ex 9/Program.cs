using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_9
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] mas = new int[10];
            Console.WriteLine("Enter 10 elements (type int) ");
            for (int i = 0; i < mas.GetLength(0); ++i)
            {
                mas[i] = int.Parse(Console.ReadLine());
            }
            int sum = 0;
            foreach (int num in mas)
            {
                if (num % 2 == 0)
                    sum += num;
            }
            Console.WriteLine($"Non-negative sum: {sum}");
        }
    }
}
