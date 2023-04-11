// Методы: функции и void-процедуры.
// Отличие в том, что процедура не возвращает значение (нет result).

void FillArray(int[] collection)  //Заполнение массива (fill- наполнение); collection - так назовем массив 
{
    int length = collection.Length;
    int index = 0;
    while (index < length)
    {
        collection[index] = new Random().Next(1,10);
        index++;
    }
}

void PrintArray(int[] col) //Вывод массива в консоль (col - так назовем массив)
{
    int count = col.Length;  //длина
    int position = 0;        //индекс
    while (position < count)
    {
        Console.WriteLine(col[position]);
        position++;
    }
}

int IndexOf(int[] collection, int find)
{
    int count = collection.Length;
    int index = 0;
    int position = -1;
    
    while (index < count)
    {
        if (collection[index]==find)
        {
            position = index;
            break; //при первом совпадении
        }
        index++;
    }
    return position;
}

int[] array = new int[10]; //создай новый массив из 10 элементов

FillArray(array);
PrintArray(array);
Console.WriteLine();

int pos = IndexOf(array, 4);
Console.WriteLine(pos);
