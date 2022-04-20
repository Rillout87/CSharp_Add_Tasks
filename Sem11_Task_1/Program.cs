// Задача 1. Двумерная матрица заполнена натуральными числами. Найти тройку чисел,
// для которых площадь треугольника со сторонами, определяемыми данной тройкой, будет максимальна.


using System;


namespace Sem11_Task_1
{
    class Program
    {
        static void Main(string[] args)

        {
            int[,] matrix = {{5,12,5,9,7,13,19,1,22,8},{0,12,5,7,18,25,6,15,20,1},{2,29,24,5,16,14,8,3,10,17}};

            double[] simpleArray = new double[3 * 10];


            int index = 0;

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    simpleArray[index++] = matrix[i, j];
                }
            }

            double maxSquare = 0;
            double currentSquare = 0;

            double pointA, pointB, pointC;

            for (int a = 0; a < simpleArray.Length - 2; a++)
            {

                for (int b = a + 1; b < simpleArray.Length - 1; b++)
                {

                    for (int c = a + 2; c < simpleArray.Length; c++)
                    {
                        double semiPerim = (simpleArray[a] + simpleArray[b] + simpleArray[c]) / 2;
                        currentSquare = Math.Sqrt(semiPerim * (semiPerim - simpleArray[a])
                        * (semiPerim - simpleArray[b]) * (semiPerim - simpleArray[c]));
                        
                        if (currentSquare > maxSquare)
                        {
                            maxSquare = currentSquare; pointA = simpleArray[a]; pointB = simpleArray[b]; pointC = simpleArray[c];
                        }
                    }
                }
            }
            //Console.WriteLine($"{pointA} {pointB} {pointC} {maxSquare}");
        }
    }
}



