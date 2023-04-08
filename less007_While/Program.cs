// Интересная задача про точки (даны три точки-вершины треугольника)
// определим расстояние между двух вершин и посредине поставим точку
// от этой точки, что посредине определим расстояние до третьей вершины
// и посередине поставим точку
// эту точку соединим с другой вершиной и опять посредине поставим точку
// и так повторить несколько раз
Console.Clear();
//Console.SetCursorPosition(10,4); //Позиция курсора(слева, сверху)
//Console.WriteLine("+");

int xa = 40, ya =  1,
    xb =  1, yb = 30,
    xc = 80, yc = 30;

Console.SetCursorPosition(xa, ya); 
Console.WriteLine("+");

Console.SetCursorPosition(xb, yb); 
Console.WriteLine("+");

Console.SetCursorPosition(xc, yc); 
Console.WriteLine("+");

int x = xa, y = xb; //определим первую точку

int count = 0; //какое к-во раз надо проделать нахождение отрезков и деления его пополам

while (count < 10000)
{
    int what = new Random().Next(0,3); // [0,1,2] получаем случ.число (вершина треуг-ка)

    if (what == 0) //определяем координаты середины отрезка
    {
        x = (x + xa) / 2; 
        y = (y + ya) / 2;
    }
    if (what == 1)
    {
        x = (x + xb) / 2;
        y = (y + yb) / 2;
    }
    if (what == 2)
    {
        x = (x + xc) / 2;
        y = (y + yc) / 2;
    }
    
    Console.SetCursorPosition(x, y);
    Console.WriteLine("+");
    count++;
}
