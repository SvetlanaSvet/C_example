// Программа принимает на вход координаты двух точек
// и находит расстояние между ними в 3D пространстве
// d = V(x2-x1)2 + (y2-y1)2 + (z2-z1)2 ,
// где (x1,y1,z1) и (x2,y2,z2) две точки; V-корень квадратный

Console.WriteLine("Введите X первой точки: ");
int X1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите Y первой точки: ");
int Y1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите Z первой точки: ");
int Z1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите X второй точки: ");
int X2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите Y второй точки: ");
int Y2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите Z второй точки: ");
int Z2 = Convert.ToInt32(Console.ReadLine());

Console.Write("Ответ: ");
Console.WriteLine(Math.Round
                    (Math.Sqrt(Math.Pow((X2 - X1), 2) +
                               Math.Pow((Y2 - Y1), 2) +
                               Math.Pow((Z2 - Z1), 2)), 2));