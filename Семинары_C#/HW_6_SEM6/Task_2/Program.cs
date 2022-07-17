// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 
// задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

double x;
double y;

Console.Write("Input k1 of the first linear equation: ");
double k1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input b1 of the first linear equation: ");
double b1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input k2 of the second linear equation: ");
double k2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input b2 of the second linear equation: ");
double b2 = Convert.ToInt32(Console.ReadLine());

if (k1 == k2 & b1 != b2)
{
    Console.WriteLine("Lines are parallel");
}
if (k1 == k2 & b1 == b2)
{
    Console.WriteLine("The same equations");
}
if(k1 != k2)
{
x = (b2 - b1) / (k1 - k2);
y = k1 * x + b1;
Console.WriteLine("Intersection point coordinates: ( " + x + " ; " + y + " )");
}