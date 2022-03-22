// Задача 1,3. На ввод подаётся номер четверти. Создаются N случайных точек в этой четверти. Определите самый оптимальный маршрут для торгового менеджера, который выезжает из центра координат.

using System;
using System.Globalization;

namespace Sem3_Task_9
{
    class Program
    {
        static void Main()

        {
            int count = 1;
            int player = -1; // Игроку 1 присваеваем индекс 0, Игроку 2 присваеваем индекс 1
            int multiplier;

            while (count <= 1000)
            {
                player = (player+1)%2;

                switch (player)
                {
                    case 0:

                        Player1turn:
                        Console.WriteLine("Первый игрок введите число от 2 до 9");
                        multiplier = Convert.ToInt32(Console.ReadLine());
                        if ((multiplier > 1) && (multiplier < 10))
                        {
                            count *= multiplier;
                            Console.WriteLine("Результат: " + count);
                        }
                        else
                        {
                            Console.WriteLine("Вы ввели число неверно!");
                            goto Player1turn;
                        }    
                    break;

                    case 1:
                    {
                        Player2turn:
                        Console.WriteLine("Второй игрок введите число от 2 до 9");
                        multiplier = Convert.ToInt32(Console.ReadLine());
                        if ((multiplier > 1) && (multiplier < 10))
                        {
                            count *= multiplier;
                            Console.WriteLine("Результат: " + count);
                        }
                        else
                        {
                            Console.WriteLine("Вы ввели число неверно!");
                            goto Player2turn;
                        }
                        break;
                    }

                }

            }
        
            Console.WriteLine("Выйграл игрок " + (player+1));
        }


    }


}

