int a = int.Parse(Console.ReadLine());
int b = int.Parse(Console.ReadLine());
int c = int.Parse(Console.ReadLine());

if (IsZero(a, b, c))
{
    Console.WriteLine("zero");
}
else if (IsPositive(a, b, c))
{
    Console.WriteLine("positive");
}
else
{
    Console.WriteLine("negative"); }

    static bool IsZero(int a, int b, int c)
    {
        if (a == 0 || b == 0 || c == 0)
        {
            return true;
        }
        return false;
    }


    static bool IsPositive(int a, int b, int c)
    {   
    int negativeCount = 0;
   
    if (a < 0)
    {
        negativeCount++; 
    }
    if (b < 0) { 
        negativeCount++; 
    }
    if (c < 0)
    {
        negativeCount++;
    }  return negativeCount % 2 == 0;
}    


