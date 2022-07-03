int Max (int arg1, int arg2, int arg3)
{
    int result = arg1;
    if (arg2 > result) result = arg2;
    if (arg3 > result) result = arg3;
    return result;
}

/*
// Смена числа массива с заданным индексом и вывод его
//              0    1   2   3   4   5   6   7  8
int[] array = {12, 462, 35, 41, 45, 66, 47, 28, 9};
array[0] = 14;
Console.WriteLine(array[0]);
*/

// вывод максимального значени массива
//              0    1   2   3   4   5   6   7  8
int[] array = {12, 462, 35, 41, 45, 676, 47, 28, 9};

int result = Max (
    Max (array[0], array[1],array[2]),
    Max (array[3], array[4],array[5]),
    Max (array[6], array[7],array[8])
                                    );

Console.WriteLine(result);




