
// Задать двумерный массив размером m на n

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

/*
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
*/

// _________________________________________________________

// задача 1
// Задайте двумерный массив размера m на n, каждый 
// элемент в массиве находится по формуле: Aij = i+j. Выведите полученный массив на экран.


int[,] CreateRandom2DArray1(int rows, int columns)
{
    int[,] newArray = new int[rows,columns];
        for(int i = 0; i < rows; i++)
            for(int j = 0; j < columns; j++)
            newArray[i,j] = i + j;

    return newArray;     

}
/*
Console.WriteLine("Input number of rows: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input number of columns: ");
int n = Convert.ToInt32(Console.ReadLine());
int[,] myArray = CreateRandom2DArray1(m,n);
Show2Array(myArray);
*/

// _________________________________________________________
// задача 2
// Задайте двумерный массив. Найдите элементы, у которых оба индекса чётные, и замените
// эти элементы на их квадраты.

int[,] FindEvenChange(int[,] array)
{
    for(int i=0; i < array.GetLength(0); i++)
        for(int j=0; j < array.GetLength(1); j++)
            if(i % 2 == 0 && j % 2 == 0)
                array[i,j] = array[i,j] * array[i,j];

    return array;
}



Console.WriteLine("Input number of rows: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input number of columns: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input min value: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input max value: ");
int max = Convert.ToInt32(Console.ReadLine());

int[,] myArray123 = CreateRandom2DArray(m,n,min,max);
Show2Array(myArray123);
Console.WriteLine();

myArray123 = FindEvenChange(myArray123);
Show2Array(myArray123);








// _________________________________________________________
// задача 3
// Задайте двумерный массив. Найдите сумму элементов, находящихся на главной диагонали
// (с индексами (0,0); (1;1) и т.д.

/*
int FindDiagSum (int[,] array)
{
    int sum = 0;
    
    if(array.GetLength(0) == array.GetLength(1))
    {
    for (int i=0; i < array.GetLength(0); i++)
        sum = sum + array[i,j];

    }
    return sum;
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
Console.WriteLine("Sum of main is" + FindDiagSum);
*/
























