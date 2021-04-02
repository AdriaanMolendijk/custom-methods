/// <summary>
/// This method returns the primes sieve of all numbers up to a certain limit.
/// </summary>
/// <param name="limit">the limit of the prime sieve.</param>
/// <returns>a boolean[] representing the sieve up to limit.</returns>
/// <exception cref="ArgumentException">thrown limit < 1</exception>
static bool[] PrimeSieve(int limit)
{
    if (limit <= 0) throw new ArgumentException("Limit must be >= 1.");

    // limit >= 1 here
    bool[] sieve = new bool[limit];
    for (int i = 2; i <= limit; i++) sieve[i - 1] = true;

    int j;
    for (int i = 2; i <= Math.Sqrt(limit); i++)
    {
        if (sieve[i - 1])
        {
            j = i * i;
            while (j <= limit)
            {
                sieve[j - 1] = false;
                j += i;
            }
        }
    }
    return sieve;
}