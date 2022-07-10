// 

int[,] pic = new int[,]
{
    {0, 0, 1, 0, 0 ........}
    {0, 1, 1, 0, }
 // нам задан массив с числами 0 и 1 где рисунок палец вверх например из единичек
}

void PrintImage(int[,] image)
{
    for (int i = 0; i < image.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(0); j++)
        {
            if(image[i, j] == 0) Console.Write($"{image[i, j]} ");
            else Console.Write($"+");
        }
        Console.WriteLine();
    }
}

void c(int row, int col)
{
    if(pic[row, col] == 0)
    {
        pic[row, col] = 1;
        FillImage(row-1, col);
        FillImage(row, col-1);
        FillImage(row+1, col);
        FillImage(row, col+1);
    }
}

PrintImage(pic);
FillImage(13, 13);   // любая точка которая должна быть внутри контура рисунка
PrintImage(pic);
