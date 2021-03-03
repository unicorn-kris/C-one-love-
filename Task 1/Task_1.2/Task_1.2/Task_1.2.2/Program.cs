using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1._2._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a sentence: ");
            StringBuilder input = new StringBuilder (Console.ReadLine());
            Console.WriteLine("Enter a word: ");
            string inputWord = Console.ReadLine();
            for (int i = 0; i < inputWord.Length; ++i)
            {
                for (int j = 0; j < input.Length; ++j)
                {
                    if (inputWord[i] == input[j])
                        input.Insert(j, input[j]);
                    ++j;
                }
            }
            Console.WriteLine($"Result: {input}");
        }
    }
}
