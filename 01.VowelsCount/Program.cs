using System.Diagnostics.Metrics;
using System.Reflection;
using System.Runtime.CompilerServices;

string text = Console.ReadLine();

int result = PrintVowelsCount(text);
Console.WriteLine(result);

static int PrintVowelsCount(string text)
{
    {
        int counter = 0;

        foreach (char letter in text)
        if (letter == 'a' ||
            letter == 'o' ||
            letter == 'u' ||
            letter == 'e' ||
            letter == 'i' ||
            letter == 'A' ||
            letter == 'O' ||
            letter == 'U' ||
            letter == 'E' ||
            letter == 'I')
        {
            counter++;
            }
        return counter;


    }


}