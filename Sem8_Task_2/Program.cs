// Задача 2. Дан двумерный массив, заполненный случайными числами от -9 до 9.
// Подсчитать частоту вхождения каждого числа в массив, используя словарь.

using System;

namespace Sem8_Task_2
{
    class Program
    {
        static void Main(string[] args)

        {
            int m = 4;

            int[,] array = new int[m, m];

            FillArray(array);
            Console.WriteLine("Исходный массив");
            PrintArray(array);

            Dictionary<int, int> numbers = new Dictionary<int, int>();

            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    try
                    {
                        ++numbers[array[i, j]];
                    }

                    catch
                    {
                        numbers[array[i, j]] = 1;
                    }
                }
            }

            foreach (KeyValuePair<int, int> kvp in numbers)
            {
                Console.WriteLine("Число {0} встречается {1} раз(а)",
                kvp.Key, kvp.Value);
            }

        }

        static void FillArray (int[,] arr)

        {
            Random rdm = new Random();
            
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    arr[i,j] = rdm.Next(-9,10);

                }


            } 

        }

        static void PrintArray (int[,] arr)

        {

            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    Console.Write(arr[i,j] + "\t");

                }

            Console.WriteLine();
            } 

        }


    }


}



