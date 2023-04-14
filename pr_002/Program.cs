// Задача №17. Напишите программу, которая принимает на вход координаты точки (X и Y), 
// причем X != 0 и Y != 0 и выдаёт номер четверти плоскости, в которой находится эта точка.

// Система координат:
//      ^
//      |        
//   2  |  1
//      |
// ------------->
//      |
//   3  |  4
//      |
Console.WriteLine("Введите X ");
int x = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите Y ");
int y = Convert.ToInt32(Console.ReadLine());
if(x == 0 || y == 0 )
{
  Console.WriteLine ("На пересечении четвертей");
}
else if (x > 0 && y > 0)
{
  Console.Write("это 1-ая четверть ");
}
else if (x < 0 && y > 0)
{
  Console.Write("это 2-ая четверть ");
}
else if (x < 0 && y < 0)
{
  Console.Write("это 3-ая четверть ");
}
else if (x > 0 && y < 0)
{
  Console.Write("это 4-ая четверть ");
}