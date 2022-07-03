int MaxNumber()

{
    int num = new Random().Next(10,100);
    Console.WriteLine("Current random number is " + num);

    int des = num / 10;
    int ed = num % 10;
   
    if(ed > des)
    {
        return ed; 
    }
    else
    {
        return des; 
    }
}

int max = MaxNumber();
Console.WriteLine("max =  " + max);