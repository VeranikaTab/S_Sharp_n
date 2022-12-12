// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

void KolM(string n)
{
    int sum = 0;
    Console.WriteLine($"Количество чисел более нуля -> {sum}");

    for (int count = 0; count >= 0; count++)
    {
        Console.WriteLine("Введите число");
        n = Console.ReadLine();
        if (int.Parse(n) > 0) sum = sum + 1;
        if (int.Parse(n) < 0) sum = sum + 0;
        if (n == " ") break;
        Console.WriteLine($"Количество чисел более нуля -> {sum}");
    }
}
Console.WriteLine("Введите число");
KolM(Console.ReadLine());

//2-й вариант
// 1. Пользователь вводит с клавиатуры M чисел. 
//    Посчитайте, сколько чисел больше 0 ввёл пользователь. 


int CountNum()
{
    int count = 0;
    string word;

    while (true)
    {
        Console.Write("Output any number: ");
        word = Console.ReadLine();

        if (word == "") return count;
        else if (int.Parse(word) > 0) count += 1;        
    }
}

Console.Write(CountNum());


// ----------------------------------------2 вариант

int Check(int num)
{
    int count = 0;
    
    for (int i = 1; i <= num; i++)
    {
        Console.Write($"Число {i}: ");
        int a = int.Parse(Console.ReadLine());
        if (a > 0) count++;
    }
    return count;
}

Console.Write("Сколько чисел хотели бы ввести?: ");
int a = int.Parse(Console.ReadLine());
Console.WriteLine($"Количество чисел больше 0: {Check(a)}");



