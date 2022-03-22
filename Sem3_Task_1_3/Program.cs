// Задача 1,3. На ввод подаётся номер четверти. Создаются N случайных точек в этой четверти. Определите самый оптимальный маршрут для торгового менеджера, который выезжает из центра координат.

using System;
using System.Globalization;

namespace Sem3_Task_1_3
{
    class Program
    {
        static void Main()

        {

            Console.Clear();
            Random rnd = new Random();
            Console.WriteLine("Введите N");
            int n = Convert.ToInt32(Console.ReadLine());

            int[] x = new int[n], y = new int[n];  // координаты точек
            int[] route = new int[n]; // маршрут
            int xStart = 0, yStart = 0; // координаты точки, от которой расчитываем текущий маршрут
            int startIndex = 0; // индекс точки старт
            

            for (int i = 0; i < n; i++) // Создаем n точек в заданном? квадрате
            {
                x[i] = rnd.Next(1,100);
                y[i] = rnd.Next(1,100);
            }

            for (int i = 0; i < n; i++)
            {
                Console.Write("(" + x[i] +","+ y[i] + ")");
            }

            for (int j = 0; j < route.Length; j++)
            {
                double minDist = 200;
                
                for (int i = 0; i < n; i++)
                {
                    if (x[i] != 0)
                    {
                        double currentDist = Math.Sqrt(Math.Pow((y[i] - xStart), 2) + Math.Pow((y[i] - yStart), 2)); // находим расстояние от Start до текущей точки
                        if (currentDist < minDist)
                        {
                            minDist = currentDist; // фиксируем, если минимальное
                            startIndex = i; // запоминаем индекс ближайшей точки
                        }
                    }

                }
                route [j] = startIndex;
                xStart = x[startIndex]; yStart = y[startIndex]; // запоминаем координаты ближайшей точки
                x[startIndex] = 0; y[startIndex] = 0; // обнуляем текущую точку старт, чтобы пропустить в следующей итерации
            }

            Console.WriteLine();
            Console.Write("Start");

            for (int i = 0; i < n; i++)
            {
                Console.Write("=>" + (route[i]+1));
            }
            


        }


    }


}
