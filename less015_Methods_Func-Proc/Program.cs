// Методы: функции и void-процедуры. Продолжение less014_
// Отличие в том, что процедура не возвращает значение (нет result).

// Вид 1 ничего не принимают и не возвращают
void Method1()
{
    Console.WriteLine("Автор ...");    
}
Method1();
//***************************************************************

// Вид 2 принимают, но не возвращают
void Method2(string msg, int count)  
{
    int i = 0;
    while (i < count)
    {
        Console.WriteLine(msg);
        i++;      
    }
}
//позиционные аргументы: на определенных позициях
Method2("Текст", 4);

//именованные аргументы: имя-значение
Method2(msg: "Новый текст", count: 2);
//***************************************************************

// Вид 3 ничего не принимают, а возвращают
int Method3() //указываем тип данных, к-рый он будет возвращать
{
    return DateTime.Now.Year;
}
int year = Method3();
Console.WriteLine(year);
//***************************************************************

// Вид 4 принимают и возвращают
string Method4(int count, string text)
{
    int i = 0;
    string result = String.Empty; //изначально результат будет пустой строкой

    while (i < count)
    {
        result = result + text;
        i++;
    }
    return result;
}
string res = Method4(10, "z");
Console.WriteLine(res);
//***************************************************************

//Задача 
//заменить в тексте пробелы черточками вертикальными
//маленькие буквы "к" заменить большими "К"
//большие "С" заменить маленькими "с"

string Replace(string text, char oldValue, char newValue)
{
   string result = String.Empty; //эту строку лучше делать (изначально результат будет пустой строкой)
   
   int length = text.Length;
   for (int i = 0; i < length; i++)
   {
       if (text[i] == oldValue) result = result + $"{newValue}";
       else result = result + $"{text[i]}";
   } 

   return result;
}

string text = "- Я думаю, - сказал князь, улыбаясь, - что, "
            + "ежели бы вас послали вместо нашего милого Винценгероде, "
            + "вы бы взяли приступом Согласие прусского короля. "
            + "Вы так красноречивы. Вы дадите мне чаю?"; 

string newText = Replace(text, ' ', '|');
Console.WriteLine(newText);
Console.WriteLine();

newText = Replace(newText, 'к', 'К');
Console.WriteLine(newText);
Console.WriteLine();

newText = Replace(newText, 'С', 'с');
Console.WriteLine(newText);
Console.WriteLine();
