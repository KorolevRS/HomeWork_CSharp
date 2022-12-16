/*Задача 66: Задайте значения M и N. Напишите программу, которая найдёт
 сумму натуральных элементов в промежутке от M до N.

M = 1; N = 15 -> 120
M = 4; N = 8. -> 30*/

int m, n;
Console.WriteLine($"Введите значение M: ");
int.TryParse(Console.ReadLine()!, out m);
Console.WriteLine($"Введите значение N: ");
int.TryParse(Console.ReadLine()!, out n);
int sum = 0;

if (m > n) Summa(m, n);
else Summa(n, m);
Console.WriteLine($"M = {m}; N = {n} -> {sum}");

int Summa(int big, int little)
{
    if (big < little)
        return sum;
    sum += big;
    Summa(big - 1, little);
    return sum;
}
