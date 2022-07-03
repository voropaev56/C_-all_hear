/* Напишите программу, которая принимает на вход координаты точки (X и Y),
 причём X ≠ 0 и Y ≠ 0 и выдаёт номер четверти плоскости, 
 в которой находится эта точка.
*/

Console.WriteLine("Input coordinate of x: ");
int x1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input coordinate of y: ");
int y1 = Convert.ToInt32(Console.ReadLine());

int NumQuart(int x, int y)
{
    int result;
    if (x > 0 && y > 0) result = 1;
    if (x < 0 && y > 0) result = 2;
    if (x < 0 && y < 0) result = 3;
    if (x > 0 && y < 0) result = 4;
    else result = -1;
    return result;
}

int quart = NumQuart(x1, y1);
Console.WriteLine(quart);




