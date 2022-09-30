/*
Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

5 -> 2, 4
8 -> 2, 4, 6, 8
*/

Console.Write("Введите число: ");
int numb = int.Parse(Console.ReadLine());

Console.Write($"{Math.Abs(numb)} -> ");

for (int i = 1; i <= Math.Abs(numb); i++)
{
    if (i % 2 == 0) Console.Write($"{i}, ");
}
