using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_7
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] mas = new int[10];
            Random rand = new Random();
            Console.WriteLine("Array: ");
            int min = Int32.MaxValue;
            int max = Int32.MinValue;
            for (int i = 0; i < mas.Length; ++i)
            {
                mas[i] = rand.Next(Int32.MinValue, Int32.MaxValue);
                Console.Write("{0} ", mas[i]);
                if (mas[i] > max)
                    max = mas[i];
                if (mas[i] < min)
                    min = mas[i];
            }
            Console.WriteLine();
            Console.WriteLine($"Max in array: {max}");
            Console.WriteLine($"Min in array: {min}");
            int temp;
            for (int i = 0; i < mas.Length; ++i)
            {
                for (int j = 0; j < mas.Length - 1; ++j)
                    if (mas[i] < mas[j])
                    {
                        temp = mas[i];
                        mas[i] = mas[j];
                        mas[j] = temp;
                    }
            }
            Console.WriteLine("Result: ");
            for (int i = 0; i < mas.Length; ++i)
                Console.Write("{0} ", mas[i]);
        }
    }
}
