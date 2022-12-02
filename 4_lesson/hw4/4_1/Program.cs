// Задача 25: Напишите цикл, который принимает на вход два числа (A и B)
// и возводит число A в натуральную степень B. Без модуля Math, используем цикл for.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

int Step(int num)
{
    int n = int.Parse(Console.ReadLine());
    Console.Write($"{num} в степени ");
    Console.Write($"{n}-> ");
    
    int result = num;
    for (int i = 1; i < n; i++)
    {
        result *= num; 
    }
    return result;
}
Console.WriteLine(Step(int.Parse(Console.ReadLine())));




