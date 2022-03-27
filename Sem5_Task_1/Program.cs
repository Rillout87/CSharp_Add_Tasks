// Задача 1. Задан массив из случайных цифр на 15 элементов. На вход подаётся трёхзначное натуральное число.
// Напишите программу, которая определяет, есть ли в массиве последовательность из трёх элементов, совпадающая с введённым числом.

using System;
//using System.Globalization;

namespace Sem5_Task_1
{
    class Program
    {
        static void Main(string[] args)

        {

            Random rnd = new Random();
            int[] array = new int[15];

            for (int i = 0; i < array.Length; i++) // заполняем массив
            {
                array[i] = rnd.Next(1, 10);
            }

            for (int i = 0; i < array.Length; i++) // выведем полученный массив массив
            {
                Console.Write(array[i] + " ");
            }

            Console.WriteLine();
            Console.WriteLine("Введите трехзначное число");
            int nmb = Convert.ToInt32(Console.ReadLine());

            //int nmb = 123;

            int a = nmb / 100;
            int b = nmb / 10 % 10;
            int c = nmb % 10;

            int check = 0;

            for (int i = 0; i < array.Length - 2; i++)
            {
                if (array[i] == a)
                {
                    for (int j = i + 1; j < array.Length - 1; j++)
                    {
                        if (array[j] == b)
                        {
                            for (int t = j + 1; t < array.Length; t++)
                            {
                                if (array[t] == c)
                                {
                                    check = 1;
                                    break;
                                }
                            }
                        }
                    }
                }
            }
            
            if (check == 0) Console.WriteLine("В массиве нет последовательности из трёх элементов, совпадающая с введённым числом.");
            else Console.WriteLine("В массиве есть последовательности из трёх элементов, совпадающая с введённым числом.");

        }


    }


}



