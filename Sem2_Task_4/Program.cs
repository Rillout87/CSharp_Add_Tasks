// Задача 4. Дано натуральное число, в котором все цифры различны. Определить, какая цифра расположена в нем левее: максимальная или минимальная.


using System;


namespace Sem2_Task_4
{
    class Program
    {
        static void Main(string[] args)

        {
            Start:
            Console.Write("Введите натуральное число: ");
            string number =  Console.ReadLine();
            
            int max = (int)Char.GetNumericValue(number[0]); int min = (int)Char.GetNumericValue(number[0]);
            int IndexMax = 0, IndexMin = 0;
            int j;

            if ((number.Length == 1) || ((int)Char.GetNumericValue(number[0]) < 0) || !int.TryParse(number, out j))
            {
                Console.WriteLine("Вы ввели слишком короткое или отрицательное число, или присутствуют посторонние символы. Введите натуральное число минимум из 2х цифр");
                goto Start;
            }

            var checkDuplicates = new List<char>();
            //var duplicates = new List<char>();

            for (int x = 0; x < number.Length; x++)
            {
                if (!checkDuplicates.Contains(number[x]))
                {
                    checkDuplicates.Add(number[x]);
                }
                else
                {
                    Console.WriteLine("Цифры не должны повторяться!");
                    goto Start;
                }
            }


            for (int i = 1; i < number.Length; i++)
            {

                if ((int)Char.GetNumericValue(number[i]) > max)
                {
                    max = (int)Char.GetNumericValue(number[i]); IndexMax = i;
                }
                if ((int)Char.GetNumericValue(number[i]) < min)
                {
                    min = (int)Char.GetNumericValue(number[i]); IndexMin = i;
                }
                
            }
            if (IndexMax < IndexMin) Console.WriteLine($"Левее расположена Максимальная цифра {max}");
            else Console.WriteLine($"Левее расположено миниамальная цифра {min}");

        }


    }


}
