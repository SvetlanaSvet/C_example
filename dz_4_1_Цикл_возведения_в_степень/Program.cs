// Напишите цикл, который принимает на вход два числа (A и B) 
// и возводит число A в натуральную степень B.

// 3, 5 -> 243
// 2, 4 -> 16

Console.Write ("Введите число A: ");
int A = Convert.ToInt32 (Console.ReadLine());
int numberA = A; 

Console.Write ("Введите число B: ");
int B = Convert.ToInt32 (Console.ReadLine());

for (int i = 2; i <= B; i++)
{
    A = A * numberA;
}

Console.WriteLine ($"Ответ: {A}");