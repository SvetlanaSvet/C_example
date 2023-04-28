// Пользователь вводит с клавиатуры M чисел.
// Посчитайте, сколько чисел больше 0 ввёл пользователь.

Console.Write("Введите количество элементов массива: ");
int lengthM = Convert.ToInt32(Console.ReadLine());
int[] arrayM = new int[lengthM];

void FillArrayM(int lengthM)
{
    for (int i = 0; i < lengthM; i++)
    {
        Console.WriteLine($"Введите {i + 1} элемент массива: ");
        arrayM[i] = Convert.ToInt32(Console.ReadLine());
    }
}

int CountPositiveNumber(int[] arrayM)
{
    int count = 0;
    for (int i = 0; i < arrayM.Length; i++)
    {
        if (arrayM[i] > 0) count++;

    }
    return count;
}

FillArrayM(lengthM);
Console.WriteLine($"Чисел больше нуля: {CountPositiveNumber(arrayM)}");