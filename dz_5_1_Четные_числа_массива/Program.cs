// Задача 34: Задайте массив заполненный случайными положительными
// трёхзначными числами. Напишите программу, которая покажет количество
// чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

int[] CreateArray(int Length, int minValue, int maxValue)
{
    int[] array = new int[Length];  // объявляем массив
    Random random = new Random();
    for (int i = 0; i < Length; i++)
    {
        array[i] = random.Next(minValue, maxValue + 1); 
        Console.Write($"{array[i]} ");       
    }
    return array;
}

int EventNumber(int[] array)  //Количество четных чисел в массиве
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0) count++;
    }
    return count;
}

int res = EventNumber(CreateArray(4, 100, 999));
Console.WriteLine($"Количество четных чисел в массиве: {res}");