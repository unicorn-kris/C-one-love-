using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1._2._3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a sentence: ");
            string input = Console.ReadLine();
            string[] words = input.Split(new char[] { '.', ',', ';', '?', ' ', ':' }, StringSplitOptions.RemoveEmptyEntries);
            int count = 0;
            foreach (string word in words)
            {
                if (char.IsLower(word[0]))
                ++count;
            }
            if (count != 0)
            {
                Console.WriteLine($"Result: {count}");
            }
            else
                Console.WriteLine($"No words");
        }
    }
}
