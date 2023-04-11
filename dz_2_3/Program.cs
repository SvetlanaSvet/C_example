// Напишите программу, которая принимает на вход цифру,
// обозначающую день недели, и проверяет, является ли этот день выходным
// 6 -> да 
// 7 -> да
// 1 -> нет

Console.WriteLine("Введите номер дня недели: ");

int weeknum = Convert.ToInt32(Console.ReadLine());

if (weeknum >= 1 && weeknum <= 5)
{
    Console.Write("Рабочий день");
}
else if (weeknum == 6 || weeknum == 7)
{
    Console.Write("Выходной день");
}
else
    Console.Write("Неверно указан день недели");