// Задача 50. Напишите программу, которая на вход принимает позиции элемента 
//в двумерном массиве, и возвращает значение этого элемента или же указание,
// что такого элемента нет. Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4      
// 17 -> такого числа в массиве нет

int[,] CreateArray(int m, int n)
{
    int[,] array = new int[m, n];
    return array;
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(String.Format("{0,3}", array[i, j]));
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}


void FillArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(1, 10);
        }
    }
}

Console.WriteLine("Введите количество строк: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов: ");
int n = Convert.ToInt32(Console.ReadLine());


int[,] array = CreateArray(m, n);
FillArray(array);
PrintArray(array);


Console.WriteLine("Введите позицию элемента (строка): ");
int k1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите позицию элемента (столбец): ");
int k2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите значение: ");
int value = Convert.ToInt32(Console.ReadLine());


if (array[k1,k2] == value) 
    Console.WriteLine($"Cовпадение значения");
else Console.WriteLine($"На позиции {k1}, {k2} значение {array[k1,k2]}");