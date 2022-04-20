// Задача 1. Даны два числа a, b. Сложите их, используя только операции инкремента и декремента.


using System;


namespace Sem10_Task_1
{
    class Program
    {
        static void Main(string[] args)

        {
            int a = 68;
            int b = -5;

            Console.WriteLine(Sum(a, b));
        }
        static int Sum(int nmbA, int nmbB)
        {
            if (nmbB > 0)
            {
                for (int i = 0; i < Math.Abs(nmbB); i++, nmbA++);
                return nmbA;
            }
            else
            {
                for (int i = 0; i < Math.Abs(nmbB); i++, nmbA--);
                return nmbA;
            }

        }
    }
}

