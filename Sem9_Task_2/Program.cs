// Задача 2. Известно, что пароль длиной 3 символа состоит из латинских букв строчного регистра и цифр от 0 до 9.
// Напишите рекурсивный метод, который перебирает все комбинации паролей. 


using System;


namespace Sem9_Task_2
{
    class Program
    {
        static void Main(string[] args)

        {

            string passwordElements = "qwertyuiopasdfghjklzxcvbnm0123456789";
            char[] password = {'s','8','j'};
            bool wasHacked = false;


            HackPassword(password, passwordElements, new char[password.Length], ref wasHacked);
        }
        static void HackPassword(char[] pswrd, string passElems, char[] currentPswrd, ref bool wasHckd, int length = 0)
        {
            if(wasHckd) return;

            if (new String(currentPswrd) == new String(pswrd))
            {
                Console.WriteLine($"Пароль подобран: {new String(currentPswrd)}");
                wasHckd = true;
                return;
            }

            if (length < pswrd.Length)
            {

                for (int i = 0; i < passElems.Length; i++)
                {

                    currentPswrd[length] = passElems[i];

                    HackPassword(pswrd, passElems, currentPswrd, ref wasHckd, length + 1);
                }
            
            
            }

        }
    }



}







