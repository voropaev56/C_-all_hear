/*
Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12
*/

int SummaOfNumbers(int num)
{
    int sum = 0;
    int i = 0;
    while(num > 0)
    {
        i = num % 10;    // каждый 10 остаток от числа
        sum = sum + i;   // искомая сумма
        num = num / 10;  // каждый круг отбрасываем десятку 
    
    }
    return sum;
}   
    
Console.Write("Input a number: ");
int num111 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(SummaOfNumbers(num111));   
    
   