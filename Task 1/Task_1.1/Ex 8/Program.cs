using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_8
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,,] mas = new int [3, 2, 2];
            Console.WriteLine("Enter 12 elements (type int) ");
            for (int i = 0; i < mas.GetLength(0); ++i) {
                for (int j = 0; j < mas.GetLength(1); ++j) {
                    for (int k = 0; k < mas.GetLength(2); ++k)
                    {
                        mas[i, j, k] = int.Parse(Console.ReadLine());
                    }
                }
            }
            for (int i = 0; i < mas.GetLength(0); ++i)
                for (int j = 0; j < mas.GetLength(1); ++j)
                    for (int k = 0; k < mas.GetLength(2); ++k)
                    {
                        if (mas[i,j,k]%2==0)
                        mas[i, j, k] = 0;
                    }
            Console.WriteLine("Result: ");
            for (int i = 0; i < mas.GetLength(0); ++i)
            {
                for (int j = 0; j < mas.GetLength(1); ++j)
                {
                    for (int k = 0; k < mas.GetLength(2); ++k)
                    {
                        Console.Write($"{mas[i, j, k]} ");
                    }
                    Console.WriteLine();                
                }
                Console.WriteLine();
            }
        }
    }
}
