﻿// Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

// 4 -> да
// -3 -> нет
// 7 -> нет

Console.WriteLine ("Введите число: ");
double number = Convert.ToDouble(Console.ReadLine());

if ((number % 2) == 0)
{
    Console.WriteLine("Да, число чётное");
}
else
{
    Console.WriteLine("Нет, число нечётное");
}