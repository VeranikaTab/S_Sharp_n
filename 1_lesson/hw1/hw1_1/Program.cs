// Задача 2: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

Console.WriteLine("Введите число 1: ");
int a1 = int.Parse(Console.ReadLine());

Console.WriteLine("Введите число 2: ");
int a2 = int.Parse(Console.ReadLine());

Console.WriteLine("Введите число 3: ");
int a3 = int.Parse(Console.ReadLine());
int max = a1;
if (a1 > max)
{
    max = a1;
}
if (a2 > max)
{
    max = a2;
}
if (a3 > max)
{
    max = a3;
}
Console.Write("max: "+ max);