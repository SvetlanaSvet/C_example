// Задача 53: Задайте двумерный массив. Напишите программу,
//  которая поменяет местами первую и последнюю строку массива.

int[,] CreateMassive()
{
    int m = new Random().Next(1, 10);
    int n = new Random().Next(1, 10);
    int[,] array = new int[m, n];
    Console.WriteLine($"{m} and {n}");
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            array[i, j] = new Random().Next(1, 10);
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
    return array;
}

int[,] ChangePlaces(int[,] array)
{
    //int m = 0; если через переменную
    for (int i = 0; i < array.GetLength(1); i++) //проходим по столбцам первой строки
    {
        //(x,y) = (y,x) синт.сахар
        // array[0,i]                      - x - первая строка
        // array[array.GetLength(0) - 1,i] - y - последняя строка

        (array[0, i], array[array.GetLength(0) - 1, i]) = (array[array.GetLength(0) - 1, i], array[0, i]);
    }
    return array;
}

void PrintMasive(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}

int[,] array = CreateMassive();
Console.WriteLine();
int[,] massive = ChangePlaces(array);
PrintMasive(array);