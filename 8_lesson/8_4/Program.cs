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



