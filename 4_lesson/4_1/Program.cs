// Задача 1: Напишите программу, которая принимает
// на вход число и выдаёт количество цифр в числе.
// 456 -> 3
// 78 -> 2
// 89126 -> 5 

int NumCount_1(ulong num)
{   
    int res = 0; 

    for (int result = 1; num > 0; result++)
    {
        num /= 10;
        res = result;
    }
    return res;
}

ulong answer = ulong.Parse(Console.ReadLine());
Console.WriteLine(NumCount_1(answer));

// 2 вариант

int NumCount_2(long num)
{
    int result = 0;

    while (num > 0)
    {
        num /= 10;
        result += 1;
    }
    return result;
}

Console.WriteLine(NumCount_2(long.Parse(Console.ReadLine())));
