// Задача 54: Задайте двумерный массив.
// Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

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

int[,] ArraySort(int[,] array) 
{ //сортировка пузырьковая двумерного массива по убыванию
    for (int i = 0; i < array.GetLength(0); i++)
                                                        //i = строки
        for (int j = 1; j < array.GetLength(1); j++)    //j = столбцы (к-во элементов)
            for (int k = 0; k < array.GetLength(1); k++)//k = каждый элемент
            {   
                if (array[i, j] <= array[i, k]) continue; //меняем знак -> по возрастанию
 
                int temp = array[i, j];
                array[i, j] = array[i, k];
                array[i, k] = temp;
            }
    return array;
}

int[,] array = ArrayIntCreate(ClientWriteNumber("Задайте количество строк массива: "),
                              ClientWriteNumber("Задайте количество столбцов массива: "));
ArrayIntPrint(array);

array = ArraySort(array);
ArrayIntPrint(array);