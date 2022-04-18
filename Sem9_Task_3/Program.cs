// Задача 3. Даны натуральные числа a и b. Рекурсивно описать функцию возведения числа a в степень b, используя только операцию инкременирования.

// ДЕНИС, ЕСЛИ ВЫ ЭТО ЧИТАЕТЕ, ТО ЭТО ЗНАЧИТ, ЧТО НА ДАННЫЙ МОМЕНТ Я ЕЩЕ НЕ ДОДЕЛАЛ ЭТУ ЗАДАЧУ. ПРОШУ ПРОПУСТИТЬ - ДОДЕЛАЮ ПОТОМ САМ


using System;


namespace Sem9_Task_3
{
    class Program
    {
        static void Main(string[] args)

        {
            int a = 4;
            int b = 3;

            Console.WriteLine(Power(a, b));
            
        }
        static int Power(int a, int b)
        {
            int tmpA = a;
            int iterations = a;
            if (b > 2) iterations = Power(a, --b);


            if (b == 2)
            {
                
                for (int j = 1; j <= iterations - 1; j++)

                {
                    for (int i = 1; i <= tmpA; i++)
                    {
                        a++;
                    }
                }
            }
            return a;
        }
}



}