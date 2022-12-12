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

// 1. Напишите программу, которая принимает на вход
//    пятизначное число и проверяет, является ли оно палиндромом.

string Palindrome(int n)
{  
    int num = 10000;
    if (n > 100000 || n < 10000)
        return "The number is not five-digit!";
    else        
        while (num > 1)
        {
            if (n / num % 10 != n % 10)
                return "no";
            n /= 10;
            num /= 100;
        }    
        return "yes";
}

Console.WriteLine(Palindrome(int.Parse(Console.ReadLine())));


// Через строки

void Palindrome_1(int n)
{
    int i = 0;
    string num = n.ToString();
    int size = num.Length - 1;
    string flag = "yes";
    
    while (i < size / 2)
    {
        if (num[i] != num[size - i]) 
        {
            flag = "no";
            break;
        }        
        i += 1;
    }    
    Console.WriteLine($"{n} -> {flag}");
}

Palindrome_1(14212);
Palindrome_1(23432);
Palindrome_1(12821);
Palindrome_1(1248421);
<<<<<<< HEAD
Palindrome_1(12488421);
=======
Palindrome_1(12488421);
>>>>>>> 6_lesson
