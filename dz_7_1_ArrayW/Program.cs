// Задача 47. Задайте двумерный массив размером m×n,
// заполненный случайными вещественными числами.  m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

double[,] CreateArray(int m, int n)
{
    double[,] array = new double[m, n];
    return array;
}

void PrintArray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            //Console.Write($"{array[i, j]} ");
            Console.Write(String.Format("{0,7}", array[i, j]));
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}


void FillArray(double[,] array)
{
    Random random = new Random();

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = Math.Round(random.Next(-50, 50) + random.NextDouble(), 1);
        }
    }
}

Console.WriteLine("Введите количество строк: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов: ");
int n = Convert.ToInt32(Console.ReadLine());

double[,] array = CreateArray(m, n);
PrintArray(array);
FillArray(array);
PrintArray(array);