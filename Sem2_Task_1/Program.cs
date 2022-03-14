// Задача 1. Написать программу, которая определяет, является ли треугольник со сторонами a, b, c равнобедренным

using System;

namespace Sem2_Task_1
{
    class Program
    {
        static void Main(string[] args) 

        {
            int i, n = 3;
            int[] sides = new int[n];


            Console.WriteLine("Введите длину сторон треугольника через пробел: 'a b c'");
            string[] str = Console.ReadLine().Split(new char[] { ' ', '\n', '\t' }, StringSplitOptions.RemoveEmptyEntries);
            for (i = 0; i < (n < str.Length ? n : str.Length); ++i)
                sides[i] = Convert.ToInt32(str[i]);

            int a = sides[0];
            int b = sides[1];
            int c = sides[2];

            if ((a == b) | (a == c) | (b == c)) Console.WriteLine($"Треугольник ({a}, {b}, {c}) равнобедренный");
            else Console.WriteLine($"Треугольник ({a}, {b}, {c}) не равнобедренный");


        }


    }
}