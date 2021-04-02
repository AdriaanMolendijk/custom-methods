/// <summary>
/// This method returns the number of divisors of a number.
/// </summary>
/// <param name="n">the number of which to count the number of divisors.</param>
/// <returns>the number of divisors of n.</returns>
static int GetNumDivisors(long n)
{
    ArrayList primeFactorization = PrimeFactorization(n);
    Dictionary<long, int> primes = new Dictionary<long, int>();
    foreach (long p in primeFactorization)
    {
        // check if prime is already in the mapping
        if (primes.ContainsKey(p))
        {
            primes[p]++;
            continue;
        }
        primes.Add(p, 1);
    }
    int prod = 1;
    foreach (long key in primes.Keys)
        prod *= (primes[key]+1);
    return prod;
}