/*Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 3*/
int m, x;
int kol = 0;
// Console.WriteLine($"Сколько чисел выхотите вести? ");
// int.TryParse(Console.ReadLine()!, out m);
// int[] massive = new int[m];

// for (int i = 0; i < m; i++)
// {
//     Console.WriteLine($"Введите {i + 1}-е число:");
//     int.TryParse(Console.ReadLine()!, out x);
//     massive[i] = x;
//     if (x > 0) kol++;
// }
// Print(massive);
// Console.WriteLine($"количество чисел больше -> {kol} ");

// void Print(int[] arr)
// {
//     for (int i = 0; i < arr.Length; i++)
//         Console.Write($"{arr[i]} ");
// }
// // Решение с помощью отдельного/раздельного ввода*/

Console.WriteLine($"Введите числа через ','");
string[] massiveS = Console.ReadLine()!.Split(',');

for (int i = 0; i < massiveS.Length; i++)
{
    int.TryParse(massiveS[i], out x);
    if (x > 0) kol++;
} //Решение с помощью считывания через Split

Print(massiveS);
Console.WriteLine($"количество чисел больше -> {kol} ");

void Print(string[] arr)
{
    for (int i = 0; i < arr.Length; i++)
        Console.Write($"{arr[i]} ");
}
