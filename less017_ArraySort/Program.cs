// Сортировка массива
int [] arr = {1, 5, 4, 3, 2, 6, 7, 1, 1};

//Процедура вывода массива в консоль
void PrintArray(int[] array)
{
    int count = array.Length;

    for (int i = 0; i < count; i++)
    {
        Console.Write($" {array[i]}");
    }
    Console.WriteLine();
}


//Процедура сортировки по возрастанию
void SelectionSort(int[] array)
{
    for (int i = 0; i < array.Length-1; i++) //array.Length-1, т.к. j = i + 1;, т.е. начинаем с 1
    {
        int minPosition = i;

        for (int j = i + 1; j < array.Length; j++)
        {
            if (array[j] < array[minPosition]) minPosition = j;            
        }

        int temporary = array[i];
        array[i] = array[minPosition];
        array[minPosition] = temporary;
    }
}

//Процедура сортировки по убыванию
void SelectionSortDESC(int[] array)
{
    for (int i = 0; i < array.Length-1; i++) //array.Length-1, т.к. j = i + 1;, т.е. начинаем с 1
    {
        int maxPosition = i;

        for (int j = i + 1; j < array.Length; j++)
        {
            if (array[j] > array[maxPosition]) maxPosition = j;            
        }

        int temporary = array[i];
        array[i] = array[maxPosition];
        array[maxPosition] = temporary;
    }
}

PrintArray(arr);

SelectionSort(arr);
PrintArray(arr); 

SelectionSortDESC(arr);
PrintArray(arr); 