// Задача 66: Задайте значения M и N.
// Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int ClientWriteNumber(string msg)
{
    Console.Write(msg);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}

int SumNumbersRec(int N, int M)
{
    if (N == M) return N;
    return N + SumNumbersRec(N + 1, M);
}

int N = ClientWriteNumber("Введите значение от: ");
int M = ClientWriteNumber("Введите значение до: ");

Console.Write($"Сумма в промежутке от {N} до {M} равна {SumNumbersRec(N, M)}");