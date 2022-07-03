// Программа выводит все четные числа от одного до введенного N

int a, count = 2;

Console.Write("Input a number: ");
a = Convert.ToInt32(Console.ReadLine());

if (a % 2 == 0)
{
    while (count <= a)
    {
        Console.Write(count + " ");
        count = count + 2;
    }
}
else
{
    while (count < a)
    {
        Console.Write(count + " ");
        count = count + 2;
    }
}











/*

int a, count = 2;

Console.Write("Input a number: ");
a = Convert.ToInt32(Console.ReadLine());

    if (a % 2 == 0)
    {
        while (count <= a)
        {
        Console.Write(count + " ");
        count = count + 2;
        }
    }
    else
    {
        while (count < a)
        {
        Console.Write(count + " ");
        count = count + 2;
        }
    }

*/

// С этой задачей немного! поломал голову но лекция была в помощь!
