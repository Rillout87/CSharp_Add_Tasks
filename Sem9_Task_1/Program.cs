// Задача 1. Дано предложение. Напишите рекурсивный метод, подсчитывающий количество слов в данном предложении.
// Словом считается последовательность символов без пробелов.

using System;
//using System.Globalization;

namespace Sem9_Task_2
{
    class Program
    {
        static void Main(string[] args)

        {

            string sentence = "Без труда - не вытянешь и рыбку из пруда.";
            WordsCount(sentence);

        }

        static void WordsCount(string text, int i = 0, int count = 0)
        {
            if (i < text.Length)
            {
                if (Convert.ToString(text[i]) != " ") WordsCount(text, ++i, count);
                else
                {
                    count++;
                    WordsCount(text, ++i, count);
                }
            }
            else Console.WriteLine($"В данном предложении {count + 1} слов");
        }
    }



}








