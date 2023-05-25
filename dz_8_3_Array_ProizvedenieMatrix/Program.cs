// Задача 58: Задайте две матрицы. 
// Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

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
            array[i, j] = new Random().Next(1, 10);
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

int[,] ArrayProizvedenieMatrix(int[,] array1, int[,] array2)
{
    int[,] array = new int[array1.GetLength(0), array2.GetLength(1)];
 
    for (int i = 0; i < array1.GetLength(0); i++) //переход по строкам первой матрицы 
        for (int j = 0; j < array2.GetLength(1); j++) //по столбцам второй матрицы
            for (int k = 0; k < array2.GetLength(0); k++) //по строкам столбца
                array[i, j] += array1[i, k] * array2[k, j];

    return array;
}

int rowArray1 = ClientWriteNumber("Задайте количество строк для 1 массива: ");
int colArray1 = ClientWriteNumber("Задайте количество столбцов  1 массива: ");

int rowArray2 = ClientWriteNumber("Задайте количество строк для 2 массива: ");
int colArray2 = ClientWriteNumber("Задайте количество столбцов  2 массива: ");

if (colArray1 == rowArray2)
{

    int[,] array1 = ArrayIntCreate(rowArray1, colArray1);
    int[,] array2 = ArrayIntCreate(rowArray2, colArray2);

    ArrayIntPrint(array1);
    ArrayIntPrint(array2);

    ArrayIntPrint(ArrayProizvedenieMatrix(array1, array2));
}
else Console.Write($"Чтобы можно было умножить две матрицы, \n" +
                    "количество столбцов первой матрицы \n" +
                    "должно быть равно количеству строк второй матрицы.");