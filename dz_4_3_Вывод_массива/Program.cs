// Напишите программу (через методы), которая задает массив из 8 элементов
// и выводит их на экран

//Заполнение массива
void FillArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(0, 10);
    }
}

//вывод в консоль
void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($" {array[i]}");
    }
}

int[] array = new int[8]; //создаем новый массив из 8 элементов

FillArray(array);
PrintArray(array);