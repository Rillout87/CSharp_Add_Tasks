// Задача 1. Даны две матрицы, количество строк и столбцов которых может быть 3 или 4, заполнены числами от -9 до 9.
// Выполните умножение матриц.

using System;
//using System.Globalization;

namespace Sem7_Task_1
{
    class Program
    {
        static void Main(string[] args)

        {   
            int m = 3, l = 3, n = 4;

            int[,] matrixA = new int[m,l];

            int[,] matrixB = new int[l,n];

            int[,] matrixC = new int[m,n];


            FillArray (matrixA);
            FillArray (matrixB);
            
            Console.WriteLine("Матрица A:");
            PrintArray (matrixA);
            Console.WriteLine("Матрица B:");
            PrintArray (matrixB);

            MatricesMultiply(matrixA,matrixB,matrixC);
            
            Console.WriteLine("Произведение матриц:");
            PrintArray (matrixC);

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
                    Console.Write(arr[i,j] + " ");

                }

            Console.WriteLine();
            } 

        }

        static void MatricesMultiply (int[,] arrA, int[,] arrB, int[,] arrC)

        {
            
            for(int i = 0; i < arrA.GetLength(0); i++)
            {

                for (int j = 0; j < arrB.GetLength(1); j++)
                {
                    int currentElement = 0;

                    for (int l = 0; l < arrA.GetLength(1); l++)
                    {
                        currentElement += arrA[i,l]*arrB[l,j];
                    }
                    
                    arrC[i,j] = currentElement;
                }
                
            }
        }


        
    }


}


