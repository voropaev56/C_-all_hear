/*
Задача 23
Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125
*/



Console.Write("Input a number:  ");
int num33 = Convert.ToInt32(Console.ReadLine());

void Cube(int n)
{
    if (n > 0)
    {
        int current = 1;
        
        while (current < n)
        {
        int cube = current * current * current;
        current++;
        Console.Write(cube + " ");
        }
    }
    else
    {
        Console.Write("Error");
    }

}

Cube(num33);
















