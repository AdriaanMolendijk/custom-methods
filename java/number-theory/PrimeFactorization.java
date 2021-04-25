import java.util.ArrayList;

public class PrimeFactorization {

    /**
     * This method returns the prime factorization of a number.
     * @param l the number to be factorized
     * @return an ArrayList representing the prime factorization.
     */
    public static ArrayList<Long> primeFactorization(long l)
    {
        ArrayList<Long> primeFactorization = new ArrayList();
        long div = 1;
        while (l != 1)
        {
            div++;

            // if div divides l
            if (l % div == 0)
            {
                primeFactorization.add(div);
                l /= div;
                div--;
                continue;
            }

            if (div > Math.sqrt(l))
            {
                primeFactorization.add(l);
                break;
            }
        }

        return primeFactorization;
    }
}
