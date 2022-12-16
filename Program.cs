/*Задача 64: Задайте значение N. Напишите программу, которая выведет все 
натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.

N = 5 -> "5, 4, 3, 2, 1"
N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"*/
int n;
Console.WriteLine($"Введите значение N: ");
int.TryParse(Console.ReadLine()!, out n);

PrintChisla(n);

void PrintChisla(int k)
{
    if (k <= 1)
        Console.WriteLine($"{k}");
    else
    {
        Console.Write($"{k}, ");
        PrintChisla(k - 1);
    }

}