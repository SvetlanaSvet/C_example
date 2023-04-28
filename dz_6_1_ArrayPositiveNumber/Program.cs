// Пользователь вводит с клавиатуры M чисел.
// Посчитайте, сколько чисел больше 0 ввёл пользователь.

void FillArrayM(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.WriteLine($"Введите {i + 1} элемент массива: ");
        array[i] = Convert.ToInt32(Console.ReadLine());
    }
}

int CountPositiveNumber(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0) count++;

    }
    return count;
}

Console.Write("Введите количество элементов массива: ");
int lengthM = Convert.ToInt32(Console.ReadLine());
int[] arrayM = new int[lengthM];

FillArrayM(arrayM);
Console.WriteLine($"Чисел больше нуля: {CountPositiveNumber(arrayM)}");