int num = int.Parse(Console.ReadLine());
int result = GetMultipleOfEvenAndOdds(Math.Abs(num));
Console.WriteLine(result);

static int GetMultipleOfEvenAndOdds(int num)
{
    int evenDigits = GetSumOfEvenDigits(num);
    int oddDigits = GetSumOfOddDigits(num);
    return evenDigits * oddDigits;  
}

static int GetSumOfEvenDigits(int num   )
{    int sumOfDigits = 0;
    while(num > 0)
    {
        int lastDigit = num % 10;
        if (num % 2 == 1) { sumOfDigits += lastDigit; }
        num /= 10;  
    }
    return sumOfDigits;
}  

static int GetSumOfOddDigits(int num)
{
    int sumOfDigits = 0;
    while (num > 0)
    {    int lastDigit = num % 10;
        if (num % 2 == 0) { sumOfDigits += lastDigit; }
         num /= 10;
    }
    return sumOfDigits;
}