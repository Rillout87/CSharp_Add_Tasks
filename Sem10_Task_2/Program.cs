// Задача 2. Дана последовательность натуральных чисел.
// Определите значение второго по величине элемента в этой последовательности.


using System;


namespace Sem10_Task_2
{
    class Program
    {
        static void Main(string[] args)

        {
            int[] sequence = { 12, 4, 2, 7, 6, 6, 8 };

            int firstMax = sequence[0];
            int secondMax = sequence[1];

            for (int i = 1; i < sequence.Length; i++)
            {
                if (sequence[i] > firstMax)
                {
                    secondMax = firstMax;
                    firstMax = sequence[i];
                }
                else if (sequence[i] > secondMax)
                {
                    secondMax = sequence[i];
                }
            }

            Console.WriteLine(secondMax);

        }
    }
}


