// Напишите программу, которая принимает на вход число и выдает сумму цифр в числе
//  452 -> 11
//   82 -> 10
// 9012 -> 12

Console.Write ("Введите число N: ");
int N = Convert.ToInt32 (Console.ReadLine());

int sum = 0;
while (N > 0)
{
    sum = sum + N % 10;
    N = N / 10;
}

Console.WriteLine ($"Cумма цифр в числе: {sum}");