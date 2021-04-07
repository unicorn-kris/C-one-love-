using System;
using System.Text.RegularExpressions;

namespace Task_3_3_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter word: ");
            string input = Console.ReadLine();
            StringMethod.Language(input);
        }
    }
    public static class StringMethod
    {
        public static void Language(this string inputString)
        {
            Regex englishText = new Regex(@"[A-Za-z]{1}");
            Regex russianText = new Regex(@"[А-ЯЁа-яё]{1}");
            Regex digitText = new Regex(@"[0-9]{1}");

            MatchCollection rus = russianText.Matches(inputString);
            MatchCollection eng = englishText.Matches(inputString);
            MatchCollection dig = digitText.Matches(inputString);

            if (rus.Count == inputString.Length)
                Console.WriteLine("Russian word");
            else if (eng.Count == inputString.Length)
                Console.WriteLine("English word");
            else if (dig.Count == inputString.Length)
                Console.WriteLine("Number");
            else
                Console.WriteLine("Mixed");
        }
    }
}
