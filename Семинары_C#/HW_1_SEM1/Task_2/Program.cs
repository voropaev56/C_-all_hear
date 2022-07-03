// Программа выдает максимум из трех чисел

int a, b, c;

Console.Write("Input a first number:  ");
a = Convert.ToInt32(Console.ReadLine());

Console.Write("Input a second number:  ");
b = Convert.ToInt32(Console.ReadLine());

Console.Write("Input a third number:  ");
c = Convert.ToInt32(Console.ReadLine());

int max = a;

if (b > max) max = b;
if (c > max) max = c;

Console.WriteLine("max = " + max);

/*
 Тут, Павел, я очень долго мучился тоже))
сделал не так "max = b и max = c"
а так "b = max и c = max" и у меня все время первое число было максимальным)))
*/
