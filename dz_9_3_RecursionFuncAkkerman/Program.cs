// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29
// A(1, 2); -> res = 4
// A(0, 1); -> res = 2
// A(0, 0); -> res = 1
// A(2, 2); -> res = 7

//При больших значениях n и m может возникнуть переполнение стека,
//так как функция Аккермана есть дважды рекурсивной:
//один из аргументов функции есть та же рекурсивная функция.

int ClientWriteNumber(string msg)
{
    Console.Write(msg);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}

int A(int n, int m)
{
    if (n == 0)
        return m + 1;
    else
      if ((n != 0) && (m == 0))
        return A(n - 1, 1);
    else
        return A(n - 1, A(n, m - 1));
}

int n = ClientWriteNumber("Введите значение N: ");
int m = ClientWriteNumber("Введите значение М: ");

if (n < 0 || m < 0)
    Console.Write("Числа должны быть только положительными");
else Console.Write(A(n, m));