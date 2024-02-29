using System;

class Program
{
    static void Main()
    {
        char[] alphabet = { '0', '1', '2' };

        Console.WriteLine("Palindroame de lungime 1:");
        GeneratePalindromes(alphabet, 1);

        Console.WriteLine("\nPalindroame de lungime 2:");
        GeneratePalindromes(alphabet, 2);

        Console.WriteLine("\nPalindroame de lungime 3:");
        GeneratePalindromes(alphabet, 3);

        Console.WriteLine("\nPalindroame de lungime 4:");
        GeneratePalindromes(alphabet, 4);

        Console.WriteLine("\nPalindroame de lungime 5:");
        GeneratePalindromes(alphabet, 5);
    }

    static void GeneratePalindromes(char[] alphabet, int length)
    {
        GeneratePalindromesHelper(alphabet, length, "");
    }

    static void GeneratePalindromesHelper(char[] alphabet, int remainingLength, string currentPalindrome)
    {
        if (remainingLength == 0)
        {
            Console.WriteLine(currentPalindrome);
            return;
        }

        foreach (char symbol in alphabet)
        {
            string newPalindrome = symbol + currentPalindrome + symbol;
            GeneratePalindromesHelper(alphabet, remainingLength - 2, newPalindrome);
        }
    }
}
