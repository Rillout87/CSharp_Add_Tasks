// Задача 2. На вход подаются год, номер месяца и день рождения человека, Определить возраст человека на момент 1 февраля 2022 года.


using System;
using System.Globalization;

namespace Sem2_Task_2
{
    class Program
    {
        static void Main()

        {

            Console.Clear();
            var cultureInfo = new CultureInfo("en-GB");


            Console.WriteLine("Введите дату рождения в формате ДД.ММ.ГГГГ");
            string BirthDateString = Console.ReadLine();

            try
            {

                DateTime BirthDate = DateTime.ParseExact(BirthDateString, "dd.MM.yyyy", cultureInfo);


                DateTime CurrentDate = new DateTime(2022, 02, 01, 00, 00, 00);
                int Age = CurrentDate.Year - BirthDate.Year;


                if (BirthDate.Date > CurrentDate.AddYears(-Age)) Age--;

                if (Age%10 == 1) Console.WriteLine($"Возраст на 1 февраля 2022 {Age} год");
                else if ((Age%10 > 1) && (Age%10 < 5)) Console.WriteLine($"Возраст на 1 февраля 2022 {Age} года");
                else Console.WriteLine($"Возраст на 1 февраля 2022 {Age} лет");
                
            }   
            catch (FormatException)
            {
                Console.WriteLine("Дата введена в неверном формате");
            }



        
        }


    }


}
