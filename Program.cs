/*Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12*/
int a;
int sum = 0;
Console.WriteLine($"Введите число: ");
string stroka = Console.ReadLine()!;
int.TryParse(stroka, out a);
stroka = a.ToString();
int[] array = new int[stroka.Length];

for (int i = 0; i < array.Length; i++)
{
    array[i] = int.Parse(stroka[i].ToString());
    sum += array[i];
}
Console.WriteLine($"{a} -> {sum}");