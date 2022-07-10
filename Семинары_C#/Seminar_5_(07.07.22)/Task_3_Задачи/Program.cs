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


/*

// задача 1 найти сумму положительных элементов массива

int FindPositiveSum(int[] array)
{
    int sum = 0;
    for(int i = 0; i < array.Length; i++)
{
    if(array[i] > 0) 
        sum = sum + array[i];
}
return sum;

}

Console.Write("Input size of array: ");
int size = Convert.ToInt32(Console.ReadLine());
Console.Write("Input min possible value of elements: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input max possible value of elements: ");
int max = Convert.ToInt32(Console.ReadLine());

int[] array = CreateRandomArray(size, min, max);
ShowArray(array);
int sumPositive = FindPositiveSum(array);
Console.WriteLine("Sum of positive elements in current array is: " + sumPositive);

*/

//------------------------------------

// задача 2 которая положительные элементы заменти на отрицательные и наооборот
/*
int[] Array123(int[] newArray)
{
    for (int i = 0; i < newArray.Length; i++)
    newArray[i] = newArray[i] * -1;
    
    return newArray;
}

Console.Write("Input size of array: ");
int size = Convert.ToInt32(Console.ReadLine());
Console.Write("Input min possible value of elements: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input max possible value of elements: ");
int max = Convert.ToInt32(Console.ReadLine());

int[] array = CreateRandomArray(size, min, max);
ShowArray(array);
int[] Array1234567 = Array123(newArray);
ShowArray(Array1234567);

*/

//------------------------------------

// задача 3 задать массив из 20 случайных чисел найти количество элементов массива значения которых лежат в значении от 10 до 99

int FindTwoDigits(int[] array)
{
    int count = 0;

    for (int i = 0; i < array.Length; i++)
        if (array[i] >= 10 && array[i] <= 99)
        count = count + 1;

    return count;
}

int size = 20;
Console.Write("Input min possible value of elements: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input max possible value of elements: ");
int max = Convert.ToInt32(Console.ReadLine());

int[] array = CreateRandomArray(size, min, max);
ShowArray(array);
Console.WriteLine("Count of two two-digit elements is: " + FindTwoDigits(array));

