// Задача 2. Дан двумерный массив, заполненный случайными числами от -99 до 99.
// Найти минимальный по модулю элемент. Удалить столбец и диагонали, содержащие его.

using System;

namespace Sem8_Task_3
{
    class Program
    {
        static void Main(string[] args)

        {
            int m = 4;

            int[][] array = new int[m][];
            for(int i = 0; i < m; i++) array[i] = new int[m];


            FillArray(array);
            Console.WriteLine("Исходный массив");
            PrintArray(array);

            int minIndexX=0, minIndexY=0;
            int minElement = array[0][0];

            FindMinElement(array, ref minIndexX, ref minIndexY, ref minElement);

            Console.WriteLine($"{minIndexX} + {minIndexY} + {minElement}");


        }

        static void CreatNewArray(int[][] arr, ref int minIndX, ref int minIndY)
        {
            int[][] newArray = new int[arr.Length-1][];
            for(int i = 0; i < m; i++) newArray[i] = new int[m];



        }

        static void FindMinElement(int[][] arr, ref int minIndX, ref int minIndY, ref int minElmt)
        {



            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr[i].Length; j++)
                {
                    if (arr[i][j] < minElmt)
                    {
                        minElmt = arr[i][j];
                        minIndX = i; minIndY = j;
                    }
                }
            }

        }


        static void FillArray (int[][] arr)

        {
            Random rdm = new Random();
            
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr[i].Length; j++)
                {
                    arr[i][j] = rdm.Next(-99,100);

                }


            } 

        }

        static void PrintArray (int[][] arr)

        {

            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr[i].Length; j++)
                {
                    Console.Write(arr[i][j] + "\t");

                }

            Console.WriteLine();
            } 

        }


    }


}




