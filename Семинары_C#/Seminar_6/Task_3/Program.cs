// Задача 1
// Напишите программу, которая принимает на вход три числа и проверяет,
 // может ли существовать треугольник с сторонами такой длины.

void Treug (int a, int b, int c)
{
    if (a < b + c && b < a+c && c < a+b)
    {
        Console.WriteLine("условие выполняется");
    }   
    
    else Console.WriteLine("условие не выполняется");
}

Console.Write("Input num one:  ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input num two:  ");
int num2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input num three:  ");
int num3 = Convert.ToInt32(Console.ReadLine());

Treug(num1, num2, num3);

// --------------------------------------------------------------------------------------
// Не используя рекурсию, выведите первые N чисел Фибоначчи. 
// Первые два числа Фибоначчи: 0 и 1.

int [] Fibonacci(int n)
{
    int[] newArray = new int[n];
    Console.WriteLine("Creating array here: ");
    newArray[0] = 0;
    newArray[1] = 1;
    for (int i = 2; i<n; i++)
    {
        newArray[i] = newArray[i - 1] + newArray[i-2];
    }
    return newArray;
}

Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
ShowArray(Fibonacci(num));

// --------------------------------------------------------------------------------------
// тип bool


bool Triangle (int a, int b, int c)
{
    return a < b + c && b < a + c && c < a + b
    
}

bool isTriangle = false;
isTriangle = Triangle(1, 2, 2);
Console.WriteLine(isTriangle);


int a = 5, b = 3;
 bool c = a > b;














