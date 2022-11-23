// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.

using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] array;
            array = CreateArray();
            ShowArray(array);
            int[,] descArray;
            descArray = SortArray(array);
            ShowArray(descArray);

            Console.ReadKey();
        }

        static int[,] CreateArray()
        {
            int[,] arr = new int[,] { { 1, 2, 10}, { 3, 4, 11 }, { 5, 6, 12 }, { 7, 8, 13} };
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

        static int[,] SortArray(int[,] arr)
        {
            int max;
            int temp = 0;
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                   for(int sort = j + 1; sort < arr.GetLength(1); sort++)
                    {
                        max = arr[i, j];

                        if (max < arr[i, sort])
                        {
                            temp = arr[i, j];
                            arr[i, j] = arr[i, sort];
                            arr[i, sort] = temp;
                        }
                    }
                }                
            }
            
            return arr;
        }
    }
}
