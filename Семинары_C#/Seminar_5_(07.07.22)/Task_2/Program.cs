﻿
// Метод который генерирует массив заполненный случайными элементами

int[] CreateRandomArray(int size, int minValue, int maxValue)
{
    int[] newArray = new int[size]; // строка инициализирует новый массив

    for(int i = 0; i < size; i++)

        newArray[i] = new Random().Next(minValue, maxValue + 1);

        return newArray;
}

//------------------------------------
// Метод который генерирует массив заполненный данными пользователя

int[] CreateArray(int size)
{
    int[] newArray = new int[size];

    Console.WriteLine("Creating array here: ");
    for(int i = 0; i < size; i++)
    {
        Console.Write($"Input {i + 1} element: ");
        newArray[i] = Convert.ToInt32(Console.ReadLine());

    }
    Console.WriteLine();
    return newArray;
}


//------------------------------------
// метод который будет возвращать массив на экран

void  ShowArray(int [] array)
{
    for(int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");

    Console.WriteLine();
}

//------------------------------------


Console.Write("Input size of array: ");
int size = Convert.ToInt32(Console.ReadLine());
Console.Write("Input min possible value of elements: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input max possible value of elements: ");
int max = Convert.ToInt32(Console.ReadLine());

int[] array1 = CreateRandomArray(size, min, max);
int[] array2 = CreateArray(size);

ShowArray(array1); // случайно сгенерировался
ShowArray(array2); // мы ввели сами