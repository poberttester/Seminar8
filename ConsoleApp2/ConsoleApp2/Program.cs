// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] array;
            array = CreateArray();
            ShowArray(array);
            SmallestAmount(array);

            Console.ReadKey();
        }

        static int[,] CreateArray()
        {
            int[,] arr = new int[,] { { 1, 2, 10 }, { 3, 4, 11 }, { 5, 6, 12 }, { 7, 8, 13 } };
            return arr;
        }

        static void ShowArray(int[,] arr)
        {
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    Console.Write(arr[i, j] + " ");
                }
                Console.WriteLine(String.Empty);
            }
            Console.WriteLine(String.Empty);
        }

        static void SmallestAmount(int[,] arr)
        {

            int summ;            
            int minValue = int.MaxValue; // верхний предел из диапазона integer
            int minString = 0;            

            for (int i = 0; i < arr.GetLength(0); i++)
            {
                summ = 0; // обнуляем значение суммы.

                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    summ = summ + arr[i, j];                    
                }
               

                if (minValue > summ) // сравниваем с самым большим числом на случай если все суммы будут отрицательными.
                {
                    minValue = summ; // минимальное значение в строке не используется по условию задачи.
                    minString = i;
                }
            }
            Console.WriteLine($"Номер строки с наименьшей суммой элементов: {minString}");
        }
    }
}
