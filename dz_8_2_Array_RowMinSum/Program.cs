// Задача 56: Задайте прямоугольный двумерный массив.
// Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке
// и выдаёт номер строки с наименьшей суммой элементов: 1 строка

int ClientWriteNumber(string msg)
{
    Console.Write(msg);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}

int[,] ArrayIntCreate(int arrayLenght0, int arrayLenght1)
{
    int[,] array = new int[arrayLenght0, arrayLenght1];
    for (int i = 0; i < arrayLenght0; i++)
    {
        for (int j = 0; j < arrayLenght1; j++)
        {
            array[i, j] = new Random().Next(0, 10);
        }
    }
    return array;
}

void ArrayIntPrint(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]}    ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

void ArrayRowMinSum(int[,] array)
{
    int minSumRow = int.MaxValue;
    int indexI = 0;

    for (int i = 0; i < array.GetLength(0); i++)
    {
        int sumRow = 0;
        for (int j = 0; j < array.GetLength(1); j++)
            sumRow = sumRow + array[i, j];

        if (sumRow < minSumRow)
        {
            indexI = i;
            minSumRow = sumRow;
        }
    }
    Console.Write($"{indexI + 1} строка; сумма: {minSumRow}");
}

int[,] array = ArrayIntCreate(ClientWriteNumber("Задайте количество строк массива: "),
                              ClientWriteNumber("Задайте количество столбцов массива: "));
ArrayIntPrint(array);

ArrayRowMinSum(array);