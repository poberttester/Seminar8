// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
using System;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] array1 = new int[,] { {2, 1, 1}, {3, 0, 1}, {5, 1, 6} };
            int[,] array2 = new int[,] { {3, 1, 2}, {2, 1, 4}, {1, 0, 5} };

            
            ShowArray(array1);
            ShowArray(array2);

            int[,] resultArray;
            resultArray = MultiplicationOfMatrices(array1, array2);

            ShowArray(resultArray);

            Console.ReadKey();
        }

        

        static void ShowArray(int[,] arr)
        {
            Console.WriteLine(String.Empty);
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    Console.Write($"{arr[i, j], 5}");
                }
                Console.WriteLine(String.Empty);
                Console.WriteLine(String.Empty);
            }
            Console.WriteLine(String.Empty);
        }

        static int[,] MultiplicationOfMatrices(int[,] arr1, int[,] arr2)    // Программа перемножает только квадратные матрицы.
        {
            int [,] resultArr = new int[arr1.GetLength(0), arr1.GetLength(1)];
            
            for (int i = 0; i < arr1.GetLength(0); i++)
            {
                for (int j = 0; j < arr2.GetLength(1); j++)
                {
                    for (int k = 0; k < arr2.GetLength(0); k++)
                    {
                        resultArr[i, j] += arr1[i, k] * arr2[k, j];
                    }
                }
            }
            Console.WriteLine("Результирующая матрица будет:");
            return resultArr;
        }
    }
}
