// программа принимает на вход число n и выдает произвдение чисел от 1 до n

int Proisvedenie(int num)
{
    int result = 1;
    for(int i = 1; i <= num; i++)
    result = result * i;
    return result;
}

Console.Write("Input a number:  ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(Proisvedenie(num1));




/*
//___________________________________

Console.Write("Input a number:  ");
int num1 = Convert.ToInt32(Console.ReadLine());

int Numproizved(int num1)
{
    
    for(int current = 1; current <= a; current++)
        proizvod = proizvod*current;

        return proizvod;
}

int a = NumberVoid(num1);
Console.WriteLine(a);

//___________________________________

Console.Write("Input a number A:  ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a number B:  ");
int num2 = Convert.ToInt32(Console.ReadLine());

void

while ()
A = A * count
A = A * A

*/
