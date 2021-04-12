using System;

namespace Task_3_3_3
{
    class Program
    {
        static int Input()
        {
            int N;
            bool input = int.TryParse(Console.ReadLine(), out N);
            while (!input || N > 15)
            {
                Console.WriteLine("Введите корректное значение");
                input = int.TryParse(Console.ReadLine(), out N);
            }
            return N;
        }
        static void Main(string[] args)
        {
            Customer newCustomer;
            Order newOrder = null;
            int inputOrder = 1;
            int orderNum = 0;
            while (inputOrder > 0 && inputOrder <= 15)
            {
                Console.WriteLine(@"Введите имя клиента! Или нажмите Enter для выхода!");
                string name = Console.ReadLine();
                if (name != "")
                {
                    newCustomer = new Customer(name);
                    Console.WriteLine(@"Выберите номер пиццы для заказа!
1. Маргарита
2. «Сицилийская»
3. Пицца «Дьябло»
4. Гавайская пицца
5. «Капричоза»
6. «Кальцоне»
7. Пицца по - неаполитански
8. Пицца с морепродуктами
9. Пицца «Четыре сыра»
10. Пицца «Четыре мяса»
11. Овощная пицца
12. Пицца с тунцом
13. Пицца «Четыре сезона»
14. «Охотничья» пицца
15. Цыпленок BBQ");
                    inputOrder = Input();
                    if (inputOrder > 0 && inputOrder <= 15)
                    {
                        if (orderNum != 0)
                        {
                            Console.WriteLine($"Заказ {newOrder.GetSetOrderInt} для {newOrder.GetCustomer} готов!");
                        }
                        ++orderNum;
                        newOrder = new Order(inputOrder, newCustomer);
                        newOrder.GetSetOrderInt = orderNum;
                        Console.WriteLine($"Ваш номер заказа - {orderNum}");
                    }
                    else
                    {
                        Console.WriteLine("Данные введены некорректно, попробуйте снова.");
                    }
                }
                else
                    inputOrder = 0;
            }
            if (newOrder != null)
                Console.WriteLine($"Заказ {newOrder.GetSetOrderInt} для {newOrder.GetCustomer} готов!");
        }

    }
}
