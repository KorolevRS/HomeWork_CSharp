/*Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, 
что третьей цифры нет.
645 -> 5
78 -> третьей цифры нет
32679 -> 6*/

string text;
Console.Write($"Введите текст: ");
text = Console.ReadLine()!;
if (text.Length > 2)
    Console.WriteLine(text[2]);
else
    Console.WriteLine($"третьей цифры нет");