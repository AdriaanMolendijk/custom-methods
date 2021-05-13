def get_num_divisors(n):
    primeFactorization = prime_factorization(n)
    primes = {}
    for p in primeFactorization:
        if p in primes:
            primes[p] = primes[p] + 1
            continue
        primes[p] = 1
    prod = 1
    for p in primes:
        prod *= primes[p] + 1
    return prod