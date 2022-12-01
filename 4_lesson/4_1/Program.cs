// Задача 1: Напишите программу, которая принимает
// на вход число и выдаёт количество цифр в числе.
// 456 -> 3
// 78 -> 2
// 89126 -> 5 

int NumbCount(int n)
{
    if(n == 0)
    {
        return(1);
    }
    int count = 0;
    while (n > 0)
    {
        n = n/10;
        count++;
    }
    return count; 
    
}
Console.WriteLine(NumbCount(int.Parse(Console.ReadLine())));
