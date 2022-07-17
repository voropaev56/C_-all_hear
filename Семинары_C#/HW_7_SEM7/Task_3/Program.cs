/*
Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее 
арифметическое элементов в каждом столбце.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3
*/


int[,] CreateRandom2DArray(int rows, int columns, int minValue, int maxValue)
{
    int[,] newArray = new int[rows,columns];
        for(int i = 0; i < rows; i++)
            for(int j = 0; j < columns; j++)
            newArray[i,j] = new Random().Next(minValue, maxValue + 1);
    return newArray;     
}

void Show2Array(int[,] array)
{
    for(int i=0; i < array.GetLength(0); i++)
    {
        for(int j=0; j < array.GetLength(1); j++)
            Console.Write(array[i,j] + " ");
       Console.WriteLine();
    }
}

int AverageColumns(int[,] array)
{
     for(int i = 0; i < array.GetLength(0); i++)
        
        for(int j = 0; j < array.GetLength(1); j++)
        int count = 0;
        count = array[i,j] + count;
        j = j + 1;
        
    return count;
}

Console.WriteLine("Input number of rows: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input number of columns: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input min value: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input max value: ");
int max = Convert.ToInt32(Console.ReadLine());

int[,] myArray = CreateRandom2DArray(m,n,min,max);
Show2Array(myArray);










