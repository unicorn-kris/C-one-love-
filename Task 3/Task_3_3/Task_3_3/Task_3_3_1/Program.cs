using System;
using System.Collections.Generic;

namespace Task_3_3_1
{
    class Program
    {
        static int Input()
        {
            int N;
            bool input = int.TryParse(Console.ReadLine(), out N);
            while (!input)
            {
                Console.WriteLine("Введите корректное значение");
                input = int.TryParse(Console.ReadLine(), out N);
            }
            return N;
        }
        static char InputDecide()
        {
            char N;
            bool input = char.TryParse(Console.ReadLine(), out N);
            int ch = (int)N - '0';
            if (N != '\0')
            {
                while (!input || ch > 7 || ch < 0)
                {
                    Console.WriteLine("Введите корректное значение");
                    input = char.TryParse(Console.ReadLine(), out N);
                }
            }
            return N;
        }
        static int InputItem(int count)
        {
            int N;
            bool input = int.TryParse(Console.ReadLine(), out N);
            while (!input || N >= count || N < 0)
            {
                Console.WriteLine("Введите корректное значение");
                input = int.TryParse(Console.ReadLine(), out N);
            }
            return N;
        }
        delegate int IntOperation(int num, int actionNum);
        delegate int ArrayOperation(int[] array);
        static void Main(string[] args)
        {

            Console.WriteLine("Enter count numbers in array");
            int n = Input();
            int[] array = new int[n];
            Console.WriteLine("Enter array of numbers");
            for (int i = 0; i < n; ++i)
            {
                array[i] = Input();
            }

            IntOperation Ioperation = Methods.Add;
            ArrayOperation Aoperation = Methods.Sum;
            int item = -1;
            char decide = '0';

            Console.WriteLine("Enter action (for first 4 actions you will need to enter item number and write additional element ):\n" +
                   "1 - Add, 2 - Subtract , 3 - Multiply by, 4 - Divide by, \n" +
                   "5 - Sum of the elements, 6 - Arithmetic mean of the elements, 7 - The most frequent value ");
            decide = InputDecide();
            int decideNum = (int)decide - '0';
            while (decide != '\0')
            {
                int newElement;
                if (decideNum < 4)
                {
                    Console.WriteLine("Enter item number");
                    item = InputItem(n);
                    Console.WriteLine("Enter element");
                    newElement = Input();
                    if (decideNum == 2)
                        Ioperation = Methods.Sub;
                    else if (decideNum == 3)
                        Ioperation = Methods.Mult;
                    else if (decideNum == 4)
                        Ioperation = Methods.Div;

                    Console.WriteLine($"Result: {Ioperation(array[item], newElement)}");
                }
                else
                {
                    if (decideNum == 6)
                        Aoperation = Methods.Mean;
                    else if (decideNum == 7)
                        Aoperation = Methods.Freaq;

                    Console.WriteLine($"Result: {Aoperation(array)}");
                }
                Console.WriteLine("Enter new action ");
                decide = InputDecide();
            }
        }

    }
    public static class Methods
    {
        public static int Add(int x, int y)
        {
            return x + y;
        }
        public static int Sub(int x, int y)
        {
            return x - y;
        }
        public static int Mult(int x, int y)
        {
            return x * y;
        }
        public static int Div(int x, int y)
        {
            return x / y;
        }
        public static int Sum(int[] array)
        {
            int sum = 0;
            foreach (int x in array)
                sum += x;
            return sum;
        }
        public static int Mean(int[] array)
        {
            int mean = 0;
            foreach (int x in array)
                mean += x;
            return mean / array.Length;
        }
        public static int Freaq(int[] array)
        {
            Dictionary<int, int> freaq = new Dictionary<int, int>(array.Length);

            for (int i = 0; i < array.Length; ++i)
            {
                if (!freaq.ContainsKey(array[i]))
                {
                    freaq.Add(array[i], 1);
                }
                else
                    freaq[array[i]]++;
            }

            int max = 0;
            int maxFreaqElement = 0;

            foreach (var freaqOfTheElement in freaq)
            {
                if (freaqOfTheElement.Value > max)
                {
                    max = freaqOfTheElement.Value;
                    maxFreaqElement = freaqOfTheElement.Key;
                }
            }

            return maxFreaqElement;
        }
    }
}
