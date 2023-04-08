// Определить четные числа

Console.WriteLine("Введите длину: ");
int N = Convert.ToInt32(Console.ReadLine());

for (int i = 1; i <= N; i++)
    if (i % 2 == 0)
        Console.Write(i + " ");

//или так:
//for (int i = 2; i <= N; i += 2)
//    Console.Write(i + " ");