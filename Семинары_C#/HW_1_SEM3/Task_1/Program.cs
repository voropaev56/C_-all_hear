/*
Задача 19
Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
14212 -> нет
12821 -> да
23432 -> да
*/

Console.Write("Input a five-digit number:  ");
int num165 = Convert.ToInt32(Console.ReadLine());

void Palindrom (int number)
    {
        int num1 = number % 100000/ 10000;
        int num2 = number % 10000/ 1000;
        int num4 = number % 100 / 10;
        int num5 = number % 10;

        if (number >= 10000 && number <= 99999)
        {
            if (num1 == num5 && num2 == num4)
            {
             Console.WriteLine("The number is palindrom");
            }
            else 
            {
             Console.WriteLine("The number is not palindrom");
            }
                
        }
        else
        {
            Console.WriteLine("This is not a five-digit number");
        }
        
    }

Palindrom(num165);

















