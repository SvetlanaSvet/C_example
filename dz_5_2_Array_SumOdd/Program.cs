//Задача 36: Задайте одномерный массив, заполненный случайными числами.
//Найдите сумму элементов, стоящих на нечётных позициях.
//[3, 7, 23, 12] -> 19
//[-4, -6, 89, 6] -> 0

//Массив
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

//Сумма элементов, стоящих на нечетных позициях
int SumOddPosition(int[] array)  
{
    int sum = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (i % 2 == 0) sum = sum + array[i];
    }
    return sum;
}

int res = SumOddPosition(CreateArray(4, -50, 50));
Console.WriteLine($"Сумма элементов, стоящих на нечетных позициях: {res}");