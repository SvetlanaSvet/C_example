int UserWriteNumber(string msg)
{
    Console.Write(msg);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}

string[] ArrayStrCreate(int arrayLenght)
{
    string[] array = new string[arrayLenght];
    for (int i = 0; i < arrayLenght; i++)
    {
        Console.WriteLine($"Введите значение {i + 1} элемента массива: ");
        array[i] = Console.ReadLine();
    }
    return array;
}

void ArrayStrPrint(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}


string[] array1 = ArrayStrCreate(UserWriteNumber("Задайте длину массива: "));
ArrayStrPrint(array1);