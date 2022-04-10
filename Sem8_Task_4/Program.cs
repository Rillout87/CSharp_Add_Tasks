// Задача 4. Заполните двумерный массив 3х3 числами от 1 до 9 змейкой.

using System;
//using System.Globalization;

namespace Sem8_Task_4
{
    class Program
    {
        static void Main(string[] args)

        {   
            int n = 3, m = 3;
            int[,] array = new int[n,m];


            FillInSnake (array);
            PrintArray (array);           
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

          
        static void FillInSnake(int[,] arr)
        {
            int number = 1;

            for (int j = 0; j < arr.GetLength(1); j++)
            {
                if (j % 2 == 0)
                {
                    for (int i = 0; i < arr.GetLength(0); i++)
                    {
                        arr[i, j] = number;
                        number++;
                    }
                }
                else if (j % 2 != 0)
                {

                    for (int i = arr.GetLength(0)-1; i >= 0; i--)
                    {
                        arr[i, j] = number;
                        number++;
                    }
                }
            }
        }
    }
    
    


}

