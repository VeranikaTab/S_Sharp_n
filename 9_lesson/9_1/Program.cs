// 2. Задайте значения M и N. Напишите программу, которая 
//    рекурсивно выведет все натуральные числа в промежутке от M до N.



void Numbers(int m, int n)
{
    if (m > n) return;
    
    Console.Write($"{m} ");
    Numbers(m + 1, n);
}
Console.WriteLine("Введите значение m: ");
int m = int.Parse(Console.ReadLine());
Console.WriteLine("Введите значение n: ");
int n = int.Parse(Console.ReadLine());
Numbers(m, n);

// 2-й вариант

void Numbers(int m, int n)
{

    if (m > n) return;

    Console.Write($" {m} ");
    Numbers(m + 1, n);
}

Numbers(5, 8);
