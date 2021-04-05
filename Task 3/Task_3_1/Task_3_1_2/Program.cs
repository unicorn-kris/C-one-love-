using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace Task_3_1_2
{
    class Program
    {
        static string Input()
        {
            string N = Console.ReadLine();
            while (N == "")
            {
                Console.WriteLine("Введите корректный текст");
                N = Console.ReadLine();
            }
            return N;
        }
        static void Main(string[] args)
        {
            Dictionary<string, int> words = new Dictionary<string, int>();
            Console.WriteLine("Введите текст");
            string input = Input();
            string[] arrayWords = input.Split(' ', ',', '.', '!', '?', ':', '\n');
            for (int i = 0; i < arrayWords.Length; ++i)
            {
                if (words.Count == 0)
                {
                    words.Add(arrayWords[i].ToLower(), 1);
                }
                else if( arrayWords[i] != "")
                {
                    if (!words.ContainsKey(arrayWords[i].ToLower())) //если в словаре слова нет
                    {
                        words.Add(arrayWords[i].ToLower(), 1); //его код 0
                    }
                    else
                    {
                        words[arrayWords[i].ToLower()]++;
                    }
                }
            }

            //вычисление тошнотности текста, сумма спама более 60% - плохо, 30-60 - нормально, до 30 - отлично
            List<int> spam = new List<int>();

            foreach (KeyValuePair<string, int> word in words)
            {
                spam.Add(word.Value / arrayWords.Length * 100);
            }
            int spamsum = 0;

            int NumbersOfSpamWords = 0;
            foreach (int spamParam in spam)
                spamsum += spamParam;


            for (int i = 0; i < spam.Count; ++i)//если текст состоит на более чем 2% из данного слова то это слово - спам
            {
                if (spam[i] >= 2)
                    NumbersOfSpamWords++;
            }
            if (spamsum > 60)
            {
                Console.WriteLine($"Заспамленность текста {spamsum} - плохо.");
            }
            else if (spamsum < 60 && spamsum > 30)
            {
                Console.WriteLine($"Заспамленность текста {spamsum} - хорошо.");
            }
            else if (spamsum < 30)
            {
                Console.WriteLine($"Заспамленность текста {spamsum} - отлично.");
            }
            if (NumbersOfSpamWords > 0)
            {
                Console.WriteLine($"Рекомендую заменить первые {NumbersOfSpamWords} слов(а): "); ;
                var SpamWords =
                    from wordval in words
                    orderby wordval.Value
                    select wordval;
                foreach (var resultSpam in SpamWords)
                {
                    Console.WriteLine($"{resultSpam.Key} встречается {resultSpam.Value} раз(а)");
                } 
            }
        }
    }
}
