using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3_1_1
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
        static void Main(string[] args)
        {
            List<int> people = new List<int> ();
            Console.WriteLine("Введите N");
            int n = Input();
            Console.WriteLine("Введите, какой по счету человек будет вычеркнут каждый раунд");
            int delete = Input();

            for (int i = 0; i < n;  ++i)
            {
                people.Add(i);
            }
            int round = 0;
            while (people.Count >= delete && people.Count > 1)
            {
                ++round;
                people.RemoveAt(delete - 1);
                Console.WriteLine($"Раунд {round} окончен, осталось людей {people.Count}");
            }
            Console.WriteLine("Игра окончена. Невозможно вычеркнуть больше людей");

        }

    }
}
