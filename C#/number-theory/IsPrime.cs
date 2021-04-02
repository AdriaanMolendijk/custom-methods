/// <summary>
/// This method determines whether an integer is prime or not.
/// </summary>
/// <param name="n">the number on which to do the primality test.</param>
/// <returns>true iff n is prime.</returns>
static bool IsPrime(long n)
{
    if (n <= 1) return false;
    if (n == 2 || n == 3) return true;
    if (n % 2 == 0 || n % 3 == 0) return false;
    for (int i = 5; i <= Math.Sqrt(n); i += 6)
    {
        if (n % i == 0) return false;
        if (n % (i + 2) == 0) return false;
    }
    return true;
}