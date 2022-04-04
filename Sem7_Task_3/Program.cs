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

            //int[,] array = new int[5,5];
            int[] finish = {0}; // флаг, показващий, что мы дошли до точки [4, 4] (0/1)
            
            int[,] array = {{1,1,1,0,1},{1,0,1,1,0},{1,0,0,1,1},{1,0,1,0,1},{1,1,1,0,1}};
            
            //FillArray (array);
            //array[0,0] = 1;
            //array[4,4] = 1;

            Console.WriteLine("Исходный массив");
            PrintArray (array);

            

            

            FindRoute(array, finish);
            
            //PrintList(resultList);

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


        static void FindRoute (int[,] arr, int[] finish, string direction = "D", int i = 0, int j =0)

        {
            //int a = i, b = j;
            if (i == 4 && j == 4)
            {
                finish[0] = 1;
                Console.WriteLine($"Из точки [0, 0] в точку [4, 4] существует путь.\n" +
                                    $"Маршрут: {i},{j}");
            }
            
            
            if (finish[0] == 0 && direction == "D" && i < 4 && i >= 0 && j < 5 && j >= 0)
            {
                if (arr[i, j] == 1 && arr[i + 1, j] == 1)
                {
                    if (i != 4) FindRoute(arr, finish, direction = "D", ++i, j);
                    if (j != 4) FindRoute(arr, finish, direction = "R", i, ++j);
                    if (j != 0) FindRoute(arr, finish, direction = "L", i, --j);
                }
            }
            
            if (finish[0] == 0 && direction == "R" && i < 5 && i >= 0 && j < 4 && j >= 0)
            {
                if (arr[i, j] == 1 && arr[i, j+1] == 1)
                {
                    if (j != 4) FindRoute(arr, finish, direction = "R", i, ++j);
                    if (i != 4) FindRoute(arr, finish, direction = "D", ++i, j);
                    if (i != 0) FindRoute(arr, finish, direction = "U", --i, j);
                }    
            }
            
            if (finish[0] == 0 && direction == "L" && i < 5 && i >= 0 && j < 5 && j > 0)
            {
                if (arr[i, j] == 1 && arr[i, j-1] == 1)
                {
                    if (j != 0) FindRoute(arr, finish, direction = "L", i, --j);
                    if (i != 4) FindRoute(arr, finish, direction = "D", ++i, j);
                    if (i != 0) FindRoute(arr, finish, direction = "U", --i, j);
                }
            }

            if (finish[0] == 0 && direction == "U" && i < 5 && i > 0 && j < 5 && j >= 0)
            {
                if (arr[i, j] == 1 && arr[i - 1, j] == 1)
                {
                    if (i != 0) FindRoute(arr, finish, direction = "U", --i, j);
                    if (j != 4) FindRoute(arr, finish, direction = "R", i, ++j);
                    if (i != 0) FindRoute(arr, finish, direction = "L", i, --j);
                }
                
            }
            
            if (finish[0] == 0)
            {
                Console.WriteLine($"Из точки [0, 0] в точку [4, 4] не существует путь");
            }

            ///if (i != 4) FindRoute(arr, rt, finish, ++i, j);
            
            
            
            
            //if (i == 4 && j == 4)
           // {
            //    finish[0] = 1;
            //    Console.WriteLine($"Из точки [0, 0] в точку [4, 4] существует путь.\n" +
            //                        $"Маршрут: {rt}{i},{j}");
            //}
            //else if (finish[0] == 0 && arr[i, j] == 1) // проверяем: не дошли ли мы до финица, и равна ли текущая точка единице
            //{
            //    rt += $"{i},{j} => "; // вносим текущую точку в маршрут


            //    if (i != 4) FindRoute(arr, rt, finish, ++i, j); // здесь и далее сдвигаемся на одну точку

            //    if (j != 4) FindRoute(arr, rt, finish, i, ++j);
   
            //    if (i != 0) FindRoute(arr, rt, finish, --i, j);
   
            //    if (j != 0) FindRoute(arr, rt, finish, i, --j);

            //}

        }


        
    }


}




