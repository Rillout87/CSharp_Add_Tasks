// Задача 2. Двумерный массив размером 3х4 заполнен числами от 100 до 9999.
// Найдите в этом массиве и сохраните в одномерный массив все числа, сумма цифр которых больше их произведения.
// Выведите оба массива.

using System;
//using System.Globalization;

namespace Sem7_Task_2
{
    class Program
    {
        static void Main(string[] args)

        {   

            int[,] array = new int[3,4];
            List<int> resultList = new List<int>();

            FillArray (array);
            
            Console.WriteLine("Исходный массив");
            PrintArray (array);

            FindElement(array, resultList);
            PrintList(resultList);

        }

        static void FillArray (int[,] arr)

        {
            Random rdm = new Random();
            
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    arr[i,j] = rdm.Next(100,10000);

                }


            } 

        }

        static void PrintArray (int[,] arr)

        {

            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    Console.Write(arr[i,j] + " ");

                }

            Console.WriteLine();
            } 

        }

        static void PrintList (List<int> lst)

        {
            Console.WriteLine("Числа, сумма цифр которых больше их произведения:");

            for (int i = 0; i < lst.Count; i++)
            {

                    Console.Write(lst[i] + " ");

            } 

        }

        static void FindElement (int[,] arr, List<int> resLst)

        {
            for(int i = 0; i < arr.GetLength(0); i++)
            {

                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    int currentElement = arr [i,j];
                    int sum = 0;
                    int product = 1;
                    while (currentElement > 0)
                    {
                        sum += currentElement % 10;
                        product *= currentElement % 10;
                        currentElement /= 10;
                    }
                    
                    if (sum > product) resLst.Add(arr [i,j]);
                    
                }
                
            }
        }


        
    }


}



