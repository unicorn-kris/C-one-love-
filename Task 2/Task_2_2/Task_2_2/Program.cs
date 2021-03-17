using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Добро пожаловать в игру! Ознакомимся с некоторыми ее правилами!\n" +
                "Для перемещения по игровому полю, используйте одну из кнопок WASD. Обязательно включите английскую раскладку!\n" +
                "Персонаж обозначен буквой G и может перемещаться на одну клетку игрового поля.\n" +
                "1. Если вы попали на бонус (B) - ваша скорость увеличится в 2 раза! Перемещаться вы сможете на 2 клетки, вместо одной!\n" +
                "2. Если на вас напал монстр (M) - вы проиграли!\n" +
                "3. Если вы наткнетесь на препятствие (*) - вернетесь в начало игрового поля.\n" +
                "4. Чтобы победить - нужно достичь правого нижнего конца игрового поля.\n" +
                "Нажмите любую кнопку, чтобы начать!");
            Console.ReadLine();
            Game c = new Game();
            c.Out();
            char forGame = '\0';
            string input = Console.ReadLine();
            while (input.Length != 1)
            {
                input = Console.ReadLine();
            }
            forGame = char.Parse(input);
            while (forGame != '\n' && !c.End)
            {
                c.GoGamer(forGame);
                c.GoMonster();
                    c.Out();

                if (!c.End)
                {
                    input = Console.ReadLine();
                    while (input.Length != 1)
                    {
                        input = Console.ReadLine();
                    }
                    forGame = char.Parse(input);
                }
            }
            Console.ReadLine();
        }
    }
}
