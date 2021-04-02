/// <summary>
/// This method returns the prime factorization of a number.
/// </summary>
/// <param name="n">the number to be factorized.</param>
/// <returns>an ArrayList representing the factorization.</returns>
static ArrayList PrimeFactorization(long n)
{
    ArrayList primeFactorization = new ArrayList();
    long div = 1;
    while (n != 1)
    {
        div++;
        if (n % div == 0)
        {
            primeFactorization.Add(div);
            n /= div;
            div--;
        }

        if (div > Math.Sqrt(n))
        {
            primeFactorization.Add(n);
            break;
        }
    }
    return primeFactorization;
}