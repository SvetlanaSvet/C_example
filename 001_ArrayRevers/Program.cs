// Задача 55: Задайте двумерный массив. Напишите программу, которая заменяет строки на столбцы.
// В случае, если это невозможно, программа должна вывести сообщение для пользователя.
// Например:
// 7 8 9  - > 7 1 2
// 1 6 0      8 6 5 
// 2 5 5      9 0 5  - > это возможно, только если массив квадратный

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
}


int[,] ArrayChange(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = i; j < array.GetLength(1); j++)
        {
            (array[i, j], array[j, i]) = (array[j, i], array[i, j]);
        }
    }
    return array;
}

int[,] massive = ArrayIntCreate(ClientWriteNumber("Введите размер массива 0: "),
                                ClientWriteNumber("Введите размер массива 1: "));

if (massive.GetLength(0) == massive.GetLength(1))
{
    ArrayIntPrint(massive);
    Console.WriteLine();
    ArrayIntPrint(ArrayChange(massive));
}
else Console.WriteLine("Введите равное количество строк и столбцов");