/*
int CutNumber()
{
    int num = new Random().Next(100,1000);
    Console.WriteLine("Current random number is" + num);

    int sotni = num / 100;
    int ed = num % 10;

    int result = sotni*10 + ed;
    return result;
}
*/



// ________________________________________________________________________
void CutNumberVoid()
{
    int num = new Random().Next(100,1000);
    Console.WriteLine("Current random number is  " + num);

    int sotni = num / 100;
    int ed = num % 10;

    int result = sotni*10 + ed;
    Console.WriteLine("Result number is: " + result);
}

CutNumberVoid();




