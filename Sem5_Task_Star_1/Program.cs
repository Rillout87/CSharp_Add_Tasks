// Задача 1*. Дан массив массивов, состоящих из натуральных чисел, размер которого 5.
// Для каждого элемента-массива найти сумму его элементов и вывести массив с наибольшей суммой.
// Если таких массивов несколько, вывести массив с наименьшим индексом.

using System;
//using System.Globalization;

namespace Sem5_Task_Star_1
{
    class Program
    {
        static void Main(string[] args)

        {

            int[][] array = new int [5][];

            Random rnd = new Random();

            for (int i = 0; i < array.Length; i++) // заполняем массив
            {
                array[i] = new int[rnd.Next(1, 6)];
                
                for (int j = 0; j < array[i].Length; j++)
                {
                array[i][j] = rnd.Next(1, 10);
                }
            }

            for (int i = 0; i < array.Length; i++) // выводим массив
            {
                Console.Write("{ ");
                for (int j = 0; j < array[i].Length; j++)
                {
                    Console.Write(array[i][j] + " ");
                }
                Console.Write("}\n");
            }

            int maxArray = 0; // сумма максимального массива
            int maxArrayIndex = 0; //индекс маскимального массива



            for (int i = 0; i < array.Length; i++) // находим максимальный массив и его индекс
            {

                int currentArrayAmount = 0; // сумма текущего массива

                for (int j = 0; j < array[i].Length; j++)
                {
                    currentArrayAmount += array[i][j];
                }
                if (currentArrayAmount > maxArray)
                {
                    maxArray = currentArrayAmount;
                    maxArrayIndex = i;
                }
            }

            Console.WriteLine("Первый массив с наибольшей суммой элементов:");

            Console.Write("{ ");
            for (int i = 0; i < array[maxArrayIndex].Length; i++)
            {
                Console.Write(array[maxArrayIndex][i] + " ");
            }
            Console.Write("}\n");
            

            Console.WriteLine($"Его сумма равна {maxArray}");

        }


    }


}






