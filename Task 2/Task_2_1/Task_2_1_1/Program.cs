using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2_1_1
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Enter string: ");
            Kris_String str1 = new Kris_String(Console.ReadLine());
            Console.WriteLine("Enter length and array of char: ");
            int s = int.Parse(Console.ReadLine());
            char[] array = new char[s];
            for (int i = 0; i < s; ++i)
                array[i] = char.Parse(Console.ReadLine());
            Kris_String str2 = new Kris_String(array);
            Console.WriteLine("Enter count and symbol: ");
            int count = int.Parse(Console.ReadLine());
            char symbol = char.Parse(Console.ReadLine());
            Kris_String str3 = new Kris_String(count, symbol);
            Console.Write("str1: ");
            str1.Output();
            Console.Write("str2: ");
            str2.Output();
            Console.Write("str3: ");
            str3.Output();
            Console.WriteLine($"Compare str1 and str2: {str1.Compare(str2)} ");
            Console.Write("Enter symbol to find in str2: ");
            char symbolToFind = char.Parse(Console.ReadLine());
            int find = str2.Find(symbolToFind);
            if (find > -1)
            {
                Console.Write($"First Position: {str2.Find_First(symbolToFind)}, Last Position: {find}");
                Console.WriteLine();
            }
            else
                Console.WriteLine($"This symbol is missing");
            Kris_String str4 = str1.Concatenation(str2);
            Console.Write($"Concatenation str1 and str2: ");
            str4.Output();
            str1 += str2;
            Console.Write($"Str1 = str1 + str2: ");
            str1.Output();
            Console.WriteLine("Enter new string: ");
            string newstr = Console.ReadLine();
            str2 += str2;
            Console.Write($"Str2 = str2 + new string: ");
            str2.Output();
            Console.WriteLine("Test explicit (new string -> Kris_String): ");
            Kris_String a = (Kris_String)newstr;
            a.Output();
            Console.WriteLine("Test implicit (Kris_String -> new string): ");
            string b = a;
            Console.WriteLine(b);
        }
    }
}
