// Задайте массив вещественных чисел. Найдите разницу между максимальным и 
// минимальным элементов массива.
// [3 7 22 2 78] -> 76


int[] CreateRandomArray(int size)
{
    int[] newArray = new int[size]; 
    for(int i = 0; i < size; i++)
        newArray[i] = new Random().Next(-1000, 1001);
        return newArray;
}

void  ShowArray(int [] array)
{
    for(int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");

    Console.WriteLine();
}

int MinMaxDifference(int[] newArray)
{
    int min = newArray[0];
    int max = newArray[0];
    int difference = 0;
    for(int i = 0; i < newArray.Length; i++)
    {
    if(newArray[i] > max) max = newArray[i];
    if(newArray[i] < min) min = newArray[i];
    difference = max - min;
    }
    return difference;
}

Console.Write("Input size of array: ");
int size = Convert.ToInt32(Console.ReadLine());
int[] array1 = CreateRandomArray(size);
ShowArray(array1);
Console.WriteLine("The min max difference is: " + MinMaxDifference(array1));











