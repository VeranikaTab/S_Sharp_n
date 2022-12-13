// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

void Print(int[,] arr)
{
    int row_size = arr.GetLength(0);
    int column_size = arr.GetLength(1);

    for (int i = 0; i < row_size; i++)
    {
        for (int j = 0; j < column_size; j++)
            Console.Write($" {arr[i, j],4}  ");
        Console.WriteLine();
    }
    Console.WriteLine();
}

int[,] ArrayVN(int row, int column, int from, int to)
{
    int[,] arr = new int[row, column];

    for (int i = 0; i < row; i++)
        for (int j = 0; j < column; j++)
            arr[i, j] = new Random().Next(from, to);
    return arr;
}

void SrArifmColumn(int[,] arr)
{
    double sum = 0, sum1 = 0, sum2 = 0, sum3 = 0;
    int row = arr.GetLength(0);
    int column = arr.GetLength(1);
    int i = 0;
    int j = 0;
    for (i = 0; i < row; i++)
        for (j = 0; j < column; j++)
            if (j == 0) sum = (arr[i, 0] + sum);
            else if (j == 1) sum1 = (arr[i, 1] + sum1);
            else if (j == 2) sum2 = (arr[i, 2] + sum2);
            else if (j == 3) sum3 = (arr[i, 3] + sum3);
    Console.WriteLine($"Cреднее арифметическое элементов в каждом столбце:");
    Console.Write($"{Math.Round((sum / row), 1),4} | {Math.Round((sum1 / row), 1),4} | {Math.Round((sum2 / row), 1),4} | {Math.Round((sum3 / row), 1),4} ");
}

Console.Write("Enter the number of rows: ");
int row = int.Parse(Console.ReadLine());
Console.Write("Enter the number of columns: ");
int column = int.Parse(Console.ReadLine());

int[,] arr_1 = ArrayVN(row, column,
                        int.Parse(Console.ReadLine()),
                        int.Parse(Console.ReadLine()));
Print(arr_1);

SrArifmColumn(arr_1);

