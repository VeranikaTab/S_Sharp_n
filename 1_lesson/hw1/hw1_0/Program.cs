// Задача 1: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

Console.WriteLine("Введите число 1: ");
int a1 = int.Parse(Console.ReadLine());

Console.WriteLine("Введите число 2: ");
int a2 = int.Parse(Console.ReadLine());
int max = 0;
int min = 0;
if (a1 > a2)
{
    max = a1;
    min = a2;
}
else
{
    max = a2;
    min = a1;
}
Console.WriteLine("max: " +max);
Console.Write("min: "+min);