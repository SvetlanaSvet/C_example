//Задача 38: Задайте массив вещественных чисел.
//Найдите разницу между максимальным и минимальным элементов массива.
//[3 7 22 2 78] -> 76

//Массив вещественных чисел
//NextDouble() - генерирует дробное число от 0 до 1
double[] CreateArray(int Length)
{
    double[] array = new double[Length];  // объявляем массив
    Random random = new Random();
    for (int i = 0; i < Length; i++)
    {
        array[i] =  Math.Round(random.NextDouble()*100,2); 
        Console.Write($"{array[i]}  ");       
    }
    return array;
}

//Разница между максимальным и минимальным элементом массива
double DifferenceMinMax(double[] array)  
{
    double min = array[0];
    double max = array[0];
    for (int i = 1; i < array.Length; i++)
    {
        if (array[i] < min)  min = array[i];
        if (array[i] > max)  max = array[i];
    }
    double diff = max - min;
    return diff;
}

double res = DifferenceMinMax(CreateArray(5));
Console.WriteLine();
Console.WriteLine($"Разница между максимальным и минимальным элементом массива: {res}");