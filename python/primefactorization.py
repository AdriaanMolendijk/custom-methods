# This method returns the prime factorization of a number.
# l the number to be factorized
# return an ArrayList representing the prime factorization.
def prime_factorization(n):
    factorization = []
    div = 1
    while n != 1:
        if n % div == 0:
            factorization.append(div)
            div = div - 1
            continue

        if div > math.sqrt(n):
            factorization.append(n)
            break