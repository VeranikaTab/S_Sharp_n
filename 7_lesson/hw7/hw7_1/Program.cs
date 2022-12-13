﻿// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

void Print(double[,] arr)
{
    int row_size = arr.GetLength(0);
    int column_size = arr.GetLength(1);

    for (int i = 0; i < row_size; i++)
    {
        for (int j = 0; j < column_size; j++)
            Console.Write($"{Math.Round(arr[i, j],2)}  ");
        Console.WriteLine();
    }
    Console.WriteLine();
}

double[,] ArrayVN(int row, int column, int from, int to)
{
    double[,] arr = new double[row, column];
    Random random = new Random();
        
    for (int i = 0; i < row; i++)
        for (int j = 0; j < column; j++)
            arr[i, j] = random.Next(from, to) + random.NextDouble();

    return arr;   
}

Console.Write("Enter the number of rows: ");
int row = int.Parse(Console.ReadLine());
Console.Write("Enter the number of columns: ");
int column = int.Parse(Console.ReadLine());

double[,] arr_1 = ArrayVN(row, column,
                        int.Parse(Console.ReadLine()),
                        int.Parse(Console.ReadLine()));
Print(arr_1);

