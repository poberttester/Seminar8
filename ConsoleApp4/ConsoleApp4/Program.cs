// Задача 60. Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
using System;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,,] resultArray;
            resultArray = CreateArray();

            ShowArray(resultArray);

            Console.ReadKey();
        }



        static void ShowArray(int[,,] arr)
        {
            const int cellWidth = 5;

            Console.WriteLine(String.Empty);
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    for (int k = 0; k < arr.GetLength(2); k++)
                    {
                        Console.Write($"{arr[i, j, k], cellWidth}({ i}, {j}, {k})" );
                    }
                    Console.WriteLine(String.Empty);
                }

                Console.WriteLine(String.Empty);
            }
            Console.WriteLine(String.Empty);
        }

        static int[,,] CreateArray()
        {
            Random rand = new Random();
            int value = rand.Next(1, 11);

            int[,,] arr = new int[3, 3, 4];

            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    for (int k = 0; k < arr.GetLength(2); k++)
                    {
                        value += k + 1; // В данной строке генерируются УНИКАЛЬНЫЕ числа.
                        arr[i, j, k] = value;
                    }
                }
            }

            return arr;
        }
    }
}
