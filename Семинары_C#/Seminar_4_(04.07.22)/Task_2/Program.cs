// определить количество знаков введенного числа

Console.Write("Input a number:  ");
int num1 = Convert.ToInt32(Console.ReadLine());

int NumberKolich(int num)
{
    /*
   int result = 1;
   int i = 1;
   
   
   while (num/i > 10)
   {
        i = i * 10;
        result = result+1;
   }
        return result;
*/
                    
        int count = 0;
        while (num > 0)
        {
        num = num / 10;
        count = count + 1;
        }
        return count;
        
}

Console.WriteLine(NumberKolich(num1));
