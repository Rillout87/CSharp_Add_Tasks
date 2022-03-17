// Задача 3. Иван в январе года открыл счет в банке, вложив 1000 руб. Через каждый месяц размер вклада увеличивается на 1.5% от имеющейся суммы. Определить размер депозита через n месяцев.


using System;
using System.Globalization;

namespace Sem2_Task_3
{
    class Program
    {
        static void Main()

        {

            Console.Clear();
            Console.WriteLine("Введите количество месяцев");
            double MonthCount = Convert.ToDouble(Console.ReadLine());

            double deposit = 1000;
            Console.WriteLine(deposit * Math.Pow(1.015, MonthCount));

        
        }


    }


}
