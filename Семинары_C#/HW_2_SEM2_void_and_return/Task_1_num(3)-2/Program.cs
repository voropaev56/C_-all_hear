/*
Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
456 -> 5
782 -> 8
918 -> 1
*/

Console.Write("Input a number:  ");
int a = Convert.ToInt32(Console.ReadLine());

void SecondNumber()
{
if (a > 99 && a < 1000)
{
int b = a % 100 / 10;
Console.WriteLine("The second number is: " + b);
}
else
{
Console.WriteLine("It is not a three-digit number");
}
}

SecondNumber();

