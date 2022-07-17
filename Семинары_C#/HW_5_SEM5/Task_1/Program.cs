/*
Задача 34: Задайте массив заполненный случайными положительными
трёхзначными числами. Напишите программу, которая покажет
количество чётных чисел в массиве.
[345, 897, 568, 234] -> 2
*/

int[] CreateRandomArray(int size)
{
    int[] newArray = new int[size]; 
    for(int i = 0; i < size; i++)
        newArray[i] = new Random().Next(100, 1000);
        return newArray;
}

int CountEvenNumbers(int[] newArray)
{
    int count = 0;
    for(int i = 0; i < newArray.Length; i++)
    {
    if(newArray[i] % 2 == 0 && newArray[i] > 0) 
        count = count + 1; 
    }
    return count;
}

void  ShowArray(int [] array)
{
    for(int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");

    Console.WriteLine();
}

Console.Write("Input size of array: ");
int size = Convert.ToInt32(Console.ReadLine());
int[] array1 = CreateRandomArray(size);
ShowArray(array1);
Console.WriteLine("The number of even numbers in the array is: " + CountEvenNumbers(array1));


