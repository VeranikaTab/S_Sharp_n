// Задача 19 Напишите программу, которая принимает на вход пятизначное число 
// и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да


void palindrom(int number)
{
    int num1 = number / 10000;
    int num2 = number / 1000 % 10;
    int num4 = number / 10 % 10;
    int num5 = number % 10; 

    if (num1 == num5 && num2 == num4)
    {
        Console.WriteLine(number + " -> число палиндром");
    }
    else
    {
        Console.WriteLine(number + " -> число не палиндром");
    }
}
palindrom(int.Parse(Console.ReadLine()));

//
palindrom(14212);
palindrom(12821);
palindrom(23432);