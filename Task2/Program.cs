/*Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

a = 5; b = 7 -> max = 7
a = 2 b = 10 -> max = 10
a = -9 b = -3 -> max = -3 */

Console.Write("Введите число a: ");
int numberOne = int.Parse(Console.ReadLine());

Console.Write("Введите число b: ");
int numberTwo = int.Parse(Console.ReadLine());

if (numberOne > numberTwo) 
    Console.WriteLine($"a = {numberOne}; b = {numberTwo} -> max = {numberOne}");
else if (numberOne < numberTwo) 
    Console.WriteLine($"a = {numberOne}; b = {numberTwo} -> max = {numberTwo}");
else 
    Console.WriteLine($"a = {numberOne}; b = {numberTwo} -> Числа равны");