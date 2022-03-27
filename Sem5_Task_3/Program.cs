// Задача 3. Найдите все числа от 1 до 1000000, сумма цифр которых в три раза меньше их произведений. Подсчитайте их количество.

using System;
//using System.Globalization;

namespace Sem5_Task_3
{
    class Program
    {
        static void Main(string[] args)

        {

            string numbStr; // число в формате строки
            
            for (int i = 1; i <= 1000000; i++)
            {
                int amount = 0; // сюда будем записывать сумму
                int product = 1; // сюда будем записывать произведение

                numbStr = Convert.ToString(i);

                for (int j = 0; j < numbStr.Length; j++)
                {
                    amount += (int)Char.GetNumericValue(numbStr[j]);
                    product *= (int)Char.GetNumericValue(numbStr[j]);

                }

                if (product == amount * 3)
                {
                    Console.WriteLine($"Ссумма цифр в числе {i} равна {amount} и она в три раза меньше, чем их произведение: {product}");
                }

            }
            
           
        }


    }


}





