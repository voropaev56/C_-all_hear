/*
Задача 29: Напишите программу, которая задаёт массив из m элементов и выводит их на экран.
1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
6, 1, 33 -> [6, 1, 33]
*/

int[] CreateRandomArray(int size)
{
    int[] newArray = new int[size]; 

    for(int i = 0; i < size; i++)

        newArray[i] = new Random().Next(0, 1000);

        return newArray;
}

void  ShowArray(int [] array)
{
    for(int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");

    Console.WriteLine();
}

Console.Write("Input size of array: ");
int size = Convert.ToInt32(Console.ReadLine());
int[] array123 = CreateRandomArray(size);
ShowArray(array123); 













