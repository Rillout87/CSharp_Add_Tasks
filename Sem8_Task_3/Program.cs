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

            int minIndexY=0, minIndexX=0; // зададим минимальные индексы и значение здесь, а далее будем передавать их в методы по ссылке
            int minElement = array[0][0];

            FindMinElement(array, ref minIndexX, ref minIndexY, ref minElement);

            Console.WriteLine("Удалим столбец и диагонали, содержащие минимальный элемен {0} c индексом ({1},{2})", minElement, minIndexY, minIndexX);

            PrintArray(CreateNewArray(array, ref minIndexX, ref minIndexY));

        }

        public static int[][] CreateNewArray(int[][] arr, ref int minIndX, ref int minIndY)
        {
            int[][] newArr = new int[arr.Length][]; // в этот зубчатый массив запишем оставшиеся числа после удаления столбца и диагоналей


            for (int i = 0; i < arr.Length; i++)
            {
                List<int> currentRow = new List<int>(); // заранее мы не знаем длину каждой строки в итоговом массивы, поэтому инициализируем кортеж
                
                for (int j = 0; j < arr[i].Length; j++)
                {
                    if (Math.Abs(minIndX - j) != Math.Abs(minIndY - i) && j != minIndX) // пропускаем элементы, лежащие в том же столбце и диагоналях, что и минимальный элемент
                    {
                    currentRow.Add(arr[i][j]); // записываем оставшиеся элементы в текущий кортеж
                    }
                }

                newArr[i] = new int[currentRow.Count]; // длина каждой строки в новом зубчатом массиве равна текущему кортежу
                for (int t = 0; t < newArr[i].Length; t++)
                {
                    newArr[i][t] = currentRow[t]; // копируем текущий кортеж в текущую строку нашего нового зубчатого массива
                }

            }

            return newArr;

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
                        minIndY = i; minIndX = j;
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
                    arr[i][j] = rdm.Next(10,100);

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




