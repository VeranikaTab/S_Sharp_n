// Задача 4: Задайтедвумерный массив из целых чисел. Напишите программу, которая удалит строку и столбец, на
// пересечении которых расположен наименьший элемент массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Наименьший элемент - 1, на выходе получим следующий массив:
// 9 4 2
// 2 2 6
// 3 4 7

void Print(int[,] arr)
{
    int row_size = arr.GetLength(0);
    int column_size = arr.GetLength(1);

    for (int i = 0; i < row_size; i++)
    {
        for (int j = 0; j < column_size; j++)
            Console.Write($" {arr[i, j]} ");
        Console.WriteLine();
    }
    Console.WriteLine();
}
int[,] MassNums()
{
    int[,] arr = new int[4, 4];

    for (int i = 0; i < 4; i++)
        for (int j = 0; j < 4; j++)
            arr[i, j] = new Random().Next(0, 9);
    return arr;
}
int[,] DelColumRowNaPeresecheniiMin(int[,] arr)
{
    (int, int) minIndex = (0, 0);
    for (int i = 0; i < arr.GetLength(0); i++)
        for (int j = 0; j < arr.GetLength(1); j++)
            if (arr[minIndex.Item1, minIndex.Item2] > arr[i, j]) minIndex = (i, j);
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            if (i == minIndex.Item1 | j == minIndex.Item2) continue;
            Console.Write($"{arr[i, j]} ");
        }
        Console.WriteLine();
    } return arr;
}
int[,] arr_1 = MassNums();
Print(arr_1);
int[,] mass = DelColumRowNaPeresecheniiMin(arr_1);

// Задача 4: Задайтедвумерный массив из целых чисел. Напишите программу, которая удалит строку и столбец, на
// пересечении которых расположен наименьший элемент массива.
// Например, задан массив:

void Print(int[,] arr)
{
    int row_size = arr.GetLength(0);
    int column_size = arr.GetLength(1);

    for (int i = 0; i < row_size; i++)
    {
        for (int j = 0; j < column_size; j++)
            Console.Write($" {arr[i, j]} ");
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
int[,] DelColumRowNaPeresecheniiMin(int[,] arr)
{
    (int, int) minIndex = (0, 0);
    for (int i = 0; i < arr.GetLength(0); i++)
        for (int j = 0; j < arr.GetLength(1); j++)
            if (arr[minIndex.Item1, minIndex.Item2] > arr[i, j]) minIndex = (i, j);
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            if (i == minIndex.Item1 | j == minIndex.Item2) continue;
            Console.Write($"{arr[i, j]} ");
        }
        Console.WriteLine();
    } return arr;
}
Console.Write("Enter the number of rows: ");
int row = int.Parse(Console.ReadLine());
Console.Write("Enter the number of columns: ");
int column = int.Parse(Console.ReadLine());
int[,] arr_1 = MassNums(row, column,
                        int.Parse(Console.ReadLine()),
                        int.Parse(Console.ReadLine()));
Print(arr_1);
int[,] mass = DelColumRowNaPeresecheniiMin(arr_1);


// int[,] arr = new int[4, 4];
// arr = DNPTools.FillIntMatrix(arr, 0, 9);
// DNPTools.PrintArr(arr);
// (int, int) minIndex = (0, 0);
// for (int i = 0; i < arr.GetLength(0); i++)
//    for (int j = 0; j < arr.GetLength(1); j++)
//        if (arr[minIndex.Item1, minIndex.Item2] > arr[i, j]) minIndex = (i, j);
// for (int i = 0; i < arr.GetLength(0); i++)
// {
//    for (int j = 0; j < arr.GetLength(1); j++)
//    {
//        if (i == minIndex.Item1 | j == minIndex.Item2) continue;
//        Console.Write($"{arr[i, j]} ");
//    }
//    Console.WriteLine();
// }

// DNPTools это класс с методами которые заранее заготовил для работы на семинаре



