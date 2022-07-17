// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0


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

int OddElementsSum(int[] newArray)
{
    int count = 0;
    for(int i = 1; i < newArray.Length; i = i + 2)
    {
    count = newArray[i] + count;
    }
    return count;
}


Console.Write("Input size of array: ");
int size = Convert.ToInt32(Console.ReadLine());
int[] array1 = CreateRandomArray(size);
ShowArray(array1);
Console.WriteLine("The odd elements sum is: " + OddElementsSum(array1));












