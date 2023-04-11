// Поиск в массиве
int[] array = { 11, 21, 31, 41, 15, 61, 17, 15, 19 };

int n = array.Length;
int find = 15;

int index = 0;

while (index < n)
{
    if (array[index] == find)
    {
        Console.WriteLine(index);
        break; //если это число встречается не один раз в массиве
    }
    index++;
}
