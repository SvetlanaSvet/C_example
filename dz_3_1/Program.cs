// Программа определяет является ли число палиндромом
// 1230321

Console.WriteLine("Введите число: ");

int N, n, tmp_N;
N = Convert.ToInt32(Console.ReadLine());
tmp_N = N;

//Вычисляем разрядность числа
int i = 0;
while (N > 0) 
{    
    N = N / 10;
    i++;
    //Console.WriteLine($"{i}:   {N}");
 }

if (N == 0) N = tmp_N; //возвращаем число в переменную N


int[] array_n = new int[i];  //создаем массив (кол-во элементов - i)


//Заполняем массив
Console.WriteLine("---------------");
i = 0;
while (N > 0)
{
    n = N % 10;
    N = N / 10;
    array_n[i] = n;
    Console.WriteLine($"{i}:   {array_n[i]}");
    i++;
}

//Сравниваем элементы и определяем палиндромность
for (i = 0; i < array_n.Length; i++)
{
    if (array_n[i] == array_n[array_n.Length - 1 - i])
    {
        if (i == array_n.Length - 1)
            Console.WriteLine("Палиндром");
    }
    else
    {
        Console.WriteLine("НЕ палиндром");
        break;
    }
}