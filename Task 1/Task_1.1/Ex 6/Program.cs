using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_6
{
    class Program
    {
        static bool flagChange = false; // no change
        static void Params(List<int> saveParams)
        {
            Console.Write("Параметры надписи: ");
            if (saveParams.Count == 0)
            {
                Console.WriteLine("None");
            }
            else
            {
                int i = 0;
                foreach (int param in saveParams)
                {
                    ++i;
                    switch (param)
                    {
                        case 1:
                            Console.Write(" Bold");
                            break;
                        case 2:
                            Console.Write(" Italic");
                            break;
                        case 3:
                            Console.Write(" Underline");
                            break;
                    }
                    if (i < saveParams.Count)
                        Console.Write(", ");
                }
                Console.WriteLine();
            }
            if (!flagChange)
                Console.WriteLine("Введите");
        }
        static void Main(string[] args)
        {
            List<int> saveParams = new List<int>();
            Params(saveParams);
            while (!flagChange)
            {
                int n = int.Parse(Console.ReadLine());
                int i = 0;
                foreach (int param in saveParams)
                    if (param==n)
                        ++i;
                if (i == 0)
                    saveParams.Add(n);
                else
                {
                    flagChange = true;
                    saveParams.Remove(n);
                }
                Params(saveParams);
            }
        }
    }
}
