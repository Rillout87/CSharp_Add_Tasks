// Задача 1. На вход подаётся натуральное десятичное число. Проверьте, является ли оно палиндромом в двоичной записи.

using System;
using System.Globalization;
//static System.Globalization.StringInfo;


namespace DZ_Task_29
{
    class Program
    {
        static void Main()

        {
            Console.WriteLine("Введите натуральное десятичное число");
            int decimalNumber = Convert.ToInt32(Console.ReadLine());
            //int decimalNumber = 403;

            string ConvertToBinary(int decNmb) //конвертируем их 10чной в 2чную запись (инвертированную)
            {

                int quotient = decNmb; // частное от деления
                int remainder; // остаток от деления
                string invertedBinNmb = ""; //инвертированное бинарное число

                while (quotient > 1)
                {
                    remainder = quotient % 2;
                    quotient /= 2;
                    invertedBinNmb += Convert.ToString(remainder);
                }
                invertedBinNmb += Convert.ToString(quotient);
                return invertedBinNmb;
            }

            string invertBinary(string invBinNmb) //инвертируем 2чное число
            {
                string rightBinNmb = "";
                for (int i = invBinNmb.Length-1; i >= 0; i--)
                {
                    rightBinNmb += invBinNmb[i];
                }
                return rightBinNmb;
            }

            void ChekPalindrome(string nmb) // проверяем на палиндром
            {
                
                int i = 0;
                while (i < nmb.Length/2)
                {
                    
                    int j = nmb.Length - i - 1;
                    
                    if (nmb [i] == nmb [j])
                    {
                        i++;
                        if (i == nmb.Length/2)
                        {
                            Console.WriteLine($"Число {nmb} - палиндром");
                            break;
                        }
                    }
                    else
                    {
                        Console.WriteLine($"Число {nmb} - не палиндром");
                        break;
                    }
                
                }

            }
            
            string binaryNumber = invertBinary(ConvertToBinary(decimalNumber));
            ChekPalindrome(binaryNumber);
        }
    }
}