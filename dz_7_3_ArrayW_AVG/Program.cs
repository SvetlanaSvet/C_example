// Задача 52. Задайте двумерный массив из целых чисел.
// Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

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
            Console.Write(String.Format("{0,5}", array[i, j]));
        }
        Console.WriteLine();
    }
    //Console.WriteLine();
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

//среднее значение по колонкам получим в одномерный массив
double[] ArrayAVG(int[,] array, int m, int n)
{
    double[] sumAVG = new double[n]; //создаем одномерный массив для средних значений 
                                     //с количеством столбцов, указанных пользователем
    for (int i = 0; i < array.GetLength(1); i++) //цикл до конца столбцов
    {
        for (int j = 0; j < array.GetLength(0); j++) //цикл до конца строк
        {
            sumAVG[i] = sumAVG[i] + array[j, i];
        }
        Console.Write(String.Format("{0,5}", Math.Round((sumAVG[i] / m), 1))); //делим сумму на количество строк
    }
    return sumAVG;
}


Console.WriteLine("Введите количество строк: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов: ");
int n = Convert.ToInt32(Console.ReadLine());


int[,] array = CreateArray(m, n);
FillArray(array);
PrintArray(array);

ArrayAVG(array, m, n);