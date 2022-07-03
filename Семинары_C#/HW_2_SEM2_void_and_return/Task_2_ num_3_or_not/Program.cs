/*
Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
645 -> 5
78 -> третьей цифры нет
32679 -> 6
*/

Console.Write("Input a number:  ");
int a = Convert.ToInt32(Console.ReadLine());

void ThirdNumber()
{
    if (a > 99 && a < 1000)
    {
    int b = a % 10;
    Console.WriteLine("The third number is: " + b);
    }

/*
Павел я понимаю что мы должны while & 10 отбрасывать по десятке до трехзначного потом еще раз и будет ответ
но не знаю долго мучился не получилось(
*/
    if (a > 999)
    {
        int count = a;
        while (count > 999)
        {
        count = count % 10;
        }
    int c = count % 10;
    Console.WriteLine("The third number is: " + c);
    }

    else
    {
    Console.WriteLine("There is no third number");
    }

}
    



ThirdNumber();

/*
if (a >= 1000)
{
    int count;
    while (a >= count) // я нихрена не знаю что писать
    {
    count = a / 100;  
    Console.WriteLine("The third number is: " + c);
    }
}
else
{
Console.WriteLine("There is no third number");
}
}


ThirdNumber();



/*
Console.Write("Input a number:  ");
int a = Convert.ToInt32(Console.ReadLine());


int b = a % 100;

Console.WriteLine(b);
*/