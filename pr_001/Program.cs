// программа выводит случайное число из отрезка [10,99]
// и показывает наибольшую цифру числа
// 78-> 8
// 12-> 2
// 85-> 8

for (int i = 0; i < 20; i++)
{
    int number = new Random().Next(10,100);  // 1число - включительно, 2 - не включительно 
    int n1 = number / 10;
    int n2 = number % 10;
    if (n1 > n2)
    {
        Console.WriteLine($"{number} -> {n1}");
    }
    else
    {
        Console.WriteLine($"{number} -> {n2}");
    }
}