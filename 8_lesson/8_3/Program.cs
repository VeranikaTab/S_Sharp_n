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


// 4. Задайте двумерный массив из целых чисел. Напишите программу,
//    которая удалит строку и столбец, на пересечении которых расположен наименьший элемент массива.


void Print(int[,] arr)
{
    int row_size = arr.GetLength(0);
    int column_size = arr.GetLength(1);

    for (int i = 0; i < row_size; i++)
    {
        for (int j = 0; j < column_size; j++)
            Console.Write($" {arr[i, j],3} ");
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

int[] MinEl(int[,] arr)
{
    int row = arr.GetLength(0);
    int column = arr.GetLength(1);
    int min_num = arr[0, 0];
    int[] indexes = new int[2];

    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < column; j++)
            if (min_num > arr[i, j])
            {
                min_num = arr[i, j];
                indexes[0] = i;
                indexes[1] = j;
            }
    }
    Console.WriteLine(arr[indexes[0], indexes[1]]);
    return indexes;
}

void WithoutRowColumn(int[,] arr, int[] m_indexes)
{
    int row = arr.GetLength(0);
    int column = arr.GetLength(1);
    
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < column; j++)
            if (m_indexes[0] == i || m_indexes[1] == j) continue;
            else Console.Write($"{arr[i, j],3}");
        Console.WriteLine();
    }
    Console.WriteLine();
}

Console.Write("Enter the number of rows: ");
int row = int.Parse(Console.ReadLine());
Console.Write("Enter the number of columns: ");
int column = int.Parse(Console.ReadLine());

int[,] arr_1 = MassNums(row, column, -5, 10);
Print(arr_1);

int[] mass = MinEl(arr_1);
WithoutRowColumn(arr_1, mass);


// 4. Задайте двумерный массив из целых чисел. Напишите программу,
//    которая удалит строку и столбец, на пересечении которых расположен наименьший элемент массива.


void Print(int[,] arr)
{
    int row_size = arr.GetLength(0);
    int column_size = arr.GetLength(1);

    for (int i = 0; i < row_size; i++)
    {
        for (int j = 0; j < column_size; j++)
            Console.Write($" {arr[i, j],3} ");
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

int[] MinEl(int[,] arr)
{
    int row = arr.GetLength(0);
    int column = arr.GetLength(1);
    int min_num = arr[0, 0];
    int[] indexes = new int[2];

    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < column; j++)
            if (min_num > arr[i, j])
            {
                min_num = arr[i, j];
                indexes[0] = i;
                indexes[1] = j;
            }
    }
    Console.WriteLine(arr[indexes[0], indexes[1]]);
    return indexes;
}

int[,] WithoutRowColumn(int[,] arr, int[] m_indexes)
{
    int k = 0;
    int p = 0;
    int row = arr.GetLength(0);
    int column = arr.GetLength(1);
    int[,] new_matr = new int[row - 1, column - 1];

    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < column; j++)
        {
            if (m_indexes[0] != i && m_indexes[1] != j)
            {
                new_matr[k, p] = arr[i, j];
                p += 1;
            }
        }
        p = 0;        
        if (m_indexes[0] != i) k += 1;        
    }
    return new_matr;
}

Console.Write("Enter the number of rows: ");
int row = int.Parse(Console.ReadLine());
Console.Write("Enter the number of columns: ");
int column = int.Parse(Console.ReadLine());

int[,] arr_1 = MassNums(row, column, 1, 10);
Print(arr_1);

int[] mass = MinEl(arr_1);
int[,] arr_2 = WithoutRowColumn(arr_1, mass);
Print(arr_2);