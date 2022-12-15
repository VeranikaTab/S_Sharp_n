// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет


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

string ArrayFind(int[,] arr)
{
    int row = arr.GetLength(0);
    int column = arr.GetLength(1);
    Console.Write("Введите первую цифру индекса: ");
    int one = int.Parse(Console.ReadLine());
    Console.Write("Введите вторую цифру индекса: ");
    int two = int.Parse(Console.ReadLine());
    for (int i = 0; i < row; i++)
        for (int j = 0; j < column; j++)
            if (i >= one && j >= two) return $"Элемент на позиции {one} {two} принимает значение [{arr[i, j]}]";
    return "Такого числа в массиве нет";
}

Console.Write("Enter the number of rows: ");
int row = int.Parse(Console.ReadLine());
Console.Write("Enter the number of columns: ");
int column = int.Parse(Console.ReadLine());

int[,] arr_1 = MassNums(row, column,
                        int.Parse(Console.ReadLine()),
                        int.Parse(Console.ReadLine()));
Print(arr_1);

Console.Write(ArrayFind(arr_1));





