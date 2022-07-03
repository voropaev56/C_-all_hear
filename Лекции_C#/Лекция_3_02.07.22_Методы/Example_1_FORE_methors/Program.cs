// 1 группа методов - ничего не принимают ничего не возвращают
/*
void Method1()
{
    Console.WriteLine("Автор ...");
}

Method1(); // - так вызывается метод для запуска
*/

// ____________________________________________________________________________________________________________
// 2 группа методов - что-то принимают ничего не возвращают
/*

void Method2(string msg)
{
    Console.WriteLine(msg);
}
Method2("Текст сообщения");

*/ 
// 2.1 метод
/*
void Method2(string msg, int count)
{
    int i = 0;
    while (i < count)
    {
        System.Console.WriteLine(msg);
        i++;
    }
}
Method2(msg: "Текст", count: 4);     // или Method2("Текст", 4);     - 4 раза мы хотим видеть слово Текст
*/

// ____________________________________________________________________________________________________________
// 3 группа методов - ничего не принимают что-то возвращают
/*
int Method3()
{
    return DateTime.Now.Year;
}

int year = Method3();
Console.WriteLine(year);
*/


// ____________________________________________________________________________________________________________
// 4 группа методов - что-то принимают что-то возвращают

string Method4(int count, string text)
{
    int i = 0;
    string result = String.Empty;   // или = " ";

    while (i < count)
    {
        result = result + text;
        i++;
    }
    return result;
}

string res = Method4(10, "asdf");
Console.WriteLine(res);







