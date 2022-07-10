
// найти сумму чисел от 1 до введенного n

int FindSum(int a)
{
    int sum = 0;

    for(int current = 1; current <= a; current++)
        sum = sum + current

        return sum;
}

Console.Write("Input positive integer number: ");
int num = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Sum of numbers from 1 to {num} is {FindSum(num)}");

// ___________________________________________________________


