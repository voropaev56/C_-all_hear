/*
Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
6 -> да
7 -> да
1 -> нет
*/

Console.Write("Input day of the week number:  ");
int a = Convert.ToInt32(Console.ReadLine());

void SecondNumber()

{
if (a == 6 || a == 7)
{Console.WriteLine("This day is a weekend day of the week");
}
 
else 
{
    if (a >= 1 && a <=5)
    {
    Console.WriteLine("This day is NOT a weekend day of the week");
    }
    else
    {
    Console.WriteLine("SORRY, this is not a day of the week number");
    }   
}
}


SecondNumber();




