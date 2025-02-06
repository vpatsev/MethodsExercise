int x  = int.Parse(Console.ReadLine());
int y  = int.Parse(Console.ReadLine());

int xFactorial = Factorial(x);
int yFactorial = Factorial(y);

int result = xFactorial / yFactorial;

Console.WriteLine(result);

static int Factorial(int x)
{   int result = 1;

    for (int i = x; i >= 1; i--) {
        result *= i;
    }
    return result;
}