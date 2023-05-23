// Задача 59: Задайте двумерный массив из целых чисел.
// Напишите программу, которая удалит строку и столбец,
// на пересечении которых расположен наименьший элемент массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Наименьший элемент - 1, на выходе получим следующий массив:
// 9 2 3
// 4 2 4
// 2 6 7

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

int[] MinIndex(int[,] array)
{
    int minI = 0;
    int minJ = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i, j] < array[minI, minJ])
            {
                minI = i;
                minJ = j;
            }
        }
    }
    int[] minmassive = new int[2]; //создаем одномерный массив и запишем в него полученные индексы
    minmassive[0] = minI;
    minmassive[1] = minJ;
    return minmassive;
}


int[,] Finalmassive(int[,] array, int[] minmassive)
{
    int[,] massive = new int[array.GetLength(0) - 1, array.GetLength(1) - 1];
    int row = 0;
    int column = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        if (i == minmassive[0]) continue; //на точках min не записываем значения в массив

        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (j == minmassive[1]) continue;

            massive[row, column] = array[i, j];
            column++;
        }
        row++;
        column = 0;
    }
    return massive;
}

int[,] array = ArrayIntCreate(ClientWriteNumber("Задайте количество строк массива: "),
                              ClientWriteNumber("Задайте количество столбцов массива: "));
ArrayIntPrint(array);

int[] minmassive = MinIndex(array);

array = Finalmassive(array, minmassive);

ArrayIntPrint(array);