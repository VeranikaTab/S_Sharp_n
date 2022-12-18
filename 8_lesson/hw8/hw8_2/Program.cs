// Задача 2: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

Console.Write("Enter the number of rows: ");
int row = int.Parse(Console.ReadLine());
Console.Write("Enter the number of columns: ");
int column = int.Parse(Console.ReadLine());

int[,] arr_1 = MassNums(row, column,
                        int.Parse(Console.ReadLine()),
                        int.Parse(Console.ReadLine()));

Print(arr_1);
RowMinSumma(arr_1);


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

int[,] MassNums(int row, int column, int from, int to)
{
    int[,] arr = new int[row, column];

    for (int i = 0; i < row; i++)
        for (int j = 0; j < column; j++)
            arr[i, j] = new Random().Next(from, to);
    return arr;
}

void RowMinSumma(int[,] arr_1)
{
    int sum = 0;
    int sumM = 0;
    int rows = 0;
    for (int i = 0; i < row; i++)
    {
        int sumRow = 0;
        for (int j = 0; j < column; j++)
        {
            sumRow = arr_1[i, j] + sumRow;
        }
        if (sumRow < sum)
        {
            sumM = sumRow;
            rows = i;
        }
        sum = sumRow;
        Console.WriteLine($"Сумма элементов равна {sum} и находится на {i + 1} строке");
    }
    Console.WriteLine($"Номер строки с наименьшей суммой элементов: {rows + 1} строка");
    Console.WriteLine();
}



// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка



