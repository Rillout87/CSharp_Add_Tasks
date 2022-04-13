// Задача 2. Известно, что пароль длиной 3 символа состоит из латинских букв строчного регистра и цифр от 0 до 9.
// Напишите рекурсивный метод, который перебирает все комбинации паролей. 


// ДЕНИС, ЕСЛИ ВЫ ЭТО ЧИТАЕТЕ, ТО ЭТО ЗНАЧИТ, ЧТО НА ДАННЫЙ МОМЕНТ Я ЕЩЕ НЕ ДОДЕЛАЛ ЭТУ ЗАДАЧУ. ПРОШУ ПРОПУСТИТЬ - ДОДЕЛАЮ ПОТОМ САМ


using System;
//using System.Globalization;

namespace Sem9_Task_2
{
    class Program
    {
        static void Main(string[] args)

        {

            string passwordElements = "qwertyuiopasdfghjklzxcvbnm0123456789";
            string password = "s8j";

            HackPassword(password, passwordElements);
        }
        static string HackPassword(string pswrd, string passElems, int i = -1)
        {

            if (i < passElems.Length)
            {
                string currentPswrd = HackPassword(pswrd, passElems, ++i) + HackPassword(pswrd, passElems, ++i) + HackPassword(pswrd, passElems, ++i);
                if (currentPswrd == pswrd)
                {
                    Console.WriteLine($"Пароль подобран: {currentPswrd}");
                    return "";
                }
                else return Convert.ToString((passElems[i]));

            }
            return "";
        }
    }



}







