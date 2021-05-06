import java.util.ArrayList;
import java.util.HashMap;
import java.util.Map;

public class GetNumDivisors {

    /**
     * This method returns the number of divisors of a number.
     * @param n the number of which to count the number of divisors.
     * @return the number of divisors of n.
     */
    public static int getNumDivisors(long n)
    {
        ArrayList<Long> primeFactorization = primeFactorization(n);
        Map<Long, Integer> primes = new HashMap<Long, Integer>();
        for (long p : primeFactorization)
        {
            // check if prime is already in the mapping
            if (primes.containsKey(p))
            {
                primes.put(p, primes.get(p) + 1);
                continue;
            }
            primes.put(p,1);
        }
        int prod = 1;
        for (long key : primes.keySet())
        prod *= (primes.get(key)+1);
        return prod;
    }

}
