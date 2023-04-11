// Программа на выходе показывает третью цифру числа
// или сообщает, что третьей цифры нет
//645->5
//78->третьей цифры нет
//32679->6

Console.WriteLine("Введите число: ");
int N = Convert.ToInt32(Console.ReadLine());

if (N < 100)
    Console.WriteLine("Третьей цифры нет");

else if (N >= 100 && N <= 999)
{
    N = N % 10;
    Console.WriteLine("Третья цифра числа:" + N);
}
else if (N >= 1000 && N <= 9999)
{
    N = N / 10 % 10;
    Console.WriteLine("Третья цифра числа:" + N);
}
else if (N >= 10000 && N <= 99999)
{
    N = N / 100 % 10;
    Console.WriteLine("Третья цифра числа:" + N);
}