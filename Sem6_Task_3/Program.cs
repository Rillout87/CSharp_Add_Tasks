// Задача 3. Дано число N. Используя рекурсию, определите, что оно является степенью числа 3.

using System;
//using System.Globalization;

namespace Sem6_Task_3
{
    class Program
    {
        static void Main(string[] args)

        {
            int number = 81;
            IsPower(number);

        }

            static void IsPower(int nmb, int found = 1, int degree = 0)
        {
            if (found == nmb) Console.WriteLine($"Число {nmb} является {degree} степенью числа 3");
            //else if ()

            else if (found < nmb)
            {
                found *= 3;
                degree++;
                IsPower(nmb, found, degree);


            }

        }


    }


}








