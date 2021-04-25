public class IsPrime {

    /**
     * This method determines whether an integer is prime or not.
     * @param n the number on which to perform the primality test.
     * @return true iff n is prime.
     */
    public static boolean isPrime(long n)
    {
        if (n <= 1) return false;
        if (n == 2 || n == 3) return true;
        if (n % 2 == 0 || n % 3 == 0) return false;
        for (int i = 5; i <= Math.sqrt(n); i += 6)
        {
            if (n % i == 0) return false;
            if (n % (i + 2) == 0) return false;
        }
        return true;
    }
}
