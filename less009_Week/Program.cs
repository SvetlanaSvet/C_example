//Напишите программу, которая будет выдавать название дня недели по заданному номеру.
//	3 -> Среда 
//        5 -> Пятница

Console.WriteLine("Введите номер дня недели: ");

int weeknum = Convert.ToInt32(Console.ReadLine());

if (weeknum == 1)
{
    Console.Write("Monday");
}
else if (weeknum == 2)
{
    Console.Write("Tuesday");
}
else if (weeknum == 3)
{
    Console.Write("Wednesday");
}
else if (weeknum == 4)
{
    Console.Write("Thirthday");
}
else if (weeknum == 5)
{
    Console.Write("Friday");
}
else if (weeknum == 6)
{
    Console.Write("Saturday");
}
else if (weeknum == 7)
{
    Console.Write("Sunday");
}
else
    Console.Write("Такого номера не существует");