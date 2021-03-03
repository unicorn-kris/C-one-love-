using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1._2._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a sentence: ");
            string input = Console.ReadLine();
            string[] words = input.Split(new char [] {'.', ',', '!', '?', ' ', ':'}, StringSplitOptions.RemoveEmptyEntries);
            int wordLength = 0;
            int count = 0;
            int meanLength = 0; //округляю дробные значения, т.к. слово не может иметь дробную длину
            foreach (string word in words)
            {
                    wordLength += word.Length;
                    ++count;
            }
            if (wordLength != 0)
            {
                meanLength = wordLength / count;
                Console.WriteLine($"Mean length: {meanLength}");
            }
            else 
                Console.WriteLine($"No words");
        }
    }
}
