// Задача 2. На вход подаётся поговорка “без труда не выловишь и рыбку из пруда”.
// Используя рекурсию, подсчитайте, сколько в поговорке гласных букв.

using System;
//using System.Globalization;

namespace Sem6_Task_2
{
    class Program
    {
        static void Main(string[] args)

        {
            string proverb = "без труда не выловишь и рыбку из пруда";
            string vowels = "уеёыаоэяию";

            VowelCount(proverb, vowels);

        }
        static void VowelCount(string saying, string vow, int count = 0, int i = 0, int j = 0)
        {

            
            if (j == vow.Length && i == saying.Length) Console.WriteLine(count);
            
            if (i < saying.Length)
            {

                if (saying[i] == vow[j]) count++;

                VowelCount(saying, vow, count, ++i, j);
            }
            if (j < vow.Length)
            {
                
                if (saying[i] == vow[j]) count++;
                
                VowelCount(saying, vow, count, i=0, ++j);
                                
            }
            
            
        }

        


    }


}
