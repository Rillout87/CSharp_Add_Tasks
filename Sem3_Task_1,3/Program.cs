// Задача 1,3. На ввод подаётся номер четверти. Создаются N случайных точек в этой четверти. Определите самый оптимальный маршрут для торгового менеджера, который выезжает из центра координат.

using System;
using System.Globalization;

namespace Sem2_Task_3
{
    class Program
    {
        static void Main()

        {

            //Console.Clear();
            Random rnd = new Random();
            Console.WriteLine("Введите N");
            int n = Convert.ToInt32(Console.ReadLine());

            int[] x = new int[n], y = new int[n];
            int xMin = 0, yMin = 0;
            double minDist = 0, currentDist =0;

            for (int i = 1; i < n; i++)
            {
                x[i] = rnd.Next(1,100);
                y[i] = rnd.Next(1,100);

                currentDist = Math.Sqrt (Math.Pow(x[i] - xMin) + Math.Pow(y[i] - yMin));
                if (currentDist < minDist) minDist = currentDist;
                Console.WriteLine(minDist);

            }
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(x[i] + "," + y[i]);
            }
            


        }


    }


}
