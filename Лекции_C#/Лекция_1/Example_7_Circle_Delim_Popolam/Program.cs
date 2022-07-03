// Пример цикла While

Console.Clear(); // команда для очистки консоли
// Console.SetCursorPosition(10, 4); // команда для установки курсора в точку с заданными координатами
// Console.WriteLine("x");

int xa = 50, ya = 1,
    xb = 1, yb = 24,
    xc = 100, yc = 24;

Console.SetCursorPosition(xa,ya); 
Console.WriteLine("x");

Console.SetCursorPosition(xb,yb); 
Console.WriteLine("x");

Console.SetCursorPosition(xc,yc); 
Console.WriteLine("x");


int x = xa, y=xb;

int count = 0;

while(count < 100000)
{
    int what = new Random().Next(0, 3); // числа - 0 1 2
    if (what == 0)
    {
        x = (x+xa) / 2;
        y = (y+ya) / 2;
    }

    if (what == 1)
    {
        x = (x+xb) / 2;
        y = (y+yb) / 2;
    }

    if (what == 2)
    {
        x = (x+xc) / 2;
        y = (y+yc) / 2;
    }

    Console.SetCursorPosition(x, y);
    Console.WriteLine("+");
    count = count + 1;

}
