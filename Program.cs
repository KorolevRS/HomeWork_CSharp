//Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
//2, 3, 7 -> 7
//44 5 78 -> 78
//22 3 9 -> 22

int a, b, c;
int max;

Console.WriteLine($"Введите число: ");
int.TryParse(Console.ReadLine()!, out a);
Console.WriteLine($"Введите число: ");
int.TryParse(Console.ReadLine()!, out b);
Console.WriteLine($"Введите число: ");
int.TryParse(Console.ReadLine()!, out c);
max = a;
if (b > max)
{
    max = b;
    if (c > max)
    {
        max = c;
    }
}
else
{
    if (c > max)
    {
        max = c;
    }
}
Console.Write($"Максимальное число {max}\n");