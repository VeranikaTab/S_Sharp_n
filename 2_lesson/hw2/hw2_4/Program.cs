// Задача 4: Напишите программу, которая принимает на вход цифру,
// обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

void Dni(int cif)
{
    if ( (cif >= 6) && (cif < 8))
    {
        Console.WriteLine("Да");
    }
    else if ((cif <= 5) && (cif > 0))
    {
        Console.WriteLine("Нет");
    }
    else
    {
        Console.WriteLine("Error");
    }
}
Dni(int.Parse(Console.ReadLine()));