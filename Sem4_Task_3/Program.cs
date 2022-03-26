// Задача 3. Массив на 100 элементов задаётся случайными числами от 1 до 99. Определите самый часто встречающийся элемент в массиве. Если таких элементов несколько, вывести их все.

using System;
//using System.Globalization;
//static System.Globalization.StringInfo;


namespace Sem4_Task_3
{
    class Program
    {
        static void Main()

        {
            Random rnd = new Random();
            int [] array = new int [100];

            for (int i = 0; i < array.Length; i++) // заполняем массив
            {
                array[i] = rnd.Next(1,100);
            }

            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " ");
            }
            
            int[,] arrayCheck = new int [2 , 100]; // создаем пустой новый двумерный массив

            for (int i = 0; i < arrayCheck.GetLength(1); i++) // цикл проверки элементов массива на повторы
            {
                int count = 0; // счетчик, с помощью которого будем считать количество повторов
                
                if (array[i] != 0)
                {
                arrayCheck [0 , i] = array[i]; // в новый массив добавляем уникальное значение
                }
                else continue;
                
                for (int j = i+1; j < arrayCheck.GetLength(1); j++) // проверяем элементы на повторы
                {
                    if (array[j] == array[i])
                    {
                        arrayCheck[1, i] = ++count; //добавляем количество повторов, если повторяется
                        array[j] = 0; // обнуляем элемент в основном массиве, чтобы не возвращаться к нему
                    }

                }



            }
        
            int max = 0;
            for (int i = 0; i < arrayCheck.GetLength(1); i++) // находим максимальное число повторов
            {
                if ((arrayCheck[1, i] != 0) && (arrayCheck[1, i] > max))
                {
                   max = arrayCheck[1, i];
                }

            }

            Console.WriteLine();
            Console.WriteLine("Самый часто встречающийся элемент (элементы): ");
            for (int i = 0; i < arrayCheck.GetLength(1); i++) // выводим элементы, которые повторяются количство раз, равное максимальному
            {
                if (arrayCheck[1, i] == max)
                {
                    Console.WriteLine($"{arrayCheck[0, i]} повторяется {max + 1} раз(а)");
                }

            }



        }
    }
}
