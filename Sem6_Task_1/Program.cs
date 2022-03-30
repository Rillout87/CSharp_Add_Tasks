// Задача 1. Написать перевод десятичного числа в двоичное, используя рекурсию.

using System;
//using System.Globalization;

namespace Sem6_Task_1
{
    class Program
    {
        static void Main(string[] args)

        {
            int decimalNumber = 59112;
            ConvertToBinary(decimalNumber);

        }
        static void ConvertToBinary(int decNmb, string binaryNumber = "")
        {
            if (decNmb == 1) Console.WriteLine(decNmb + binaryNumber);

            if (decNmb > 1)
            {
                binaryNumber = decNmb % 2 + binaryNumber;
                decNmb /= 2;
                ConvertToBinary(decNmb, binaryNumber);
            }
            
        }

        


    }


}







