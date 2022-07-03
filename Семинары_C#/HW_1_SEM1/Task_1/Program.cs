// Программа из двух введеных чисел определяет какое меньше и какое больше

int a, b;

Console.Write("Input a first number:  ");
a = Convert.ToInt32(Console.ReadLine());

Console.Write("Input a second number:  ");
b = Convert.ToInt32(Console.ReadLine());

if (a > b)
{
    Console.WriteLine("max = " + a);
    Console.WriteLine("min = " + b);
}

else
{
    Console.WriteLine("max = " + b);
    Console.WriteLine("min = " + a);
}

// Павел, я тут очень долго мучился {} с этими ковычками, без них не работало, также вторые ковычки else я упорно делал внутри if.
// Так и не понял почему без них не работает на уроке практики было без них вроде!