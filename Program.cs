//Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, 
//а какое меньшее.
//a = 5; b = 7 -> max = 7
//a = 2 b = 10 -> max = 10
//a = -9 b = -3 -> max = -3

//int a;
//int b;
int a, b;
Console.WriteLine($"Введите число: ");
int.TryParse(Console.ReadLine()!, out a);
Console.WriteLine($"Введите число: ");
int.TryParse(Console.ReadLine()!, out b);
if (a > b)
{
    Console.Write($"Большее число: {a}\nМеньшее число: {b}\n");
}
else
{
    if (a < b)
    {
        Console.Write($"Большее число: {b}\nМеньшее число: {a}\n");
    }
    else
    {
        Console.Write($"{a} равно {b}\n");
    }
}
