// Задача 50. Напишите программу, которая на вход принимает позиции элемента
// в двумерном массиве, и возвращает значение этого элемента или же указание,
// что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

Console.WriteLine("Input number of row of the element: ");
int i_input = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input number of column of the element: ");
int j_input = Convert.ToInt32(Console.ReadLine());

int[,] CreateRandom2DArray(int rows, int columns)
{
    int[,] newArray = new int[rows,columns];
        for(int i = 0; i < rows; i++)
            for(int j = 0; j < columns; j++)
            newArray[i,j] = new Random().Next(-1000, 1001);
    return newArray;     
}

void Show2DArray(int[,] array)
{
    for(int i=0; i < array.GetLength(0); i++)
    {
        for(int j=0; j < array.GetLength(1); j++)
            Console.Write(array[i,j] + " ");
       Console.WriteLine();
    }
}

int[,] Numbercheck(int[,] array)
{
    for(int i=0; i < array.GetLength(0); i++)
        for(int j=0; j < array.GetLength(1); j++)
            if (i == i_input && j == j_input)
                Console.WriteLine(array[i_input, j_input]);
                else Console.WriteLine("There is no such number in the array");

    return array;
}

int[,] myArray1 = CreateRandom2DArray(5,5); // задаем размер массива
Console.WriteLine();
Console.WriteLine("This is array for check:");
Show2DArray(myArray1);
Console.WriteLine();
Console.WriteLine(Numbercheck);









