import math

# This method returns the prime factorization of a number.
# n the number to be factorized
# returns a list representing the prime factorization.
def prime_factorization(n):
    factorization = []
    div = 1
    while n != 1:
        div = div + 1
        if n % div == 0:
            factorization.append(div)
            n /= div
            div = div - 1
            continue

        if div > math.sqrt(n):
            factorization.append(int(n))
            break
    return factorization
