
// Elora Smith, 4/23/25, Lab 12 Palindromic Primes

using System.Diagnostics;

Debug.Assert(IsPrime(7) == true);
Debug.Assert(IsPrime(10) == false);
Debug.Assert(IsPrime(1) == false);
Debug.Assert(IsPrime(104729) == true);
Debug.Assert(IsPrime(25) == false);

Debug.Assert(IsPalindromic(101) == true);
Debug.Assert(IsPalindromic(23) == false);
Debug.Assert(IsPalindromic(114232411) == true);


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
