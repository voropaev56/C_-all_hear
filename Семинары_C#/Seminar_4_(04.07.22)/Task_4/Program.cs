// программа принимает на вход два числа A и B и возводит число A в натуральную степень B

Console.Write("Input a number A:  ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a number B:  ");
int m = Convert.ToInt32(Console.ReadLine());

int Stepen(int a, int b)
{
    int result = 1;
    for(int i = 1; i <= b; i++)
    {
        result = result * a;
        return result;
    }
}

Console.WriteLine(Stepen(n, m));
