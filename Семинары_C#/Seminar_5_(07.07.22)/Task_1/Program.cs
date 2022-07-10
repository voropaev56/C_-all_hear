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
