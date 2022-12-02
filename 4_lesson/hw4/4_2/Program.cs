// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

int SumNumbCount(int num)
{
    if(num == 0)
    {
        return(1);
    }
    int count = 0;
    int sum = 0;
    while (num > 0)
    {
        int ponum = num % 10;
        sum = sum + ponum;
        num = num / 10;
        count++;
    }
    return sum; 
    
}
Console.WriteLine(SumNumbCount(int.Parse(Console.ReadLine())));
