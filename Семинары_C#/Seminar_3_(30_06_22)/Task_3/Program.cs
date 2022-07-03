// программа принимает число н и возсращает все квадраты чисел от единицы до н

Console.WriteLine("Input n: ");
int n1 = Convert.ToInt32(Console.ReadLine());

void Quad (int n)
{
int current = 1;
while (current < n)
{
    int quad = current * current;
    Console.Write(quad + " ");
    current++;
}
}

Quad (n1);