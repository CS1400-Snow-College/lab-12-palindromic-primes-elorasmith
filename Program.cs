
// Elora Smith, 4/23/25, Lab 12 Palindromic Primes

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
//result = GetNthPalindromicPrime(1000);
//Debug.Assert(result == 114232411);

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
    Console.WriteLine($"num = {num}, primePalindromes = {primePalindromes}");
    return num;
}

static bool IsPrime(int num)
{
    if (num <= 1)
        return false;
    for (int i = 2; i < num; i++)
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
