// Задача 62.Напишите программу, которая заполнит спирально массив 4 на 4.
using System;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] array = new int[4, 4];
            int[,] newArray;

            newArray = FillArray(array);
            ShowArray(newArray);

        }


        static void ShowArray(int[,] arr)
        {
            const int cellWidth = 5;

            Console.WriteLine(String.Empty);
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    Console.Write($"{arr[i, j],cellWidth} ");
                }
                Console.WriteLine(String.Empty);
            }
            Console.WriteLine(String.Empty);

        }

        static int[,] FillArray(int[,] arr)
        {
            int n = arr.GetLength(0);
            int m = arr.GetLength(1);

            int[,] result = new int[n, m];

            int row = 0, col = 0, dx = 1, dy = 0, dirChanges = 0, gran = m;
            for (int i = 0; i < result.Length; i++)
            {
                result[row, col] = i + 1;
                if (--gran == 0)
                {
                    gran = m * (dirChanges % 2) + n * ((dirChanges + 1) % 2) - (dirChanges / 2 - 1) - 2;
                    int temp = dx;
                    dx = -dy;
                    dy = temp;
                    dirChanges++;
                }
                col += dx;
                row += dy;
            }

            return result;
        }


    }
}
