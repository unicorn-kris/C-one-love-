using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_10
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] mas = new int[4, 4];
            Console.WriteLine("Enter 16 elements (type int) ");
            for (int i = 0; i < mas.GetLength(0); ++i)
                for (int j = 0; j < mas.GetLength(1); ++j)
                {
                    Console.Write($" mas [{i}, {j}] = ");
                    mas[i, j] = int.Parse(Console.ReadLine());
                }
            int sum = 0;
            for (int i = 0; i < mas.GetLength(0); ++i)
                for (int j = 0; j < mas.GetLength(1); ++j)
                    if ((i+j) % 2 == 0)
                    {
                        sum += mas[i, j];
                    }
            Console.WriteLine($"Sum: {sum}");
        }
    }
}
