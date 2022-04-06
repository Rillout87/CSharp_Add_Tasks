// Задача 3. Двумерный массив размером 5х5 заполнен случайными нулями и единицами. Игрок может ходить только по полям,
// заполненным единицами. Проверьте, существует ли путь из точки [0, 0] в точку [4, 4]
// (эти поля требуется принудительно задать равными единице).

using System;

//using System.Globalization;

namespace Sem7_Task_3
{
    class Program
    {
        static void Main(string[] args)

        {   

            int[,] array = new int[5,5];

            
            //int[,] array = {{1,0,1,1,0},{1,1,1,1,0},{1,1,0,1,1},{1,0,1,1,0},{0,1,1,1,1}};
            
            FillArray (array);
            array[0,0] = 1;
            array[4,4] = 1;

            Console.WriteLine("Исходный массив");
            PrintArray (array);
            FindRoute(array);
            

        }

        static void FillArray (int[,] arr)

        {
            Random rdm = new Random();
            
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    arr[i,j] = rdm.Next(0,2);
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


        static void FindRoute (int[,] arr, bool finished = false, string direction = "right")

        {
            int i = 0, j = 0, steps =0;

            while (steps < 50) // ограничим количество шагов
            {
                switch (direction)
                {
                    case "right":

                        steps++;
                        if (i == 0 || arr[i - 1, j] != 1)
                        {

                            if (j != 4 && arr[i, j + 1] == 1) j++;
                            else direction = "down";
                        }
                        else
                        { 
                            direction = "up";
                            i--;
                        }
                        break;

                    case "up":

                        steps++;
                        if (j == 0 || arr[i, j-1] != 1)
                        {
                            if (i != 0 && arr[i - 1, j] == 1) i--;
                            else direction = "right";
                        }
                        else
                        {
                            direction = "left";
                            j--;
                        }

                        break;
                    case "left":

                        steps++;
                        if (i == 4 || arr[i + 1, j] != 1)
                        {
                            if (j != 0 && arr[i, j - 1] == 1) j--;
                            else direction = "up";
                        }
                        else
                        {
                            direction = "down";
                            i++;
                        }
                        break;

                    case "down":

                        steps++;
                        if (j == 4 || arr[i, j + 1] != 1)
                        {
                            if (i != 4 && arr[i + 1, j] == 1) i++;
                            else direction = "left";
                        }
                        else
                        {
                            direction = "right";
                            j++;
                        }
                        break;
                }

                if (i == 4 && j == 4)
                {
                    finished = true;
                    break;
                }

            }

            if (!finished || steps == 0) Console.WriteLine("Выхода нет");
            else Console.WriteLine("Из точки [0, 0] в точку [4, 4] существует путь");
        }



    }


}




