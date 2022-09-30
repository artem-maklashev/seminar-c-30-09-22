/*Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

2, 3, 7 -> 7
44 5 78 -> 78
22 3 9 -> 22 */

int[] number = new int[3];

for (int i = 0; i < 3; i++)
{
    Console.Write("Введите число: ");
    number[i] = int.Parse(Console.ReadLine());
}
int max = number[0];

foreach (int i in number)
{
    if (i > max) max = i;
}

foreach (int i in number)
{
    Console.Write($"{i} ");
}
Console.Write($"-> {max}");