using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1._2._4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a sentences: ");
            StringBuilder input = new StringBuilder (Console.ReadLine());
            char[] punctuations = {'.', '!', '?'};
            char change;
            for (int i = 0; i < input.Length; ++i)
            {
                if (i == 0) {
                    while (!char.IsLetter(input[i]))
                        ++i;
                    change = char.ToUpper(input[i]);
                    input.Remove(i, 1);
                    input.Insert(i, change);
                }
                else if (i != input.Length - 1)
                    for (int j = 0; j < punctuations.Length;)
                    {
                        if ( input[i] == punctuations[j])
                        {
                            while (!char.IsLetter(input[i]))
                                ++i;
                            change = char.ToUpper(input[i]);
                            input.Remove(i, 1);
                            input.Insert(i, change);
                        }
                        else
                            ++j;
                    }
            }
            Console.WriteLine($"Result: {input}");
        }
    }
}