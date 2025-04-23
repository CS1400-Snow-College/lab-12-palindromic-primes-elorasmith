
// Elora Smith, 4/23/25, Lab 12 Palindromic Primes

using System.Data;
using System.Diagnostics;
using System.Globalization;

Debug.Assert(IsPrime(7) == true);
Debug.Assert(IsPrime(10) == false);
Debug.Assert(IsPrime(1) == false);
Debug.Assert(IsPrime(104729) == true);
Debug.Assert(IsPrime(25) == false);

Debug.Assert(IsPalindromic(101) == true);
Debug.Assert(IsPalindromic(23) == false);
Debug.Assert(IsPalindromic(114232411) == true);

Console.Clear();
int result = GetNthPalindromicPrime(100);
Debug.Assert(result == 94049);
result = GetNthPalindromicPrime(6);
Debug.Assert((result == 132) == false);


Console.Clear();
Console.WriteLine("Welcome. Here you can find any index of the palindromic prime numbers. Which one would you like to see?");
string? input = Console.ReadLine();
int n;
while (!int.TryParse(input, out n))
{
    Console.WriteLine("That's not a number. Try again.");
    Console.WriteLine("Which nth palindromic prime would you like to see?");
    input = Console.ReadLine();
}
while (n < 1 || n > 2000)
{
    Console.WriteLine("Number out of range. Try again.");
    Console.WriteLine("Which nth palindromic prime would you like to see?");
    n = Convert.ToInt32(Console.ReadLine());
}

result = GetNthPalindromicPrime(n);
Console.WriteLine($"The {n}th palindromic prime is {result}.");


static int GetNthPalindromicPrime(int n)
{
    int num;
    int primePalindromes = 0;
    for (num = 2; primePalindromes < n; num++)
    {
        if (IsPrime(num) && IsPalindromic(num))
            primePalindromes++;
        if (primePalindromes == n)
            break;
    }
    return num;
}

static bool IsPrime(int num)
{
    if (num <= 1)
        return false;
    for (int i = 2; i <= Math.Sqrt(num); i++)
    {
        if (num % i == 0)
            return false;
    }
    return true;
}

static bool IsPalindromic(int num)
{
    string numString = num.ToString();
    char[] numArray = numString.ToCharArray();
    Array.Reverse(numArray);
    if (numString == new string(numArray))
        return true;
    else return false;
}
