// 0. Напишите программу, которая выводит случайное число
//    из отрезка [10, 99] и показывает наибольшую цифру числа.

int MaxNum(int num)
{
    Console.WriteLine(num);
    int num_max = 0;
    
    while (num > 0)
    {
        if (num % 10 > num_max)
        {
            num_max = num % 10;
        }
        num = num / 10; 
    }
    return num_max;
}

Console.WriteLine(MaxNum(new Random().Next(10, 100)));


// 2 вариант

int MaxNumber(int a)
{
    Console.WriteLine(a);
    
    if (a % 10 > a / 10)
    {
        return a % 10;
    }
    else
    {
        return a / 10;
    }
}
Console.WriteLine(MaxNumber(new Random().Next(10, 100)));