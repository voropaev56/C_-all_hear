// программа переворачивает массив

int[] ReverseArray(int[] array)
{
    for(int i = 0; i < array.Length / 2; i++)
    {
        int temp = array[i];
        array[i] = array[array.Length - 1 - i];  // array.Length - 1 - индекс последнего элемента
        array[array.Length - 1 - i] = temp;
    }
    return array;
}

// 3 1 2 3 5 6
// 0 1 2 3 4 5

// -----------------------------------------------------
/*
int[] ReverseArray(int[] array)
{
    for(int i = 0; j = array.Length - 1; i < j; i++, j--)
    {
        int temp = array[i];
        array[i] = array[j];  
        array[j] = temp
    }
    
// -----------------------------------------------------
int i = 0, j = array.Length - 1 ;

    while(i < j)
    {
        int temp = array[i];
        array[i] = array[j];  
        array[j] = temp;

        i++;
        j--;
    }
 
    return array;
}
*/
// -----------------------------------------------------

int[] myArray = {3, 5, 1, 8, 2, 9, 4};

myArray = ReverseArray(myArray);

for(int i = 0; i < myArray.Length; i++)
    Console.Write(myArray[i] + " ");



