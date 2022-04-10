// Задача 1. Дан двумерный массив. Заменить в нём элементы первой строки элементами главной диагонали.
// А элементы последней строки, элементами побочной диагонали.

namespace Sem8_Task_1
{
    class Program
    {
        static void Main(string[] args)

        {   
            int m = 7;

            int[,] array = new int[m,m];


            FillArray (array);
            Console.WriteLine("Исходный массив");
            PrintArray (array);
            
            ModifyArray(array);
            Console.WriteLine("Измененный массив");
            PrintArray (array);

        }

        static void FillArray (int[,] arr)

        {
            Random rdm = new Random();
            
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    arr[i,j] = rdm.Next(0,100);

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

        static void ModifyArray (int[,] arr)

        {

            for (int j = 0, i = j; j < arr.GetLength(1); j++, i++)
            {
                arr[0, j] = arr[i, j];
                arr[arr.GetLength(0) - 1, j] = arr[arr.GetLength(0)- 1 - i, j];
            }


        }

    }


}


