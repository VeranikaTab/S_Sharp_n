// Задача 3: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

Console.Write("Введите количество строк первой матрицы: ");
int row = int.Parse(Console.ReadLine());
Console.Write("Введите количество столбцов первой матрицы: ");
int column = int.Parse(Console.ReadLine());
int[,] arr_1 = MassNums(row, column,
                        int.Parse(Console.ReadLine()),
                        int.Parse(Console.ReadLine()));
Console.Write("Введите количество строк второй матрицы: ");
int row2 = int.Parse(Console.ReadLine());
Console.Write("Введите количество столбцов второй матрицы: ");
int column2 = int.Parse(Console.ReadLine());
int[,] arr_2 = MassNums(row2, column2,
                        int.Parse(Console.ReadLine()),
                        int.Parse(Console.ReadLine()));
int[,] matrix = new int[row, column2];

Print(arr_1);
Print(arr_2);
ProizvedenieDvuhMatric(matrix);
Print(matrix);

void Print(int[,] arr)
{
    int row_size = arr.GetLength(0);
    int column_size = arr.GetLength(1);

    for (int i = 0; i < row_size; i++)
    {
        for (int j = 0; j < column_size; j++)
            Console.Write($" {arr[i, j],4} ");
        Console.WriteLine();
    }
    Console.WriteLine();
}

int[,] MassNums(int row, int column, int from, int to)
{
    int[,] arr = new int[row, column];

    for (int i = 0; i < row; i++)
        for (int j = 0; j < column; j++)
            arr[i, j] = new Random().Next(from, to);
    return arr;
}

void ProizvedenieDvuhMatric(int[,] matrix)
{
    if (column == row2)
    {
        Console.WriteLine("Произведение матриц: ");
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                int sum = 0;
                for (int k = 0; k < arr_1.GetLength(1); k++)
                {
                    sum += arr_1[i, k] * arr_2[k, j];
                }
                matrix[i, j] = sum;
            }
            Console.WriteLine();
        }
    }
    else Console.WriteLine("Произведение двух матриц невозможно, т.к. число столбцов первой матрицы не совпадает с числом строк второй матрицы.");

}



