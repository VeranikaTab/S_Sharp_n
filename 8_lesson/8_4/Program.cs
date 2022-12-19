// Задача 5: Вывести первые N строк треугольника Паскаля. Сделать вывод в виде равнобедренного треугольника

void Main(string[] args)
{

    Console.WriteLine("Треугольник Паскаля");
    Console.Write("Введите нужное количество строк треугольника Паскаля:: ");
    string input = Console.ReadLine();
    int n = Convert.ToInt32(input);

    for (int y = 0; y < n; y++)
    {
        int c = 1;
        for (int q = 0; q < n - y; q++)
        {
            Console.Write("   ");// создаём пробелы между элементами треугольника
        }
        for (int x = 0; x <= y; x++)
        {
            Console.Write("   {0:D} ", c);
            c = (c * (y - x) / (x + 1));
        }
        Console.WriteLine();
        Console.WriteLine();
    }
    Console.WriteLine();
}
Main(args);



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