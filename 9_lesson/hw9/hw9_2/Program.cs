// Задача 2: Задайте значения M и N. Напишите программу, которая найдёт сумму 
// натуральных элементов в промежутке от M до N с помощью рекурсии.
// M = 1; N = 15 -> 120
// M = 4; N = 8 -> 30

int NumbersSum(int m, int n)
{
    if (m > n) return 0;
    
        return m + NumbersSum((m + 1), n);
}

Console.Write("Введите число m: ");
int m = int.Parse(Console.ReadLine());
Console.Write("Введите число n: ");
int n = int.Parse(Console.ReadLine());
Console.Write($"Сумма натуральных элементов в промежутке от {m} до {n} = ");

Console.Write(NumbersSum(m, n));

// 2. Задайте значения M и N. Напишите программу, которая найдёт сумму
//    натуральных элементов в промежутке от M до N с помощью рекурсии.

int AllNumersSum(int M, int N)
{
    if (M > N) return 0;    
    return AllNumersSum(M, N - 1) + N;
}

Console.WriteLine(AllNumersSum(1, 15));
Console.WriteLine(AllNumersSum(4, 8));
