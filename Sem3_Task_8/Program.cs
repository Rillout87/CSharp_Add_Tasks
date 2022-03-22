// Задача 8. Массив из ста элементов заполняется случайными числами от 1 до 100. Удалить из массива все элементы, содержащие цифру 3. Вывести в консоль новый массив и количество удалённых элементов.

using System;


namespace Sem3_Task_8
{
    class Program
    {
        static void Main()

        {
            
            Random rand = new Random();
            int[] numbers = new int[100];
            int count = 0;
            
            int[] FillArray(int[] arr)
            {
                for (int i = 0; i < arr.Length; i++)
                {
                    arr[i] = rand.Next(1, 100);
                }
                return arr;
            }

            bool IsContain (string str, string nmb)
            {
                bool check = str.Contains(nmb);
                return check;
            }

            int NewArrayLenght(int[] ar)
            {
                int cnt = 0;
                for (int j = 0; j < ar.Length; j++)
                {
                    if (!IsContain(Convert.ToString(numbers[j]), "3"))
                    {
                        cnt++;
                    }
                }
                return cnt;
            }

            FillArray(numbers);

            int[] newNumbers = new int[NewArrayLenght(numbers)];

            for (int i = 0; i < numbers.Length; i++)
            {
                if (!IsContain(Convert.ToString(numbers[i]), "3"))
                {
                    newNumbers[count] = numbers[i];
                    count++;
                }
                
            }
            
                        
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write(numbers[i] + " ");
            }
            Console.WriteLine();
            Console.WriteLine("----");
            for (int i = 0; i < newNumbers.Length; i++)
            {
                Console.Write(newNumbers[i] + " ");
            }
            Console.WriteLine();
            Console.WriteLine("----");
            Console.WriteLine(100-count);

        }


    }


}

