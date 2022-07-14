// программа десятичное число переводит в двоичное

// 18 / 2 => 9 0
// 9 / 2 => 4 1
// 4 / 2 => 2 0
// 2 / 2 => 1 0
// 1 / 2 => 0 1


// 18 ---- 1 0 0 1 0

string ChangeDigitSystem(int num)
{
    string resultNumber = string.Empty;

        while(num > 0)
        {
            resultNumber = num % 2 + resultNumber;
            num = num / 2;    // ----   тоже самое num /=2
        } 

        return resultNumber;

}

Console.WriteLine(ChangeDigitSystem(18));




