using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3_2
{
    class Program
    {
        static void Main(string[] args)
        {
           
            int[] arr = { 1, 2, 3 };
            CycledDynamicArray<int> array = new CycledDynamicArray<int>( arr );
            foreach(int a in array)
            {
                Console.WriteLine($" {a}");
            }
        }
    }
}
