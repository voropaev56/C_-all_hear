int a;

Console.Write("Input a number:  ");
a = Convert.ToInt32(Console.ReadLine());

void CutNumberVoid()
{
    if (a % 7 == 0 && a % 23 == 0)
    {
        Console.WriteLine("Число делится на 7 и 23");
    }
    else
    {
        Console.WriteLine("Число не делится на 7 и 23");
    }
     
}

CutNumberVoid();
