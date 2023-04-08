// Принимает 2 числа и выдает max

Console.WriteLine("Введите первое число: ");
int a = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите второе число: ");
int b = Convert.ToInt32(Console.ReadLine());

if (a > b)
    Console.WriteLine($"max {a}");
else 
    Console.WriteLine($"max {b}");