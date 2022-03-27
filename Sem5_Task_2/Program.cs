// Задача 2. На вход подаются два числа случайной длины. Найдите произведение каждого разряда первого числа на каждый разряд второго.
// Ответ запишите в массив.

using System;
//using System.Globalization;

namespace Sem5_Task_2
{
    class Program
    {
        static void Main(string[] args)

        {

            Console.WriteLine("Введите первое число случайной длины");
            string nmb1 = Console.ReadLine();

            Console.WriteLine("Введите первое число случайной длины");
            string nmb2 = Console.ReadLine();

            int iterations = nmb1.Length * nmb2.Length; // считаем количество итераций = длину выходного массива

            int[] outArray = new int[iterations];

            for (int t = 0; t < outArray.Length; t++)
            {

                for (int i = 0; i < nmb1.Length; i++)
                {
                    for (int j = 0; j < nmb2.Length; j++)
                    {
                        outArray[t] = (int)Char.GetNumericValue(nmb1[i]) * (int)Char.GetNumericValue(nmb2[j]);
                        t++;
                    }
    
                }
                
            }

            for (int i = 0; i < outArray.Length; i++) // выведем полученный массив массив
            {
                Console.Write(outArray[i] + " ");
            }

           
        }


    }


}




