int UserWriteNumber(string msg) //запрос пользователю задать длину массива
{
    Console.Write(msg);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}

string[] ArrayStrCreate(int arrayLenght) //создаем строковый одномерный массив
{
    string[] array = new string[arrayLenght];
    for (int i = 0; i < arrayLenght; i++)
    {
        Console.WriteLine($"Введите значение {i + 1} элемента массива: ");
        array[i] = Console.ReadLine();
    }
    return array;
}

void ArrayStrPrint(string[] array) //печать массива
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}


string[] ArraySelect(string[] array1) //новый массив
{
    string[] array2 = new string[array1.Length];
    int count = 0;
    for (int i = 0; i < array1.Length; i++)
    {
        if (array1[i].Length <= 3)
        {
            array2[count] = array1[i];
            count++;
        }
    }
    return array2;
}

string[] array1 = ArrayStrCreate(UserWriteNumber("Задайте длину массива: "));
ArrayStrPrint(array1);

string[] array2 = ArraySelect(array1);
ArrayStrPrint(array2);