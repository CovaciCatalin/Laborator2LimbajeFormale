using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Iterația 1:");
        GenerateStrings(1);

        Console.WriteLine("\nIterația 2:");
        GenerateStrings(2);

        Console.WriteLine("\nIterația 3:");
        GenerateStrings(3);
    }

    static void GenerateStrings(int iteration)
    {
        GenerateStringsHelper(iteration, "S");
    }

    static void GenerateStringsHelper(int remainingIterations, string currentString)
    {
        if (remainingIterations == 0)
        {
            Console.WriteLine(currentString);
            return;
        }

    
        GenerateStringsHelper(remainingIterations - 1, "a" + currentString + "a");
        GenerateStringsHelper(remainingIterations - 1, "b" + currentString + "b");
        GenerateStringsHelper(remainingIterations - 1, "a");
        GenerateStringsHelper(remainingIterations - 1, "b");
        GenerateStringsHelper(remainingIterations - 1, "");
    }
}
