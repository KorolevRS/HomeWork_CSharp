/*Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии.
 Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 9
m = 3, n = 2 -> A(m,n) = 29*/

int k, j;
Console.WriteLine($"Введите значение M: ");
int.TryParse(Console.ReadLine()!, out k);
Console.WriteLine($"Введите значение N: ");
int.TryParse(Console.ReadLine()!, out j);
Console.WriteLine(Acermana(k, j));

int Acermana(int m, int n)
{
    if (m == 0) return n + 1;
    else if (m > 0 && n == 0)
    {
        return Acermana(m - 1, 1);
    }
    else
    {
        return Acermana(m - 1, Acermana(m, n - 1));
    }
}