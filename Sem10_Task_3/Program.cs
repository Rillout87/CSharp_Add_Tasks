// Задача 3. Дан массив, состоящий из случайных целых чисел. Дано число M.
// Выведите случайное подмножество массива, сумма элементов в котором не превосходит M.


using System;


namespace Sem10_Task_3
{
    class Program
    {
        static void Main(string[] args)

        {
            int[] array = { 11, 52, 36, 8, 19 };
            int m = 50;

            if (CheckIsValid(array, m)) FindRandSubSeq(array, m);
            else Console.WriteLine("нет ни одного подмножества, сумма элементов в котором не превосходит M");
        }
        static void FindRandSubSeq(int[] arr, int nmb)
        {
            List<int> result = new List<int>();

            Random rand = new Random();
            
            int randIndex = rand.Next(0, arr.Length); // индекс случайного элемента, который первым включим в подмножество
            while (arr[randIndex] > nmb)
            {
                randIndex = rand.Next(0, arr.Length); // проверим, подходит ли случайно выбранное число под условие < M
            }
            result.Add(arr[randIndex]);


            int sum = arr[randIndex];

            for (int i = 0; i < arr.Length; i++) // а дальше по порядку переберем все элементы
            {
                if (i != randIndex && (sum + arr[i]) <= nmb)
                {
                    result.Add(arr[i]);
                    sum += arr[i];
                }

            }
            for (int i = 0; i < result.Count; i++)
            {
                Console.Write($"{result[i]}\t");
            }
        }


        static bool CheckIsValid(int[] arr, int nmb) // проверим, есть ли в массиве хотя бы один элемент, меньший m?
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (nmb >= arr[i]) return true;
            }
            return false;
        }
    }
}



