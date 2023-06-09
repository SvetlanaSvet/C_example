﻿// Задача 64: Задайте значение N.
// Напишите программу, которая выведет все натуральные числа в промежутке от N до 1.
// Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

int ClientWriteNumber(string msg)
{
    Console.Write(msg);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}

string NumbersRec(int N)
{
    if (N == 1) return "1";
    return $"{N} " + NumbersRec(N - 1);
}

int N = ClientWriteNumber("Введите число: ");
Console.Write(NumbersRec(N));